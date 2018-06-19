using System;
using System.Windows;
using System.Windows.Interactivity;

namespace JaGunma.Chikusan.Message
{
    /// <summary>
    /// メッセージボックスを表示するためのメッセンジャー。
    /// </summary>
    /// <remarks>
    /// MessageBox.Showメソッドで、イベントトリガーを起動する。
    /// 実際の表示は、イベントトリガーから実行される
    /// トリガーアクションに実装される。
    /// </remarks>
    public class DialogMessenger
    {
        /// <summary>
        /// MessageBoxTriggerを起動するイベント。
        /// </summary>
        public event EventHandler<EventArgs> ShowMessageBox;

        /// <summary>
        /// MessageBoxTriggerを起動するイベントの名前。
        /// </summary>
        public static string EventName
        { get { return "ShowMessageBox"; } }

        /// <summary>
        /// このクラスはシングルトン。
        /// </summary>
        public static DialogMessenger Instance
        { get; set; } 
        public DialogMessenger() { }

        /// <summary>
        /// MessageBoxTriggerを起動するイベントの引数。
        /// トリガーアクションへ渡されて処理される。
        /// </summary>
        public class EventArgs : System.EventArgs
        {
            //public string Text { get; set; }
            //public string Title { get; set; }
            //public MessageBoxButton Button { get; set; }
            //public MessageBoxImage Icon { get; set; }
            public DialogParameter Parameter { get; set; }
            public FileSaveParameter SaveParameter { get; set; }
            public FileOpenParameter OpenParameter { get; set; }
            public HimmeiSearchParameter HimmeiSearchParameter { get; set; }

            /// <summary>
            /// メッセージボックスの結果を受け取るコールバック
            /// </summary>
            //public Action<MessageBoxResult> NotifyResult
            public Action<DialogResult> NotifyResult
            { get; set; }
            public Action<FileSaveResult> NotifySaveResult
            { get; set; }
            public Action<FileOpenResult> NotifyOpenResult
            { get; set; }
            public Action<HimmeiSearchResult> NotifyHimmeiSearchResult
            { get; set; }
        }

        /// <summary>
        /// メッセージボックスを表示。
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        /// <remarks>
        /// 実際にはイベントを発行してイベントトリガーを起動する。
        /// </remarks>
        //public static MessageBoxResult Show(
        //string messageBoxText,
        //    string title = null,
        //    MessageBoxButton button = MessageBoxButton.OK,
        //    MessageBoxImage icon = MessageBoxImage.Information)
        public static DialogResult Show(DialogParameter parameter)
        {
            //メッセージボックスの結果
            //MessageBoxResult messageBoxResult = MessageBoxResult.Cancel;
            var messageBoxResult = new DialogResult(true, string.Empty);
            //イベントを発行する
            Instance.ShowMessageBox?.Invoke(
                Instance,
                new DialogMessenger.EventArgs()
                {
                    //Text = messageBoxText,
                    //Title = title,
                    //Button = button,
                    //Icon = icon,
                    Parameter = parameter,

                    //コールバックで結果を受け取る
                    NotifyResult = result =>
                    {
                        messageBoxResult = result;
                    }
                });
            //メッセージボックスの結果を返す
            return messageBoxResult;
        }

        public static FileSaveResult Show(FileSaveParameter parameter)
        {
            //メッセージボックスの結果
            var saveResult = new FileSaveResult();
            //イベントを発行する
            Instance.ShowMessageBox?.Invoke(
                Instance,
                new DialogMessenger.EventArgs()
                {
                    SaveParameter = parameter,

                    //コールバックで結果を受け取る
                    NotifySaveResult = result =>
                    {
                        saveResult = result;
                    }
                });

            return saveResult;
        }

