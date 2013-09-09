using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestAPICore;
using OAuthLib;
using System.Threading.Tasks;
using System.Threading;

namespace SinaWeiboClientV2
{
    public partial class TokenHelper2
    {
        public static GrantType GrantType { get; set; }

        public static OAuthLib.OAuthSettings OAuthSettings { get; private set; }
        public static OAuthLib.OAuthHelper OAuthHelper { get; private set; }
        
        public static AuthToken CreateOAuthToken(string appKey, string appSecret, string userName, string password)
        {
            return CreateOAuthTokenAsync(appKey, appSecret, userName, password, CancellationToken.None).Result;
        }

        public static async Task<AuthToken> CreateOAuthTokenAsync(string appKey, string appSecret, string userName, string password, CancellationToken cancelToken)
        {
            var authorizeUrl = "https://api.weibo.com/oauth2/authorize"; //<--these should get from resource
            var accessTokenUrl = "https://api.weibo.com/oauth2/access_token"; //<--these should get from resource
            var callbackUrl = "https://api.weibo.com/oauth2/default.html";

            IAuthTokenFactory oAuthTokenFactory = new JDCBOAuth2TokenFactory   //<--this part could use ioc 
            {
                OAuthSettings = new OAuthSettings {
                  AuthorizeUrl = authorizeUrl,
                  AccessTokenUrl = accessTokenUrl,
                  CallbackUrl = callbackUrl,
                  AppKey = appKey,
                  AppSecret = appSecret
                },
                Passport = userName,
                Password = password,
                GrantType = OAuthLib.GrantType.Password
            };
            return await oAuthTokenFactory.CreateTokenAsync(cancelToken);
        }

        public static async Task<AuthToken> CreateOAuthTokenAsync(string appKey, string appSecret, string code, CancellationToken cancelToken)
        {
            var authorizeUrl = "https://api.weibo.com/oauth2/authorize"; //<--these should get from resource
            var accessTokenUrl = "https://api.weibo.com/oauth2/access_token"; //<--these should get from resource
            var callbackUrl = "https://api.weibo.com/oauth2/default.html";

            IAuthTokenFactory oAuthTokenFactory = new JDCBOAuth2TokenFactory   //<--this part could use ioc 
            {
                OAuthSettings = new OAuthSettings
                {
                    AuthorizeUrl = authorizeUrl,
                    AccessTokenUrl = accessTokenUrl,
                    CallbackUrl = callbackUrl,
                    AppKey = appKey,
                    AppSecret = appSecret
                },
                AuthorizationCode = code,
                GrantType = OAuthLib.GrantType.AuthorizationCode
            };
            return await oAuthTokenFactory.CreateTokenAsync(cancelToken);
        }

    }
}
