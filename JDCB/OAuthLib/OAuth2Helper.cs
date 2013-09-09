using OAuthLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace OAuthLib
{
    public enum GrantType
    {
        AuthorizationCode,
        Password,
        RefreshToken,
        SimulateLogin
    }

    public enum TokenResult
    {
        Success,
        Rejected,
        Revoked,
        Expired
    }

    /// <summary>
    /// 
    /// </summary>
    public class OAuth2Helper
    {
        public OAuthSettings Settings { get; private set; }

        public OAuth2Helper(OAuthSettings settings)
        {
            Settings = settings;
            OAuthSettings.OAuthVersion = "2.0";
        }

#if !NETFX_CORE
        /// <summary>
        /// 模拟登录
        /// </summary>
        /// <param name="passport"></param>
        /// <param name="password"></param>
        /// <param name="cancelToken"></param>
        /// <returns></returns>
        public async Task<OAuthAccessToken> LoginAsync(string passport, string password, CancellationToken cancelToken)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) =>
            {
                return true;
            };
            var request = WebRequest.Create(Settings.AuthorizeUrl) as HttpWebRequest;

            request.Referer = GetAuthorizeUrl();
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = new CookieContainer();

            var postBody = GetSimulateLoginPostBody(passport, password);
            var postData = System.Text.Encoding.UTF8.GetBytes(postBody);

            cancelToken.ThrowIfCancellationRequested();
            var result = "";
            using (var requestStream = await request.GetRequestStreamAsync())
            {
                await requestStream.WriteAsync(postData, 0, postData.Length, cancelToken);
            }
            using (var response = await request.GetResponseAsync())
            {
                using (var sr = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    cancelToken.ThrowIfCancellationRequested();
                    result = await sr.ReadToEndAsync();
                    return ConvertToAccessTokenByRegex(result);
                }
            }
        }
#else
        /// <summary>
        /// 模拟登录
        /// </summary>
        /// <param name="passport"></param>
        /// <param name="password"></param>
        /// <param name="cancelToken"></param>
        /// <returns></returns>
        public async Task<OAuthAccessToken> LoginAsync(string passport, string password, CancellationToken cancelToken)
        {
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, Settings.AuthorizeUrl))
                {
                    var referrer = GetAuthorizeUrl();
                    request.Headers.Referrer = new Uri(referrer);

                    var postBody = GetSimulateLoginPostBody(passport, password);
                    request.Content = new StringContent(postBody);
                    request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

                    var response = await client.SendAsync(request);
                    var result = await response.Content.ReadAsStringAsync();
                    return ConvertToAccessTokenByRegex(result);                    
                }
            }
        }
