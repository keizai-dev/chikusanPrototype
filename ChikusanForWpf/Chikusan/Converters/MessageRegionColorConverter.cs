using JaGunma.Chikusan.Message;
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
    /// <summary>
    /// メッセージ領域用コンバーター
    /// </summary>
    public class MessageRegionColorConverter : MarkupExtension, IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var normalColor = (SolidColorBrush)System.Windows.Application.Current.Resources["PrimaryBrush"];
            var errorColor = (SolidColorBrush)System.Windows.Application.Current.Resources["ErrorBrush"];
             var warningColor = (SolidColorBrush)System.Windows.Application.Current.Resources["WarningBrush"];
            var successColor = (SolidColorBrush)System.Windows.Application.Current.Resources["SuccessBrush"];

            var checkResult = (CheckResult)value ?? new CheckResult();
            if (checkResult.IsNoneType() || checkResult.IsInfoType()){ return normalColor;}
            else if(checkResult.IsSuccessType()){ return successColor;}
            else if (checkResult.isWarningType()){ return warningColor;}
            else if (checkResult.isErrorType()){ return errorColor;}

                return normalColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
