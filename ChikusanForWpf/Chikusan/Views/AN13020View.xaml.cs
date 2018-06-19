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
    public partial class AN13020View : UserControl
    {
        public AN13020View()
        {

            InitializeComponent();
            //this.DataContext = new AN22020ViewModel(this.Navigation);
            //this.Title = this.Title += "　AN22020　団体一覧";
        }

        /// <summary>
        /// 画面読込後イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
