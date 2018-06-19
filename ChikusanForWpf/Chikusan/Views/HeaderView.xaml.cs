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
    /// HeaderView.xaml の相互作用ロジック
    /// </summary>
    public partial class HeaderView : UserControl
    {
        public HeaderView()
        {
            //デザイナモード判別
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var windowTitles = Application
                            .Current
                            .Windows
                            .Cast<Window>()
                            .Aggregate(
                                new StringBuilder(),
                                (sb, w) => sb.AppendLine(w.Title))
                            .ToString();
            //画面表示チェック
            if (windowTitles.IndexOf("AN00001") >= 0)
            {
                var existWindow = (Window)Application.Current.Windows.Cast<Window>().Where(x => x.Title.Contains("AN00001")).ToArray()[0];
                existWindow.Activate();
                return;
            }
            var menuPage = new MenuView();
            menuPage.Show();
        }
    }
}
