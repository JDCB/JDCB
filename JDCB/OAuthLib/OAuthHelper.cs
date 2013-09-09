using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using RestAPICore;
namespace OAuthLib
{
    /// <summary>
    /// Provides helper methods for OAuth.
    /// </summary>
    public class OAuthHelper
    {
        //public OAuthAccessToken AccessToken { get; private set; }
        //public OAuthRequestToken RequestToken { get; private set; }
        //public string Verifier { get; private set; }
        public OAuthSettings Settings { get; private set; }
        //private IDictionary<string, string> _accessTokenParames;

        public OAuthHelper(OAuthSettings settings)
        {
            Settings = settings;
        }

        public IDictionary<string, string> GetOAuthBasicParams()
        {
            var parameters = new Dictionary<string, string>();

            parameters.Add(Constants.OAuthConsumerKey, Settings.AppKey);
            parameters.Add(Constants.OAuthSignatureMethod, OAuthSettings.OAuthSignatureMethod);

            var timestamp = HttpEncoder.ToUnixTime(DateTime.Now);
            parameters.Add(Constants.OAuthTimestamp, timestamp.ToString(CultureInfo.InvariantCulture));
            parameters.Add(Constants.OAuthNonce, Guid.NewGuid().ToString("N"));
            parameters.Add(Constants.OAuthVersion, OAuthSettings.OAuthVersion);

            return parameters;
        }

        public void AppendOAuthHeader(WebRequest request, IDictionary<string, string> accessTokenParams, OAuthAccessToken accessToken)
        {
            if (!accessTokenParams.ContainsKey(Constants.OAuthToken))
                accessTokenParams.Add(Constants.OAuthToken, accessToken.Token);
            var oAuth = ConstructOAuthHeader(accessTokenParams, request.RequestUri.ToString(), request.Method, accessToken.Secret);
            request.Headers[HttpRequestHeader.Authorization] = oAuth;
        }

        public string ConstructOAuthHeader(IDictionary<string, string> parameters, string httpMethod, string url, string tokenSecret, string[] excludedKeys = null)
        {
            var sortedParamsBuilder = new StringBuilder();
            var headerBuilder = new StringBuilder();
            headerBuilder.Append(Constants.OAuthHeaderPrefix);

            foreach (var kv in SortAndEncodeParams(parameters))
            {
                sortedParamsBuilder.AppendFormat("{0}={1}&", kv.Key, kv.Value);
                if (excludedKeys == null || (excludedKeys != null && !excludedKeys.Contains(kv.Key)))
                    headerBuilder.AppendFormat("{0}=\"{1}\", ", kv.Key, kv.Value);
            }

            var sortedParamsString = sortedParamsBuilder.ToString().TrimEnd('&');
            var signatureBaseString = string.Format("{0}&{1}&{2}", httpMethod, HttpEncoder.Encode(url), HttpEncoder.Encode(sortedParamsString));
            var signature = Sign(signatureBaseString, Settings.AppSecret + "&" + tokenSecret);

            headerBuilder.AppendFormat("{0}=\"{1}\"", Constants.OAuthSignature, HttpEncoder.Encode(signature));
            return headerBuilder.ToString();
        }


        public string ConstructOAuthQueryString(IDictionary<string, string> parameters, string httpMethod, string url, string tokenSecret)
        {
            var sortedParamsBuilder = new StringBuilder();
            var oAuthQueryStringBuilder = new StringBuilder();

            foreach (var kv in SortAndEncodeParams(parameters))
            {
                sortedParamsBuilder.AppendFormat("{0}={1}&", kv.Key, kv.Value);
                oAuthQueryStringBuilder.AppendFormat("{0}={1}&", kv.Key, kv.Value);
            }

            var sortedParamsString = sortedParamsBuilder.ToString().TrimEnd('&');
            var signatureBaseString = string.Format("{0}&{1}&{2}", httpMethod, HttpEncoder.Encode(url), HttpEncoder.Encode(sortedParamsString));
            var signature = Sign(signatureBaseString, Settings.AppSecret + "&" + tokenSecret);

            oAuthQueryStringBuilder.AppendFormat("{0}={1}", Constants.OAuthSignature, HttpEncoder.Encode(signature));
            return oAuthQueryStringBuilder.ToString();
        }

        public List<KeyValuePair<string, string>> ConstructOAuthQueryValues(IDictionary<string, string> parameters, string httpMethod, string url, string tokenSecret)
        {
            var sortedParamsBuilder = new StringBuilder();
            var queryValues = new List<KeyValuePair<string, string>>();

            foreach (var kv in SortAndEncodeParams(parameters))
            {
                sortedParamsBuilder.AppendFormat("{0}={1}&", kv.Key, kv.Value);
                queryValues.Add(new KeyValuePair<string, string>(kv.Key, kv.Value));
            }

            var sortedParamsString = sortedParamsBuilder.ToString().TrimEnd('&');
            var signatureBaseString = string.Format("{0}&{1}&{2}", httpMethod, HttpEncoder.Encode(url), HttpEncoder.Encode(sortedParamsString));
            var signature = Sign(signatureBaseString, Settings.AppSecret + "&" + tokenSecret);

            queryValues.Add(new KeyValuePair<string, string>(Constants.OAuthSignature, HttpEncoder.Encode(signature)));
            return queryValues;
        }

