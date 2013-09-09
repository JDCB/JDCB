using SinaWeiboClientV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinaWeiboClientV2.UsersShow;

namespace SinaWeibo_Win8AppStore.ViewModel
{
    public class UserViewModel : SinaWeibo_Win8AppStore.Common.BindableBase
    {
        public WeiboClientV2 Weibo { get; set; }

        private Response _userProfile;
        public Response UserProfile
        {
            get 
            { 
                return _userProfile; 
            }
            set 
            {
                this.SetProperty(ref _userProfile, value, "UserProfile");
            }
        }

        public async Task LoadAsync()
        {
            var request = new Request { Uid = Weibo.CurrentAuthToken.ContextData["UserID"] as string };
            var response = await Weibo.ExecuteUsersShowAsync(request);
            UserProfile.ScreenName = response.Value.ScreenName;
            UserProfile.ProfileImageUrl = response.Value.ProfileImageUrl;
            UserProfile.FollowersCount = response.Value.FollowersCount;
            UserProfile.FriendsCount = response.Value.FriendsCount;
            UserProfile.StatusesCount = response.Value.StatusesCount;
        }

        public UserViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                this._userProfile = new Response
                {
                    ScreenName = "ScreenName",
                    FollowersCount = 133,
                    FriendsCount = 512,
                    StatusesCount = 1015
                };
            }
            _userProfile = new Response();
        }
    }
}
