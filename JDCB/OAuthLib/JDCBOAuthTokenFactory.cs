using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestAPICore;
using System.Net;
using System.Threading;

namespace OAuthLib
{
    public class JDCBOAuthTokenFactory : IUserNamePasswordAuthTokenFactory
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string RequestTokenUrl { get; set; }
        public string AuthorizeUrl { get; set; }
        public string AccessTokenUrl { get; set; }

        public AuthToken CreateToken()
        {
            return CreateTokenAsync(CancellationToken.None).Result;
        }

        public async System.Threading.Tasks.Task<AuthToken> CreateTokenAsync(CancellationToken cancelToken)
        {
    

            Action<IDictionary<string, object>, string, RequestBase> authorizeByQuery = (context, baseUrl, requestBase) =>
            {
                var oauthHelper = new OAuthLib.OAuthHelper(context["OAuthSettings"] as OAuthLib.OAuthSettings);
                var requestData = requestBase.RequestData;
                var parameters = oauthHelper.GetOAuthBasicParams();
                //parameters.Add(Constants.OAuthToken, oauthHelper.AccessToken.Token);
                parameters.Add(Constants.OAuthToken, context["AccessToken"] as string);
                var excludedKeys = new string[] { };

                excludedKeys = requestData.PostFieldValues.Select(kv => kv.Key).ToArray();
                foreach (var kv in requestData.PostFieldValues)
                    parameters.Add(kv.Key, kv.Value.FirstOrDefault());

                //var queryValues = oauthHelper.ConstructOAuthQueryValues(parameters, requestBase.RequestMethod, baseUrl, oauthHelper.AccessToken.Secret);
                var queryValues = oauthHelper.ConstructOAuthQueryValues(parameters, requestBase.RequestMethod, baseUrl, context["AccessTokenSecret"] as string);
                requestBase.RequestData.QueryStringValues.Clear();
                queryValues.ForEach(kv => requestBase.RequestData.QueryStringValues.Add(kv.Key, new List<string> { kv.Value }));
            };

            Action<IDictionary<string, object>, WebRequest, RequestBase> authorizeByHeader = (context, webrqst, requestBase) =>
            {
                var oauthHelper = new OAuthLib.OAuthHelper(context["OAuthSettings"] as OAuthLib.OAuthSettings);
                var requestData = requestBase.RequestData;
                var parameters = oauthHelper.GetOAuthBasicParams();
                //parameters.Add(Constants.OAuthToken, oauthHelper.AccessToken.Token);
                parameters.Add(Constants.OAuthToken, context["AccessToken"] as string);

                var excludedKeys = new string[] { };
                var baseUrl = webrqst.RequestUri.ToString();

                if (webrqst.Method == "GET" || webrqst.Method == "DELETE")
                {
                    if (!string.IsNullOrEmpty(webrqst.RequestUri.Query))
                    {
                        excludedKeys = requestData.QueryStringValues.Select(kv => kv.Key).ToArray();
                        foreach (var kv in requestData.QueryStringValues)
                            parameters.Add(kv.Key, kv.Value.FirstOrDefault());
                        baseUrl = baseUrl.Substring(0, baseUrl.IndexOf('?'));
                    }
                }
                else if (webrqst.Method == "POST")
                {
                    excludedKeys = requestData.PostFieldValues.Select(kv => kv.Key).ToArray();
                    foreach (var kv in requestData.PostFieldValues)
                        parameters.Add(kv.Key, kv.Value.FirstOrDefault());
                }


                //var oauth = oauthHelper.ConstructOAuthHeader(parameters, webrqst.Method, baseUrl, oauthHelper.AccessToken.Secret, excludedKeys);
                var oauth = oauthHelper.ConstructOAuthHeader(parameters, webrqst.Method, baseUrl, context["AccessTokenSecret"] as string, excludedKeys);

                webrqst.Headers[HttpRequestHeader.Authorization] = oauth;
                //oauthHelper.AppendOAuthHeader(webrqst);
            };

#if SILVERLIGHT_4||SILVERLIGHT_5||WINDOWS_PHONE_7||WINDOWS_PHONE_8
            var token = new DelegateAuthToken(null, authorizeByQuery);
#else
            var token = new DelegateAuthToken(authorizeByHeader, null);
#endif
            var settings = new OAuthLib.OAuthSettings
            {
                AppKey = this.AppKey,
                AccessTokenUrl = this.AccessTokenUrl,
                AuthorizeUrl = this.AuthorizeUrl,
                AppSecret = this.AppSecret,
                RequestTokenUrl = this.RequestTokenUrl
            };

            var helper = new OAuthLib.OAuthHelper(settings);
            cancelToken.ThrowIfCancellationRequested();
            var accessToken = await helper.LoginAsync(UserName, Password,cancelToken);

            token.ContextData["UserID"] = accessToken.UserID;
            token.ContextData["AccessToken"] = accessToken.Token;
            token.ContextData["AccessTokenSecret"] = accessToken.Secret;
            token.ContextData["OAuthSettings"] = settings;

            return token;
        }
    }
}
