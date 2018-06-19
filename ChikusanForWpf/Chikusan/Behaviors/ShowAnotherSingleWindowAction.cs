using Microsoft.Practices.Unity;
using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace JaGunma.Chikusan.Behaviors
{
    public class ShowAnotherSingleWindowAction : TriggerAction<DependencyObject>
    {
        protected override void Invoke(object parameter)
        {
            var args = parameter as InteractionRequestedEventArgs;
            var vm = args.Context.Content;
            var callerWindow = Window.GetWindow(AssociatedObject);

            var windowTitles = Application
                                        .Current
                                        .Windows
                                        .Cast<Window>()
                                        .Aggregate(
                                            new StringBuilder(),
                                            (sb, w) => sb.AppendLine(w.Title))
                                        .ToString();
            //画面表示チェック
            if (windowTitles.IndexOf(args.Context.Title.Trim()) >= 0)
            {
                var existWindow = (Window)Application.Current.Windows.Cast<Window>().Where(x => x.Title.Contains(args.Context.Title.Trim().Substring(0,7))).ToArray()[0];
                existWindow.Activate();
                return;
            }

            //対象Viewを検索して生成
            var window = new Window();
            try
            {
                var viewModelString = "ViewModels.";
                var viewModelIndex = vm.ToString().IndexOf(viewModelString);
                var viewString = vm.ToString().Substring(viewModelIndex + viewModelString.Length, 11);
                var viewType = AllClasses.FromAssemblies(GetType().Assembly)
                .Where(x => x.Namespace == "JaGunma.Chikusan.Views" && x.Name.StartsWith(viewString)).ToArray()[0];

                //var nameSpace = viewObject.Select(x => x.Namespace).ToArray()[0];
                //var type = Type.GetType(nameSpace + "."+ viewString);
                var viewObject = (UserControl)Activator.CreateInstance(viewType);

                window.Title = args.Context.Title;
                viewObject.DataContext = vm;
                window.Content = viewObject;
            }
            catch (Exception ex)
            {
                throw new Exception("画面の生成に失敗しました。",ex);
            }

            var style = new Style(typeof(Window));
            style.BasedOn = (Style)System.Windows.Application.Current.Resources["WindowBase"];
            window.Style = style;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();

            //親ウィンドウ非表示
            callerWindow.Close();

            //呼び出しが終わったことを伝えるコールバック
            args.Callback.Invoke();
        }
    }
}
