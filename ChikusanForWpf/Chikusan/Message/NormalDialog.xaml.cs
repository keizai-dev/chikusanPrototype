using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JaGunma.Chikusan.Message
{
    /// <summary>
    /// DialogWindow.xaml の相互作用ロジック
    /// </summary>
    /// <remarks>
    /// DialogWindowのみコードビハンドフル活用
    /// 手抜きではなくViewmodelを作る必要がないからです
    /// </remarks>
    public partial class NormalDialog : Window
    {

        private DialogResult _messageResult = new DialogResult();

        public NormalDialog()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(DialogParameter parameter)
        {
            SetButtons(parameter);
            SetIcon(parameter);
            MessageText.Text = parameter.Message;
            base.ShowDialog();
            //return new MessageResult(true, this.MessageText.Text);
            return _messageResult;
        }

        private void YesButtonClick(object sender, RoutedEventArgs e)
        {
            _messageResult.Result = true;
            base.Close();
        }

        private void NoButtonClick(object sender, RoutedEventArgs e)
        {
            _messageResult.Result = false;
            base.Close();
        }

        private void SetButtons(DialogParameter parameter)
        {
            if (parameter.IsYesOnly())
            {
                YesOnlyRegion.Visibility = Visibility.Visible;
            }
            else if (parameter.IsYesNo())
            {
                YesNoRegion.Visibility = Visibility.Visible;
            }
            else if (parameter.IsNoYes())
            {
                NoYesRegion.Visibility = Visibility.Visible;
            }
        }

        private void SetIcon(DialogParameter parameter)
        {
            if (parameter.IsInfoIcon())
            {
                InfoIcon.Visibility = Visibility.Visible;
            }
            else if (parameter.IsQuestionIcon())
            {
                QuestionIcon.Visibility = Visibility.Visible;
            }
            else if (parameter.IsWaningIcon())
            {
                WarningIcon.Visibility = Visibility.Visible;
            }
            else if (parameter.IsErrorIcon())
            {
                ErrorIcon.Visibility = Visibility.Visible;
            }
        }

    }
}
