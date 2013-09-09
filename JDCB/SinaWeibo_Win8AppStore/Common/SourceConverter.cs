using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace SinaWeibo_Win8AppStore.Common
{
    public class SourceConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var src = value as string;
            var regex = new Regex(@"(?is)(?<=<a[^>]*>)([^<]*)(?=</a>)");
            return regex.Match(src).Groups[0].Value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