        public static FileOpenResult Show(FileOpenParameter parameter)
        {
            //メッセージボックスの結果
            var openResult = new FileOpenResult();
            //イベントを発行する
            Instance.ShowMessageBox?.Invoke(
                Instance,
                new DialogMessenger.EventArgs()
                {
                    OpenParameter = parameter,

                    //コールバックで結果を受け取る
                    NotifyOpenResult = result =>
                    {
                        openResult = result;
                    }
                });

            return openResult;
        }

        public static HimmeiSearchResult Show(HimmeiSearchParameter parameter)
        {
            //メッセージボックスの結果
            var openResult = new HimmeiSearchResult();
            //イベントを発行する
            Instance.ShowMessageBox?.Invoke(
                Instance,
                new DialogMessenger.EventArgs()
                {
                    HimmeiSearchParameter = parameter,

                    //コールバックで結果を受け取る
                    NotifyHimmeiSearchResult = result =>
                    {
                        openResult = result;
                    }
                });

            return openResult;
        }

        /// <summary>
        /// メッセージを表示するトリガーアクション実装用の抽象基底クラス。
        /// </summary>
        /// <remarks>
        /// 派生クラスでShowMessageを実装する。 
        /// </remarks>
        public abstract class Action : TriggerAction<DependencyObject>
        {
            /// <summary>
            /// アクションの実態
            /// </summary>
            /// <param name="parameter"></param>
            protected override void Invoke(object parameter)
            {
                //イベント引数の種別を検査
                var messageBoxArgs = parameter as DialogMessenger.EventArgs;
                if(messageBoxArgs == null){return;}

                //メッセージボックスの表示結果を取得
                if(messageBoxArgs.Parameter != null)
                {
                    DialogResult result = Show(messageBoxArgs.Parameter);
                    //コールバックで結果を通知
                    messageBoxArgs.NotifyResult?.Invoke(result);
                }
                else if (messageBoxArgs.SaveParameter != null)
                {
                    FileSaveResult saveResult = Show(messageBoxArgs.SaveParameter);
                    //コールバックで結果を通知
                    messageBoxArgs.NotifySaveResult?.Invoke(saveResult);
                }
                else if (messageBoxArgs.OpenParameter != null)
                {
                    FileOpenResult openResult = Show(messageBoxArgs.OpenParameter);
                    //コールバックで結果を通知
                    messageBoxArgs.NotifyOpenResult?.Invoke(openResult);
                }
                else if (messageBoxArgs.HimmeiSearchParameter != null)
                {
                    HimmeiSearchResult openResult = Show(messageBoxArgs.HimmeiSearchParameter);
                    //コールバックで結果を通知
                    messageBoxArgs.NotifyHimmeiSearchResult?.Invoke(openResult);
                }
            }

            /// <summary>
            /// メッセージボックスを表示する抽象メソッド。
            /// </summary>
            /// <param name="parameter"></param>
            /// <returns></returns>
            //abstract protected MessageBoxResult
            //ShowMessage(
            //    string text, string title,
            //    MessageBoxButton button,
            //    MessageBoxImage icon);
            abstract protected DialogResult
            Show(DialogParameter parameter);
            abstract protected FileSaveResult
            Show(FileSaveParameter parameter);
            abstract protected FileOpenResult
            Show(FileOpenParameter parameter);
            abstract protected HimmeiSearchResult
            Show(HimmeiSearchParameter parameter);
        }
    }

    /// <summary>
    /// MVVM的メッセージボックスを表示するためのイベントトリガー。
    /// </summary>
    /// <remarks>
    /// MessageBox メッセンジャーの発行するイベントで起動される。
    /// </remarks>
    public class DialogTrigger : System.Windows.Interactivity.EventTrigger
    {
        public DialogTrigger()
            : base(DialogMessenger.EventName)
        {
            //毎回セットするとページ遷移ごとにイベントが発生してしまう
            if (DialogMessenger.Instance == null)
            {
                DialogMessenger.Instance = new DialogMessenger();
                SourceObject = DialogMessenger.Instance;
            }
        }
    }
}