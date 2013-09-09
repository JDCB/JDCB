using Newtonsoft.Json;
using OAuthLib;
using SinaWeiboClientV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinaWeibo_Win8AppStore.ViewModel
{
    public class LoginViewModel : SinaWeibo_Win8AppStore.Common.BindableBase
    {
        private const string AppKey = "967389259";
        private const string AppSecret = "001379b11292669a5399131cfc5b806d";
        private const string Callback = "http://JDCB.com";

        public async Task<WeiboClientV2> LoginAsync()
        {
            var weibo = new SinaWeiboClientV2.WeiboClientV2();
            weibo.Initialize(AppKey, AppSecret, Callback);

            var localValues = Windows.Storage.ApplicationData.Current.LocalSettings.Values;
            var json = localValues["AccessToken"] as string;
            if (!string.IsNullOrEmpty(json)) 
            {
                weibo.AccessToken = await JsonConvert.DeserializeObjectAsync<OAuthAccessToken>(json);
            }
            
            if (weibo.AccessToken == null)
            {
                // 认证
                await weibo.AuthenticateAsync();
            }
            // 授权
            await weibo.AuthorizeAccessAsync(System.Threading.CancellationToken.None);
            localValues["AccessToken"] = 
                await JsonConvert.SerializeObjectAsync(weibo.CurrentAuthToken.ContextData["AccessToken"]);

            return weibo;
        }
    }
}
