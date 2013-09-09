using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestAPICore;
using OAuthLib;
using System.Threading.Tasks;
using System.Threading;

namespace SinaWeiboClientV1
{
    public partial class TokenHelper
    {
        public static AuthToken CreateOAuthToken(string appKey, string appSecret, string userName, string password)
        {
            return CreateOAuthTokenAsync(appKey, appSecret, userName, password,CancellationToken.None).Result;
        }

        public static async Task<AuthToken> CreateOAuthTokenAsync(string appKey, string appSecret, string userName, string password, CancellationToken cancelToken)
        {
            

            var RequestTokenUrl = "http://api.t.sina.com.cn/oauth/request_token"; //<--these should get from resource
            var AuthorizeUrl = "http://api.t.sina.com.cn/oauth/authorize"; //<--these should get from resource
            var AccessTokenUrl = "http://api.t.sina.com.cn/oauth/access_token"; //<--these should get from resource

            IAuthTokenFactory oAuthTokenFactory = new JDCBOAuthTokenFactory   //<--this part could use ioc 
            {
                AppKey = appKey,
                AppSecret = appSecret,
                RequestTokenUrl = RequestTokenUrl,
                AuthorizeUrl = AuthorizeUrl,
                AccessTokenUrl = AccessTokenUrl,
                UserName = userName,
                Password = password
            };
            return await oAuthTokenFactory.CreateTokenAsync(cancelToken);
        }
    }
}