        public string ConstructOAuthQueryString(IDictionary<string, string> parameters, Uri uri, string tokenSecret)
        {
            var sortedParamsBuilder = new StringBuilder();
            var oAuthQueryStringBuilder = new StringBuilder();
            var queryString = uri.Query.TrimStart('?');
            foreach (var str in queryString.Split('&'))
            {
                var tmp = str.Split('=');
                parameters.Add(tmp[0], tmp[1]);
            }
            var baseUrl = uri.ToString().Substring(0, uri.ToString().IndexOf('?'));
            return ConstructOAuthQueryString(parameters, "GET", baseUrl, tokenSecret);
        }

        public string PreparePostBody(string url, IDictionary<string, string> customPostParams, OAuthAccessToken accessToken)
        {
            var parameters = GetOAuthBasicParams();
            parameters.Add(Constants.OAuthToken, accessToken.Token);

            if (null != customPostParams)
            {
                parameters.Concat(customPostParams);
            }

            var postBody = ConstructPostBody(parameters, url, accessToken.Secret);
            return postBody;
        }


        private string ConstructPostBody(IDictionary<string, string> parameters, string url, string accessTokenSecret)
        {
            var sortedParamsBuilder = new StringBuilder();

            foreach (var kv in SortAndEncodeParams(parameters))
            {
                sortedParamsBuilder.Append(string.Format("{0}={1}&", kv.Key, kv.Value));
            }
            // Constructs base string
            var sortedParamsString = sortedParamsBuilder.ToString().TrimEnd('&');
            var signatureBaseString = string.Format("{0}&{1}&{2}", "POST", HttpEncoder.Encode(url), HttpEncoder.Encode(sortedParamsString));
            var signature = Sign(signatureBaseString, Settings.AppSecret + "&" + accessTokenSecret);

            var bodyBuilder = new StringBuilder();
            bodyBuilder.Append(sortedParamsBuilder.ToString());
            bodyBuilder.AppendFormat("&{0}={1}", Constants.OAuthSignature, HttpEncoder.Encode(signature));

            return bodyBuilder.ToString();
        }

        private static IOrderedEnumerable<KeyValuePair<string, string>> SortAndEncodeParams(IDictionary<string, string> parameters)
        {
            var encodedParams = new Dictionary<string, string>();
            foreach (var kv in parameters)
            {
                var key = HttpEncoder.Encode(kv.Key);
                var val = HttpEncoder.Encode(kv.Value);
                encodedParams.Add(key, val);
            }
            return encodedParams.OrderBy(kv => kv.Key);
        }

        private static string Sign(string content, string signKey)
        {
#if NETFX_CORE
            Windows.Security.Cryptography.Core.MacAlgorithmProvider HmacSha1Provider = Windows.Security.Cryptography.Core.MacAlgorithmProvider.OpenAlgorithm("HMAC_SHA1");
            var keyMaterial = Windows.Security.Cryptography.CryptographicBuffer.ConvertStringToBinary(signKey, Windows.Security.Cryptography.BinaryStringEncoding.Utf8);
            var hmacSha1Provider = Windows.Security.Cryptography.Core.MacAlgorithmProvider.OpenAlgorithm("HMAC_SHA1");
            var macKey = HmacSha1Provider.CreateKey(keyMaterial);
            var dataToBeSigned = Windows.Security.Cryptography.CryptographicBuffer.ConvertStringToBinary(content, Windows.Security.Cryptography.BinaryStringEncoding.Utf8);
            var signatureBuffer = Windows.Security.Cryptography.Core.CryptographicEngine.Sign(macKey, dataToBeSigned);
            var result = Windows.Security.Cryptography.CryptographicBuffer.EncodeToBase64String(signatureBuffer);
#else
            var data = Encoding.UTF8.GetBytes(content);
            var signKeyBytes = Encoding.UTF8.GetBytes(signKey);
            var algorithm = new System.Security.Cryptography.HMACSHA1(signKeyBytes);
            var result = Convert.ToBase64String(algorithm.ComputeHash(data));
#endif
            return result;
        }

        public OAuthRequestToken GetRequestToken(string callbackUrl)
        {
            return GetRequestTokenAsync(callbackUrl,CancellationToken.None).Result;
        }



