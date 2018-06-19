using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;
using Prism.Commands;

namespace JaGunma.HeaderModule.ViewModels
{
    public class HeaderViewModel : AbstractViewModel
    {
        #region メンバ変数

        private Double _fontSize = 13d;
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

        private DelegateCommand _testCommand;
        public DelegateCommand TestCommand
        {
            get
            {
                return this._testCommand = this._testCommand ?? new DelegateCommand(() => this.FontFamilly = "Yu Gothic UI");
            }
        }

        #endregion



        #region 実装

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
            return true;
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

#endregion

    }
}
