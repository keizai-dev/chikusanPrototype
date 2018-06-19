using JaGunma.Chikusan.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JaGunma.Chikusan.Views
{
    /// <summary>
    /// AN22021View.xaml の相互作用ロジック
    /// </summary>
    public partial class AN22021View : UserControl
    {
        public AN22021View()
        {

            InitializeComponent();
        }

        /// <summary>
        /// 画面読込後イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // Todo:初期化時に初期フォーカスがうまくセットできないため、読込後に設定する
            HimmeiCodeTextBox.Focus();

        }

        /// <summary>
        /// 品名コード開始押下イベント
        /// </summary>
        /// <remarks>
        /// フォーカス系はコードビハインド行きか
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HimmeiCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DantaiCodeTextBox.Focus();
            }
        }

        /// 団体コード押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DantaiCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DantaiNameTextBox.Focus();
            }
        }

        /// <summary>
        /// 団体名押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DantaiNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if(EntryButton.Visibility == Visibility.Visible)
                {
                    EntryButton.Focus();
                }
                if (EntryButton.Visibility == Visibility.Hidden)
                {
                    UpdateButton.Focus();
                }
            }
        }

    }
}
