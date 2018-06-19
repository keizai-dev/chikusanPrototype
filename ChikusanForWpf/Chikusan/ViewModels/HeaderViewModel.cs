using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using JaGunma.Chikusan.RetentionData;

namespace JaGunma.Chikusan.ViewModels
{
    public class HeaderViewModel : AbstractViewModel
    {
        #region メンバ変数

        private Double _fontSize;
        public Double FontSize
        {
            get { return _fontSize; }
            set
            {
                this._fontSize = value;
                System.Windows.Application.Current.Resources["AllFontSize"] = value;
                this.SetProperty(ref this._fontSize, value);
            }
        }
        private bool _toggleFont = false;
        private string _fontFamilly = "Meiryo UI";
        public string FontFamilly
        {
            get { return _fontFamilly; }
            set
            {
                this._toggleFont = !this._toggleFont;
                if (this._toggleFont)
                {
                    System.Windows.Application.Current.Resources["AllFontFamily"] = new System.Windows.Media.FontFamily(value);
                    System.Windows.Application.Current.Resources["HeaderFontFamily"] = new System.Windows.Media.FontFamily(value);
                }
                else
                {
                    System.Windows.Application.Current.Resources["AllFontFamily"] = new System.Windows.Media.FontFamily("Meiryo UI");
                    System.Windows.Application.Current.Resources["HeaderFontFamily"] = new System.Windows.Media.FontFamily("Meiryo UI");
                }
                
                this.SetProperty(ref this._fontFamilly, value);
            }
        }
        private string _jaCode;
        public string JaCode
        {
            get { return _jaCode; }
            set
            {
                this.SetProperty(ref this._jaCode, value);
            }
        }
        private string _tempoCode;
        public string TempoCode
        {
            get { return _tempoCode; }
            set
            {
                this.SetProperty(ref this._tempoCode, value);
            }
        }
        private string _userID;
        public string UserID
        {
            get { return _userID; }
            set
            {
                this.SetProperty(ref this._userID, value);
            }
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                this.SetProperty(ref this._userName, value);
            }
        }
        private string _userInfo;
        public string UserInfo
        {
            get { return _userInfo; }
            set
            {
                this.SetProperty(ref this._userInfo, value);
            }
        }

        private DelegateCommand _testCommand;
        public DelegateCommand TestCommand
        {
            get
            {
                return this._testCommand = this._testCommand ?? new DelegateCommand(() => this.FontFamilly = "Yu Gothic UI");
            }
        }

        private DelegateCommand _menuPageCommand;
        public DelegateCommand MenuPageCommand
        {
            get
            {
                return this._menuPageCommand = this._menuPageCommand ?? new DelegateCommand(MenuPage);
            }
        }
        public InteractionRequest<INotification> MenuPageRequest { get; } = new InteractionRequest<INotification>();
        #endregion

        #region  コンストラクタ
        public HeaderViewModel()
        {
            FontSize = 14.67d;
            HeaderRetentionData.JaCode = "006";
            HeaderRetentionData.TempoCode = "001";
            HeaderRetentionData.JaName = "JA前橋市";
            HeaderRetentionData.TempoName = "本所";
            HeaderRetentionData.UserID = "AN000001";
            HeaderRetentionData.UserName = "電算　孝之";
            this.JaCode = HeaderRetentionData.JaCode;
            this.TempoCode = HeaderRetentionData.TempoCode;
            this.UserID = HeaderRetentionData.UserID;
            this.UserName = HeaderRetentionData.UserName;
            this.UserInfo = HeaderRetentionData.JaName + "　"+ HeaderRetentionData.TempoName + "　" + HeaderRetentionData.UserID + " " + HeaderRetentionData.UserName ;

        }


        #endregion

        #region メソッド
        private void MenuPage()
        {
            this.MenuPageRequest.Raise(new Notification { Title = "　AN00001　メニュー", Content = new MenuViewModel() });
        }
        #endregion


        #region 実装

        #endregion

    }
}
