using JaGunma.Chikusan.DataModels;
using JaGunma.Chikusan.Message;
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
    public partial class HimmeiSearchDialog: Window
    {
        public HimmeiSearchDialog()
        {
            InitializeComponent();
        }
        public HimmeiSearchResult ShowDialog(HimmeiSearchParameter parameter)
        {

            HimmeiCodeStartTextBox.Text = parameter.HimmeiCodeStart;
            HimmeiCodeEndTextBox.Text = parameter.HimmeiCodeEnd;
            HimmeiTextBox.Text = parameter.Himmei;
            HimmeiDataGrid.ItemsSource = HimmeiDto.GetTestData();
            base.ShowDialog();

            var selected = HimmeiDataGrid.SelectedItem as HimmeiDto;
            var result = new HimmeiSearchResult();
            if (selected == null) return result;
            result.HimmeiCode = selected.HimmeiCode;
            result.Himmei = selected.Himmei;

            return result;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
