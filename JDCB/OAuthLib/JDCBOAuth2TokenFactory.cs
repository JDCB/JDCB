using RestAPICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuthLib
{
    public class JDCBOAuth2TokenFactory : IAuthTokenFactory
    {
        public OAuthSettings OAuthSettings { get; set; }
        public string Passport { get; set; }
        public string Password { get; set; }
        public string AuthorizationCode { get; set; }
        public OAuthAccessToken AccessToken { get; set; }
        public GrantType GrantType { get; set; }

        public JDCBOAuth2TokenFactory()
        {
            GrantType = OAuthLib.GrantType.AuthorizationCode;
        }

        public AuthToken CreateToken()
        {
            return CreateTokenAsync(System.Threading.CancellationToken.None).Result;
        }

        public async Task<AuthToken> CreateTokenAsync(System.Threading.CancellationToken cancelToken)
        {
            Action<IDictionary<string, object>, string, RequestBase> authorizeByQuery = (context, baseUrl, requestBase) =>
            {
                requestBase.RequestData.QueryStringValues.Add("access_token",
                    new List<string> { (context["AccessToken"] as OAuthAccessToken).Token });
            };

            var token = new DelegateAuthToken(null, authorizeByQuery);

            if (AccessToken == null)
            {
                AccessToken = await GetOAuthAccessTokenAsync(cancelToken);
            }
            token.ContextData["UserID"] = AccessToken.UserID;
            token.ContextData["AccessToken"] = AccessToken;

            return token;
        }

        public async Task<OAuthAccessToken> GetOAuthAccessTokenAsync(System.Threading.CancellationToken cancelToken)
        {
            var helper = new OAuth2Helper(OAuthSettings);
            OAuthAccessToken accessToken = null;
            switch (GrantType)
            {
                case GrantType.AuthorizationCode:
                    accessToken = await helper.GetAccessTokenByCodeAsync(AuthorizationCode);
                    break;
                case GrantType.Password:
                    accessToken = await helper.GetAccessTokenByPasswordAsync(Passport, Password);
                    break;
                default:
                    accessToken = await helper.LoginAsync(Passport, Password, cancelToken);
                    break;
            }
            return accessToken;
        }
    }
}
