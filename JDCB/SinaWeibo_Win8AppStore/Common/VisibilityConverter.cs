using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace SinaWeibo_Win8AppStore.Common
{
    public class VisibilityConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return "Collapsed";

            if (value.GetType() == typeof(string))
                return string.IsNullOrEmpty(value as string) ? "Collapsed" : "Visible";

            if (value.GetType() == typeof(bool))
                return (bool)value ? "Visible" : "Collapsed";
            
            return "Visible";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
