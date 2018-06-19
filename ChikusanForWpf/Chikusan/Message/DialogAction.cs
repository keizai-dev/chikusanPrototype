using JaGunma.Chikusan.Views;
using Microsoft.Win32;
using System.Windows;

namespace JaGunma.Chikusan.Message
{
    /// <summary>
    /// ダイアログを表示するトリガーアクション
    /// </summary>
    public class DialogAction : DialogMessenger.Action
    {
        /// <summary>
        /// メッセージボックス表示
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        protected override DialogResult Show(DialogParameter parameter)
        {
            //protected override MessageBoxResult ShowMessage(
            //    string text,
            //    string title,
            //    MessageBoxButton button,
            //    MessageBoxImage icon)
            //{
            var newDialog = new NormalDialog();
            return newDialog.ShowDialog(parameter);
            //return System.Windows.MessageBox.Show(
            //    Window.GetWindow(AssociatedObject), text,
            //    (title != null ? title :
            //        Application.Current.MainWindow.Title),
            //    button, icon);
        }

        /// <summary>
        /// ファイル保存ダイアログ表示
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        protected override FileSaveResult Show(FileSaveParameter parameter)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = parameter.Title;
            dialog.Filter = parameter.Filter;
            dialog.FileName = parameter.FileName;
            dialog.InitialDirectory = parameter.InitialDirectory;
            var result = new FileSaveResult();
            if (dialog.ShowDialog() == true)
            {
                result.Result = true;
                result.FilePath = dialog.FileName;
            }
            else
            {
                result.Result = false;
            }
            return result;
        }

        /// <summary>
        /// ファイルオープンダイアログ表示
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        protected override FileOpenResult Show(FileOpenParameter parameter)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = parameter.Title;
            dialog.Filter = parameter.Filter;
            dialog.InitialDirectory = parameter.InitialDirectory;
            var result = new FileOpenResult();
            if (dialog.ShowDialog() == true)
            {
                result.Result = true;
                result.FilePath = dialog.FileName;
            }
            else
            {
                result.Result = false;
            }
            return result;
        }

        /// <summary>
        /// 品名検索ダイアログ表示
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        protected override HimmeiSearchResult Show(HimmeiSearchParameter parameter)
        {
            var newDialog = new HimmeiSearchDialog();
            return newDialog.ShowDialog(parameter);

        }
    }
}