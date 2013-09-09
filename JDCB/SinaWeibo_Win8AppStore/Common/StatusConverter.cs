using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;

namespace SinaWeibo_Win8AppStore.Common
{
    public class StatusConverter
    {
        public static string GetStatus(DependencyObject obj)
        {
            return (string)obj.GetValue(StatusProperty);
        }

        public static void SetStatus(DependencyObject obj, string value)
        {
            obj.SetValue(StatusProperty, value);
        }

        // Using a DependencyProperty as the backing store for Html.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StatusProperty =
            DependencyProperty.RegisterAttached("Status", typeof(string), typeof(StatusConverter), new PropertyMetadata("", OnStatusChanged));

        private static readonly SolidColorBrush AtPatternColorBrush = new SolidColorBrush(Windows.UI.Colors.Blue);

        private static void OnStatusChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var parent = (RichTextBlock)sender;
            parent.Blocks.Clear();

            var atSomeonePattern = new Regex(@"(?<someone>\@[^#\@\s\b\n\r\0:,.;!?'""。，：；！？”“‘’]+)");
            var text = e.NewValue as string;
            var ms = atSomeonePattern.Matches(text);

            int nextOffset = 0;
            var paragraph = new Paragraph();
            parent.Blocks.Add(paragraph);

            foreach (Match m in ms)
            {
                paragraph.Inlines.Add(new Run { Text = text.Substring(nextOffset, m.Index - nextOffset) });
                paragraph.Inlines.Add(new Run { Text = m.Groups["someone"].Value, Foreground = AtPatternColorBrush });
                nextOffset = m.Index + m.Length;
            }

            if (nextOffset == 0)
            {
                paragraph.Inlines.Add(new Run { Text = text });
            }
        }

    }
}
