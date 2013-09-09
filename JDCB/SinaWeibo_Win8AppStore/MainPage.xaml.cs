//using SinaWeibo_Win8AppStore.Data;
using SinaWeibo_Win8AppStore.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SinaWeibo_Win8AppStore.Common;
using Windows.UI;

// “分组项页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234231 上提供

namespace SinaWeibo_Win8AppStore
{
    /// <summary>
    /// 显示分组的项集合的页。
    /// </summary>
    public sealed partial class MainPage : SinaWeibo_Win8AppStore.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
        
        }

        /// <summary>
        /// 使用在导航过程中传递的内容填充页。在从以前的会话
        /// 重新创建页时，也会提供任何已保存状态。
        /// </summary>
        /// <param name="navigationParameter">最初请求此页时传递给
        /// <see cref="Frame.Navigate(Type, Object)"/> 的参数值。
        /// </param>
        /// <param name="pageState">此页在以前会话期间保留的状态
        /// 字典。首次访问页面时为 null。</param>
        protected override async void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            var weibo = (SinaWeiboClientV2.WeiboClientV2)navigationParameter;
            var friendTimelineVM = new FriendTimelineViewModel();
            this.DefaultViewModel["FriendsTimeline"] = friendTimelineVM;
            friendTimelineVM.Weibo = weibo;
            await friendTimelineVM.LoadAsync();

            var userProfileVM = new UserViewModel();
            this.DefaultViewModel["UserProfile"] = userProfileVM.UserProfile;
            userProfileVM.Weibo = weibo;
            await userProfileVM.LoadAsync();

            this.DefaultViewModel["weibo"] = weibo;
        }

        /// <summary>
        /// 在单击组标题时进行调用。
        /// </summary>
        /// <param name="sender">用作选定组的组标题的 Button。</param>
        /// <param name="e">描述如何启动单击的事件数据。</param>
        void Header_Click(object sender, RoutedEventArgs e)
        {
            // 确定 Button 实例表示的组
            //var group = (sender as FrameworkElement).DataContext;

            // 导航至相应的目标页，并
            // 通过将所需信息作为导航参数传入来配置新页
            //this.Frame.Navigate(typeof(GroupDetailPage), ((SampleDataGroup)group).UniqueId);
        }

        /// <summary>
        /// 在单击组内的项时进行调用。
        /// </summary>
        /// <param name="sender">显示所单击项的 GridView (在应用程序处于对齐状态时
        /// 为 ListView)。</param>
        /// <param name="e">描述所单击项的事件数据。</param>
        void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 导航至相应的目标页，并
            // 通过将所需信息作为导航参数传入来配置新页
            //var itemId = ((SampleDataItem)e.ClickedItem).UniqueId;
            //this.Frame.Navigate(typeof(ItemDetailPage), itemId);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationData.Current.LocalSettings.Values["AccessToken"] = null;
            base.GoBack(sender, e);
        }

        protected override void GoBack(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationData.Current.LocalSettings.Values["AccessToken"] = null;
            base.GoBack(sender, e);
        }

        async void scrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            var sv = (ScrollViewer)sender;
            var horizontalOffset = sv.HorizontalOffset;
            var maxHorizontalOffset = sv.ExtentWidth - sv.ViewportWidth;
            var friendTimelineVM = (FriendTimelineViewModel)this.DefaultViewModel["FriendsTimeline"];

            if (horizontalOffset <= 0)
            {
                //StatusList.Background = new SolidColorBrush(Colors.Green);
                await friendTimelineVM.LoadAsync();
            } 
            else if (horizontalOffset >= maxHorizontalOffset) 
            {

                //StatusList.Background = new SolidColorBrush(Colors.Yellow);
                await friendTimelineVM.LoadHistoryAsync();
            }
            else
            {
                //StatusList.Background = new SolidColorBrush(Colors.Gray);
            }
        }

        
        private void pageRoot_Loaded_1(object sender, RoutedEventArgs e)
        {
            var scrollViewer = this.StatusList.GetFirstDescendantOfType<ScrollViewer>();
            scrollViewer.ViewChanged += scrollViewer_ViewChanged;
            this.NewStatusPopup.Closed += NewStatusPopup_Closed;
        }

        async void NewStatusPopup_Closed(object sender, object e)
        {
            var friendTimelineVM = (FriendTimelineViewModel)this.DefaultViewModel["FriendsTimeline"];
            await friendTimelineVM.LoadAsync();
            this.StatusList.IsEnabled = true;
        }

        private void ShowNewStatusPopup_Click(object sender, RoutedEventArgs e)
        {
            if (!this.NewStatusPopup.IsOpen)
            {
                NewStatusPopup.VerticalOffset = (Window.Current.Bounds.Height - 300) / 2;
                NewStatusPopup.HorizontalOffset = (Window.Current.Bounds.Width - 600) / 2;
                var editControl = NewStatusPopup.Child as EditControl;
                editControl.Weibo = this.DefaultViewModel["weibo"] as SinaWeiboClientV2.WeiboClientV2;
                NewStatusPopup.IsOpen = true;
                this.StatusList.IsEnabled = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (NewStatusPopup.IsOpen) { NewStatusPopup.IsOpen = false; }
        }
       
    }
}
