using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAuthLib;
using RestAPICore;
using System.Threading;
using Windows.Security.Authentication.Web;

namespace SinaWeiboClientV2
{
    public partial class WeiboClientV2 : JsonClientBase
    {
        public OAuthSettings OAuthSettings { get; private set; }
        public string AuthorizationCode { get; set; }
        public OAuthAccessToken AccessToken { get; set; }

        public void Initialize(string appKey, string appSecret, string callbackUrl = null)
        {
            OAuthSettings = new OAuthSettings();
            OAuthSettings.AuthorizeUrl = "https://api.weibo.com/oauth2/authorize";
            OAuthSettings.AccessTokenUrl = "https://api.weibo.com/oauth2/access_token";
            OAuthSettings.CallbackUrl = string.IsNullOrEmpty(callbackUrl) ? "https://api.weibo.com/oauth2/default.html" : callbackUrl;
            OAuthSettings.AppKey = appKey;
            OAuthSettings.AppSecret = appSecret;
        }

        public async Task AuthenticateAsync()
        {
            var oauthHelper = new OAuth2Helper(OAuthSettings);
            var startUri = new Uri(oauthHelper.GetAuthorizeUrl());
            var endUri = new Uri(OAuthSettings.CallbackUrl);

            var webAuthenticationResult = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, startUri, endUri);
            
            
            if (webAuthenticationResult.ResponseStatus == WebAuthenticationStatus.Success)
            {
                var result = webAuthenticationResult.ResponseData.ToString();
                var code = oauthHelper.GetCodeFromCallback(result);
                AuthorizationCode = code;
            }
            else if (webAuthenticationResult.ResponseStatus == WebAuthenticationStatus.ErrorHttp)
            {
                throw new Exception("HTTP Error returned by AuthenticateAsync.");
                //OutputToken("HTTP Error returned by AuthenticateAsync() : " + WebAuthenticationResult.ResponseErrorDetail.ToString());
            }
            else
            {
                throw new Exception("Error returned by AuthenticateAsync.");
                //OutputToken("Error returned by AuthenticateAsync() : " + WebAuthenticationResult.ResponseStatus.ToString());
            }
        }

        public async Task AuthorizeAccessAsync(CancellationToken cancelToken)
        {
            IAuthTokenFactory oAuthTokenFactory = new JDCBOAuth2TokenFactory   //<--this part could use ioc 
            {
                OAuthSettings = OAuthSettings,
                AuthorizationCode = AuthorizationCode,
                AccessToken = AccessToken,
                GrantType = OAuthLib.GrantType.AuthorizationCode
            };
            this.CurrentAuthToken = await oAuthTokenFactory.CreateTokenAsync(cancelToken);
        }
    }
}