#endif
        public async Task<int> ExpiresInAccessTokenAsync(string accessToken)
        {
            HttpWebRequest request = null;
            try
            {
                request = WebRequest.Create(Settings.QueryAccessTokenUrl) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.CookieContainer = new CookieContainer();

                var parameters = new Dictionary<string, string>();
                parameters.Add("access_token", accessToken);

                var postBody = parameters.BuildToUrlString();
                var postData = System.Text.Encoding.UTF8.GetBytes(postBody);

                using (var requestStream = await request.GetRequestStreamAsync())
                {
                    await requestStream.WriteAsync(postData, 0, postData.Length);
                }

                var expiresIn = 0;
                using (var response = await request.GetResponseAsync())
                {
                    using (var sr = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        var result = await sr.ReadToEndAsync();
                        var regex = new Regex(Constants.OAuth2AccessTokenExpiresInPattern);
                        var match = regex.Match(result);
                        if (match == null)
                        {
                            return expiresIn;
                        }
                        var strExpiresIn = match.Groups["expires_in"].Value;
                        var parseResult = int.TryParse(strExpiresIn, out expiresIn);
                        return expiresIn;
                    }
                }
            }
            finally
            {
                if (request != null)
                    request.Abort();
            }
        }

        /// <summary>
        /// Get AuthorizeUrl
        /// </summary>
        /// <remarks>Firstly, should be get the authorization.</remarks>
        /// <returns></returns>
        public string GetAuthorizeUrl()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("client_id", Settings.AppKey);
            dict.Add("redirect_uri", Settings.CallbackUrl);
            dict.Add("response_type", "code");
            //dict1.Add("display", "default");
            return Settings.AuthorizeUrl + "?" + dict.BuildToUrlString();
        }

        public OAuthAccessToken GetAccessTokenByCode(string code)
        {
            return GetAccessTokenByCodeAsync(code).Result;
        }

        public async Task<OAuthAccessToken> GetAccessTokenByCodeAsync(string code)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("code", code);
            parameters.Add("redirect_uri", Settings.CallbackUrl);
            return await GetAccessTokenAsync(GrantType.AuthorizationCode, parameters);
        }

        public OAuthAccessToken GetAccessTokenByPassword(string passport, string password)
        {
            return GetAccessTokenByPasswordAsync(passport, password).Result;
        }

        public async Task<OAuthAccessToken> GetAccessTokenByPasswordAsync(string passport, string password)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("username", passport);
            parameters.Add("password", password);
            return await GetAccessTokenAsync(GrantType.Password, parameters);
        }

        public OAuthAccessToken GetAccessTokenByRefreshToken(string refreshToken)
        {
            return GetAccessTokenByRefreshTokenAsync(refreshToken).Result;
        }

        public async Task<OAuthAccessToken> GetAccessTokenByRefreshTokenAsync(string refreshToken)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("refresh_token", refreshToken);
            return await GetAccessTokenAsync(GrantType.RefreshToken, parameters);
        }

        internal OAuthAccessToken GetAccessToken(GrantType grantType, Dictionary<string, string> parameters)
        {
            return GetAccessTokenAsync(grantType, parameters).Result;
        }

        public string GetCodeFromCallback(string url)
        {
            var code = url.Substring(url.IndexOf("=") + 1);
            return code;
        }

        /// <summary>
        /// Get AccessToken Async
        /// </summary>
        /// <param name="grantType">authorization_code、password、refresh_token</param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        internal async Task<OAuthAccessToken> GetAccessTokenAsync(GrantType grantType, Dictionary<string, string> parameters)
        {
            if (parameters == null || parameters.Count == 0)
            {
                throw new ArgumentException("GetAccessTokenAsync Parameters is invalid.");
            }

            HttpWebRequest request = null;
            try
            {
                request = WebRequest.Create(Settings.AccessTokenUrl) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.CookieContainer = new CookieContainer();

                parameters.Add("client_id", Settings.AppKey);
                parameters.Add("client_secret", Settings.AppSecret);

                var grant_type = "";
                switch (grantType)
                {
                    case GrantType.AuthorizationCode:
                        grant_type = "authorization_code";
                        break;
                    case GrantType.Password:
                        grant_type = "password";
                        break;
                    case GrantType.RefreshToken:
                        grant_type = "refresh_token";
                        break;
                    default:
                        grant_type = "authorization_code";
                        break;
                }
                parameters.Add("grant_type", grant_type);

                var postBody = parameters.BuildToUrlString();
                var postData = System.Text.Encoding.UTF8.GetBytes(postBody);
                using (var requestStream = await request.GetRequestStreamAsync())
                {
                    await requestStream.WriteAsync(postData, 0, postData.Length);
                }
                using (var response = await request.GetResponseAsync())
                {
                    using (var sr = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        var result = await sr.ReadToEndAsync();
                        return ConvertToAccessTokenByRegex(result);
                    }
                }
            }
            finally
            {
                if (request != null)
                    request.Abort();
            }
        }

        public virtual string GetSimulateLoginPostBody(string passport, string password)
        {
            var dict2 = new Dictionary<string, string>();
            dict2.Add("action", "submit");
            dict2.Add("withOfficalFlag", "0");
            dict2.Add("ticket", null);
            dict2.Add("isLoginSina", null);
            dict2.Add("response_type", "token");
            dict2.Add("regCallback", null);
            dict2.Add("redirect_uri", Settings.CallbackUrl);
            dict2.Add("client_id", Settings.AppKey);
            dict2.Add("state", null);
            dict2.Add("from", null);
            dict2.Add("userId", passport);
            dict2.Add("passwd", password);
            dict2.Add("display", "js");
            return dict2.BuildToUrlString();
        }

        protected virtual OAuthAccessToken ConvertToAccessTokenByRegex(string result)
        {
            OAuthAccessToken oauthAccessToken = null;
            if (!string.IsNullOrEmpty(result) &&
                (Regex.IsMatch(result, Constants.OAuth2AccessTokenPattern1) ||
                 Regex.IsMatch(result, Constants.OAuth2AccessTokenPattern2)))
            {
                var group = result.Contains("refresh_token") ?
                    Regex.Match(result, Constants.OAuth2AccessTokenPattern2) :
                    Regex.Match(result, Constants.OAuth2AccessTokenPattern1);

                var accessToken = group.Groups["token"].Value;
                if (accessToken != null)
                {
                    oauthAccessToken = new OAuthAccessToken();
                    oauthAccessToken.ExpiresIn = Convert.ToInt32(group.Groups["expires"].Value);
                    oauthAccessToken.Token = group.Groups["token"].Value;
                    oauthAccessToken.UserID = group.Groups["uid"].Value;
                }
            }
            return oauthAccessToken;
        }

    }

    public static class DictionaryExtension
    {
        public static string BuildToUrlString(this IDictionary<string, string> obj)
        {
            var sb = new StringBuilder();
            if (obj != null && obj.Count > 0)
            {
                foreach (var kv in obj)
                {
                    sb.AppendFormat("{0}={1}",
                        Uri.EscapeDataString(kv.Key),
                        string.IsNullOrEmpty(kv.Value) ? "" : Uri.EscapeDataString(kv.Value.ToString()));
                    sb.Append("&");
                }
            }
            var urlStr = sb.ToString().TrimEnd('&');
            return urlStr;
        }
    }
}
