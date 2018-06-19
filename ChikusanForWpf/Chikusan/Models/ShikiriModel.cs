using JaGunma.Chikusan.DataModels;
using JaGunma.Chikusan.RetentionData;
using JaGunma.Chikusan.Message;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Practices.ObjectBuilder2;
using JaGunma.Chikusan.Commons;

namespace JaGunma.Chikusan.Models
{
    public class ShikiriModel :BindableBase
    {
        #region メンバ変数
        /// <summary>
        /// 団体リスト
        /// </summary>
        private ObservableCollection<ShikiriDto> _shikiriList = new ObservableCollection<ShikiriDto>();
        public ObservableCollection<ShikiriDto> ShikiriList
        {
           get { return this._shikiriList; }
           set
            {
               this.SetProperty(ref this._shikiriList, value);
            }
        }

        /// <summary>
        /// 選択仕切
        /// </summary>
        private ShikiriDto _selectedShikiri;
        public ShikiriDto SelectedShikiri
        {
            get { return _selectedShikiri; }
            set
            {
                this.SetProperty(ref this._selectedShikiri, value);
            }
        }
   

        #endregion

        #region コンストラクタ
        public ShikiriModel()
        {
        }
        #endregion

        #region メソッド
        /// <summary>
        ///  エラー仕切一覧を取得
        /// </summary>
        /// <returns>団体一覧</returns>
        public void SearchErrorShikiriIchiran()
        {
            this.ShikiriList = new ObservableCollection<ShikiriDto>(ShikiriDto.GetTestData());
            //this.DantaiList = new List<DantaiDto>(DantaiDto.GetTestData());
            if (this.ShikiriList.Count > 0)
            {
                this.SelectedShikiri = this.ShikiriList[0];
            }
        }

        /// <summary>
        /// データグリッドの選択トグル操作
        /// </summary>
        /// <param name="isAllSelected"></param>
        public void ToggleSelect(bool isAllSelected)
        {
            if (isAllSelected)
            {
                this.ShikiriList.ForEach(x => x.IsSelected = true);
            }
            else
            {
                this.ShikiriList.ForEach(x => x.IsSelected = false);
            }
            this.ShikiriList = new ObservableCollection<ShikiriDto>(this.ShikiriList);
        }
        #endregion

    }
}