        public async Task<OAuthRequestToken> GetRequestTokenAsync(string callbackUrl, CancellationToken cancelToken)
        {
            var headers = GetOAuthBasicParams();

            var oauthQuery = ConstructOAuthQueryString(headers, "GET", Settings.RequestTokenUrl, null);
            var url = Settings.RequestTokenUrl + "?" + oauthQuery;

            var request = WebRequest.Create(url);
            var result = await request.GetStringAsync(cancelToken);

            var match = Regex.Match(result, Constants.RetrieveRequestTokenPattern, RegexOptions.IgnoreCase);
            if (!match.Success)
                throw new Exception("Failed to retrieve request token from the web response.");

            var requestToken = match.Groups[1].Value;
            var requestTokenSecret = match.Groups[2].Value;

            return new OAuthRequestToken { Token = match.Groups[1].Value, Secret = match.Groups[2].Value };
        }



        public string Authorize(string userName, string password, OAuthRequestToken requestToken, CancellationToken cancelToken)
        {
            return AuthorizeAsync(userName, password, requestToken,  cancelToken).Result;
        }

        public async Task<string> AuthorizeAsync(string userName, string password, OAuthRequestToken requestToken, CancellationToken cancelToken)
        {
            if (requestToken == null)
                throw new Exception("Request token is invalid.");

            var queryStringParams = new Dictionary<string, string>();
            queryStringParams.Add(Constants.OAuthToken, requestToken.Token);
            queryStringParams.Add("userId", HttpEncoder.UrlEncode(userName));
            queryStringParams.Add("passwd", HttpEncoder.UrlEncode(password));
            queryStringParams.Add(Constants.OAuthCallback, "xml");

            var authorizeUrl = Settings.AuthorizeUrl + "?";
            foreach (var kv in queryStringParams)
                authorizeUrl += string.Format("{0}={1}&", kv.Key, kv.Value);
            authorizeUrl = authorizeUrl.TrimEnd('&');

            var request = WebRequest.Create(authorizeUrl);
            cancelToken.ThrowIfCancellationRequested();
            var result = await request.GetStringAsync(cancelToken);

            var match = Regex.Match(result, Constants.RetrieveAuthorizationCodePattern, RegexOptions.CultureInvariant);
            if (!match.Success)
                throw new Exception("Invalid user name or password.");

            var verifier = match.Groups[1].Value;
            return verifier;
        }

   

        public OAuthAccessToken GetAccessToken(OAuthRequestToken requestToken, string verifier)
        {
            return GetAccessTokenAsync(requestToken, verifier,CancellationToken.None).Result;
        }

        public async Task<OAuthAccessToken> GetAccessTokenAsync(OAuthRequestToken requestToken, string verifier, CancellationToken cancelToken)
        {
            var accessTokenParams = GetOAuthBasicParams();
            var headers = accessTokenParams.ToDictionary(kv => kv.Key, kv => kv.Value);
            headers.Add(Constants.OAuthToken, requestToken.Token);
            headers.Add(Constants.OAuthVerifier, verifier);
            
            var oAuthQuery = ConstructOAuthQueryString(headers, "GET", Settings.AccessTokenUrl, requestToken.Secret);
            var url = Settings.AccessTokenUrl + "?" + oAuthQuery;

            var request = WebRequest.Create(url);
            cancelToken.ThrowIfCancellationRequested();
            var result = await request.GetStringAsync(cancelToken);

            var accessTokenMatch = Regex.Match(result, Constants.RetrieveAccessTokenPattern, RegexOptions.IgnoreCase);
            if (!accessTokenMatch.Success)
                throw new Exception("Failed to retrieve access token.");

            var accessToken = accessTokenMatch.Groups[1].Value;
            var accessTokenSecret = accessTokenMatch.Groups[2].Value;
            var userID = accessTokenMatch.Groups[4].Value;
            var oauthAccessToken = new OAuthAccessToken() { Token = accessToken, Secret = accessTokenSecret, UserID = userID };

            return oauthAccessToken;
        }

        

        public async virtual Task<OAuthAccessToken> LoginAsync(string userName, string password, CancellationToken cancelToken)
        {
            var requestToken = await GetRequestTokenAsync("oob",cancelToken);
            var verifier = await AuthorizeAsync(userName, password, requestToken,cancelToken);
            cancelToken.ThrowIfCancellationRequested();
            return await GetAccessTokenAsync(requestToken, verifier,cancelToken);
        }

        public OAuthAccessToken Login(string userName, string password)
        {
            return LoginAsync(userName, password,CancellationToken.None).Result;
        }
    }

    public static class WebRequestExtension
    {
        public static async Task<string> GetStringAsync(this WebRequest request, CancellationToken cancelToken)
        {
            request.Method = "GET";
            using (var response = await request.GetResponseAsync ())
            {
                using (var stream = response.GetResponseStream())
                {
                    cancelToken.ThrowIfCancellationRequested();
                    using (var sr = new StreamReader(stream, Encoding.UTF8))
                    {
                        return  await sr.ReadToEndAsync();
                    }
                }
            }
        }
    }
}