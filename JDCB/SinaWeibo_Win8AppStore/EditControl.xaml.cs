using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// “用户控件”项模板在 http://go.microsoft.com/fwlink/?LinkId=234236 上提供

namespace SinaWeibo_Win8AppStore
{
    public sealed partial class EditControl : UserControl
    {
        public EditControl()
        {
            this.InitializeComponent();
        }

        public SinaWeiboClientV2.WeiboClientV2 Weibo { get; set; }
        public StorageFile ImageFile { get; set; }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string error = "";
            this.IsEnabled = false;
            try
            {
                if (!string.IsNullOrEmpty(this.InputArea.Text))
                {
                    if (ImageFile != null)
                    {
                        var fileInfo = new RestAPICore.FileUploadInfo();
                        fileInfo.LocalPath = ImageFile.Name;
                        fileInfo.StreamFactory = GetImageFile(ImageFile);
                        var request = new SinaWeiboClientV2.StatusesUpload.Request
                        {
                            Status = this.InputArea.Text,
                            Pic = fileInfo
                        };
                        var response = await Weibo.ExecuteStatusesUploadAsync(request);
                    }
                    else
                    {
                        var request = new SinaWeiboClientV2.StatusesUpdate.Request { Status = this.InputArea.Text };
                        var response = await Weibo.ExecuteStatusesUpdateAsync(request);
                    }
                }
                if (this.Parent is Popup)
                {
                    ((Popup)this.Parent).IsOpen = false;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            this.IsEnabled = true;
            if (!string.IsNullOrEmpty(error))
            {
                var md = new MessageDialog(error);
                await md.ShowAsync();
            }
        }

        private async Task<Stream> GetImageFile(StorageFile file)
        {
            var s = await file.OpenAsync(FileAccessMode.Read);
            return s.AsStream();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.InputArea.Text = "";
            this.imageUpload.Source = null;
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FileOpenPicker open = new FileOpenPicker();
            open.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            open.ViewMode = PickerViewMode.Thumbnail;

            // Filter to include a sample subset of file types
            open.FileTypeFilter.Clear();
            open.FileTypeFilter.Add(".bmp");
            open.FileTypeFilter.Add(".png");
            open.FileTypeFilter.Add(".jpeg");
            open.FileTypeFilter.Add(".jpg");

            // Open a stream for the selected file
            ImageFile = await open.PickSingleFileAsync();
            // Ensure a file was selected
            if (ImageFile != null)
            {
                // Ensure the stream is disposed once the image is loaded
                using (IRandomAccessStream fileStream = await ImageFile.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    // Set the image source to the selected bitmap
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.DecodePixelHeight = 80;
                    bitmapImage.DecodePixelWidth = 80;

                    await bitmapImage.SetSourceAsync(fileStream);
                    imageUpload.Source = bitmapImage;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Parent != null && Parent is Popup)
            {
                var popUp = (Popup)this.Parent;
                popUp.IsOpen = false;
            }
        }
    }
}
