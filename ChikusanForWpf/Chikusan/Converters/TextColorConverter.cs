using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace JaGunma.Chikusan.Converters
{
    public class TextColorConverter : MarkupExtension, IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
             var errorColor = (SolidColorBrush)System.Windows.Application.Current.Resources["ErrorBrush"];
             var whiteColor = (SolidColorBrush)System.Windows.Application.Current.Resources["WhiteBrush"]; 
            return ((bool?)value == true) ? errorColor : whiteColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // ここに処理を書く
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
