using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace JaGunma.Chikusan.Behaviors
{

    /// <summary>
    /// Todo:
    /// UserControl に機能をアタッチ（取り付け）、デタッチ（取り外し）
    /// Click イベントにより、UserControlを破棄する
    /// 継承時に任意の型を指定することで、継承元メンバーの AssociatedObject の型が決まる
    /// AssociatedObject を指定のコントロールと見立てて操作する
    /// Associate（アソシエイト） は「関連した、結びついた」というような意味合い
    /// </summary>
    public class UserControlBehavior : Behavior<UserControl>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            CommandBinding CloseCommandBinding = new CommandBinding(
                ApplicationCommands.Close,
                CloseCommandExecuted,
                CloseCommandCanExecute);
            AssociatedObject.CommandBindings.Add(CloseCommandBinding);
        }

        private void CloseCommandExecuted(object target, ExecutedRoutedEventArgs e)
        {
            Window.GetWindow(AssociatedObject).Close();
            e.Handled = true;
        }

        private void CloseCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
            e.Handled = true;
        }
    }

}
