using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinaWeiboClientV2;
using SinaWeiboClientV2.StatusesFriendsTimeline;

namespace SinaWeibo_Win8AppStore.ViewModel
{
    public class FriendTimelineViewModel : SinaWeibo_Win8AppStore.Common.BindableBase
    {
        private const string AppKey = "967389259";
        private const string AppSecret = "001379b11292669a5399131cfc5b806d";
        private const string UserId = "jdcbtest@sina.com";
        private const string Password = "jdcbtest";

        public WeiboClientV2 Weibo { get; set; }

        private ObservableCollection<StatusesArrayItem> _statusFriendsTimeline 
            = new ObservableCollection<StatusesArrayItem>();

        private string _maxId = "";
        private string _minId = "";
        private bool _isLoading = false;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                this.SetProperty(ref _isLoading, value, "IsLoading");
            }
        }

        public ObservableCollection<StatusesArrayItem> StatusFriendsTimeline
        {
            get { return _statusFriendsTimeline; }
        }

        public async Task LoadAsync()
        {
            try
            {
                IsLoading = true;
                //Weibo.CurrentAuthToken = await TokenHelper2.CreateOAuthTokenAsync(AppKey, AppSecret, UserId, Password, System.Threading.CancellationToken.None);
                var request = new Request
                {
                    Page = "1",
                    SinceId = string.IsNullOrEmpty(_maxId) ? "0" : _maxId
                };
                var response = await Weibo.ExecuteStatusesFriendsTimelineAsync(request);
                if (string.IsNullOrEmpty(_maxId))
                {
                    foreach (var item in response.Value.Statuses)
                    {
                        _statusFriendsTimeline.Add(item);
                    }
                }
                else
                {
                    foreach (var item in response.Value.Statuses)
                    {
                        _statusFriendsTimeline.Insert(0, item);
                    }
                }
                _maxId = _statusFriendsTimeline.First().Idstr;
                if (string.IsNullOrEmpty(_minId))
                {
                    _minId = _statusFriendsTimeline.Last().Idstr;
                }
            }
            finally
            {
                IsLoading = false;
            }
        }

        public async Task LoadHistoryAsync()
        {
            try
            {
                IsLoading = true;
                var request = new Request
                {
                    Page = "1",
                    MaxId = string.IsNullOrEmpty(_minId) ? "0" : _minId
                };
                var response = await Weibo.ExecuteStatusesFriendsTimelineAsync(request);
                foreach (var item in response.Value.Statuses)
                {
                    if (item.Idstr != _minId)
                    {
                        _statusFriendsTimeline.Add(item);
                    }
                }
                _minId = _statusFriendsTimeline.Last().Idstr;
            }
            finally
            {
                IsLoading = false;
            }
        }

        public FriendTimelineViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                _statusFriendsTimeline.Add(
                    new StatusesArrayItem
                    {
                        Id = 1,
                        Text = "status 1 ...",
                        CreatedAt = "Mon Dec 17 00:35:02 +0800 2012",
                        RetweetedStatus = new RetweetedStatus
                        {
                            User = new User
                            {
                                ScreenName = "sub_user1",
                                ProfileImageUrl = "http://tp1.sinaimg.cn/1642634100/180/5613120647/0"
                            },
                            Text = "Retweeted status.",
                            ThumbnailPic = "http://tp1.sinaimg.cn/1642634100/180/5613120647/0"
                        },
                        User = new User
                        {
                            ScreenName = "user1",
                            ProfileImageUrl = "http://tp1.sinaimg.cn/1642634100/180/5613120647/0"
                        },
                        RepostsCount = 100,
                        CommentsCount = 232
                    });
                _statusFriendsTimeline.Add(
                   new StatusesArrayItem
                   {
                       Id = 2,
                       Text = "status 2 ...",
                       User = new User
                       {
                           ScreenName = "user2",
                           ProfileImageUrl = "http://tp1.sinaimg.cn/1642634100/180/5613120647/0"
                       },
                       ThumbnailPic = "http://tp1.sinaimg.cn/1642634100/180/5613120647/0"
                   });
                _statusFriendsTimeline.Add(
                  new StatusesArrayItem
                  {
                      Id = 3,
                      Text = "status 3 ...",
                      User = new User
                      {
                          ScreenName = "user3",
                          ProfileImageUrl = "http://tp1.sinaimg.cn/1642634100/180/5613120647/0"
                      },
                      ThumbnailPic = "http://tp1.sinaimg.cn/1642634100/180/5613120647/0"
                  });
            }
        }
    }
}
