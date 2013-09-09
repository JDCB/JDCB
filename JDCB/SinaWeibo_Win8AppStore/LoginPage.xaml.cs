using SinaWeibo_Win8AppStore.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Credentials.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace SinaWeibo_Win8AppStore
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            
            /*
            var proxy = WebRequest.DefaultWebProxy.GetProxy(new Uri(weibo.OAuthSettings.AuthorizeUrl));
            CredentialPickerOptions credPickerOptions = new CredentialPickerOptions();
            credPickerOptions.TargetName = WebRequest.DefaultWebProxy.GetProxy(new Uri(weibo.OAuthSettings.AuthorizeUrl)).DnsSafeHost;
            credPickerOptions.Message = "Proxy Authentication required for: " + credPickerOptions.TargetName;
            credPickerOptions.Caption = "Please enter your Proxy credentials";
            credPickerOptions.CallerSavesCredential = false;
            credPickerOptions.CredentialSaveOption = CredentialSaveOption.Hidden;
            credPickerOptions.AuthenticationProtocol = AuthenticationProtocol.Digest;
            CredentialPickerResults credPickerResults = await CredentialPicker.PickAsync(credPickerOptions);
            WebRequest.DefaultWebProxy.Credentials = new NetworkCredential(credPickerResults.CredentialUserName, credPickerResults.CredentialPassword);
            */

            var error = "";
            try
            {
                var loginVM = new LoginViewModel();
                var weibo = await loginVM.LoginAsync();
                this.Frame.Navigate(typeof(MainPage), weibo);
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            if (!string.IsNullOrEmpty(error))
            {
                var md = new MessageDialog(error);
                await md.ShowAsync();
            }           
        }

        private AuthenticationProtocol GetAuthEnum(string theVal)
        {
            AuthenticationProtocol returnVal = AuthenticationProtocol.Basic;

            switch (theVal.ToLower())
            {
                case "basic":
                    {
                        returnVal = AuthenticationProtocol.Basic;
                        break;
                    };
                case "digest":
                    {
                        returnVal = AuthenticationProtocol.Digest;
                        break;
                    };
                case "negotiate":
                    {
                        returnVal = AuthenticationProtocol.Negotiate;
                        break;
                    };
                case "ntlm":
                    {
                        returnVal = AuthenticationProtocol.Ntlm;
                        break;
                    };
                case "kerberos":
                    {
                        returnVal = AuthenticationProtocol.Kerberos;
                        break;
                    };
            };

            return returnVal;
        }
    }
}
