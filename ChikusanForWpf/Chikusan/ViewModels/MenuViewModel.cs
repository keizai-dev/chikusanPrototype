using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using Prism.Interactivity.InteractionRequest;
using Prism.Regions;
using JaGunma.Chikusan.Models;
using JaGunma.Chikusan.DataModels;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.Reactive.Linq;
using System.Windows.Navigation;

namespace JaGunma.Chikusan.ViewModels
{
        public class MenuViewModel : AbstractViewModel
    {

        #region メンバ変数

        public InteractionRequest<Notification> NotificationRequest { get; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> ConfirmationRequest { get; } = new InteractionRequest<Confirmation>();

        private NavigationService _navigationService { get; set; }
        public InteractionRequest<INotification> NewPageRequest { get; } = new InteractionRequest<INotification>();
        private DelegateCommand NewPageCommand { get; set; }
        private DelegateCommand _moveAn22020Command;
        public DelegateCommand MoveAN22020Command
        {
            get
            {
                return this._moveAn22020Command = this._moveAn22020Command ?? new DelegateCommand(MoveAN22020Page);
            }
            set { }
        }
        private DelegateCommand _moveAn13020Command;
        public DelegateCommand MoveAN13020Command
        {
            get
            {
                return this._moveAn13020Command = this._moveAn13020Command ?? new DelegateCommand(MoveAN13020Page);
            }
            set { }
        }
        #endregion

        #region コンストラクタ
        //public AN22020ViewModel(RegionManager regionManager) : base() {
        //    this.RegionManager = regionManager;
        //    ModelObjectMapping();
        //}
        public MenuViewModel() : base()
        {
            //this.NewPageCommand = new DelegateCommand(() => this.NewPageRequest.Raise(new Notification { Title = "sample", Content = "sample" }));
            //this.NewPageCommand = new DelegateCommand(MoveEntryPage);
            //var copyValue = "";
            //var aa = copyValue.Substring(10, 500);
            //DisplayHoldData.DantaiHoldData.DantaiDataList = new List<DantaiDto>();
        }
        #endregion

        #region メソッド

        /// <summary>
        /// AN22020画面遷移
        /// </summary>
        private void MoveAN22020Page()
        {
            //this.NotificationRequest.Raise(new Notification { Title = "警告", Content = "まだできてません。" });
            //this.RegionManager.RequestNavigate("MainRegion", nameof(Views.CalcResultView));
            this.NewPageRequest.Raise(new Notification { Title = "　AN22020　団体マスタメンテナンス＜一覧＞", Content = new AN22020ViewModel()});
        }

        /// <summary>
        /// AN13020画面遷移
        /// </summary>
        private void MoveAN13020Page()
        {
            //this.NotificationRequest.Raise(new Notification { Title = "警告", Content = "まだできてません。" });
            //this.RegionManager.RequestNavigate("MainRegion", nameof(Views.CalcResultView));
            this.NewPageRequest.Raise(new Notification { Title = "　AN13020 エラー仕切＜一覧＞", Content = new AN13020ViewModel() });
        }
        #endregion

        #region 実装

        #endregion

    }

}
