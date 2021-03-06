﻿using JaGunma.Chikusan.ViewModels;
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
    public partial class AN22020View : UserControl
    {
        public AN22020View()
        {
            //デザイナモード判別
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) return;

            InitializeComponent();
            //this.DataContext = new AN22020ViewModel(this.Navigation);
            //this.Title = this.Title += "　AN22020　団体一覧";
        }

        /// <summary>
        /// 画面読込後イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // Todo:初期化時に初期フォーカスがうまくセットできないため、読込後に設定する
            HimmeiCodeStartTextBox.Focus();

        }

        /// <summary>
        /// 品名コード開始押下イベント
        /// </summary>
        /// <remarks>
        /// フォーカス系はコードビハインド行きか
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HimmeiCodeStartTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                HimmeiCodeEndTextBox.Focus();
            }
        }

        /// <summary>
        /// 品名コード終了押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HimmeiCodeEndTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                HimmeiTextBox.Focus();
            }
        }

        /// <summary>
        /// 品名押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HimmeiTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DantaiCodeStartTextBox.Focus();
            }
        }

        /// <summary>
        /// 団体コード開始押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DantaiCodeStartTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DantaiCodeEndTextBox.Focus();
            }
        }

        /// 団体コード終了押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DantaiCodeEndTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DantaiNameTextBox.Focus();
            }
        }

        /// <summary>
        /// 団体名押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DantaiNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                KoushinshaCodeTextBox.Focus();
            }
        }

        /// <summary>
        /// 更新者コード押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KoushinshaCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                KoushinshaNameTextBox.Focus();
            }
        }

        /// <summary>
        /// 更新者名押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KoushinshaNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                KoushinDateStartTextBox.Focus();
            }
        }

        /// <summary>
        /// 更新日開始押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KoushinDateStartTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                KoushinDateEndTextBox.Focus();
            }
        }

        /// <summary>
        /// 更新日終了押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KoushinDateEndTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchButton.Focus();
            }
        }

        /// <summary>
        /// チェックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.DantaiDataGrid.SelectedItem = null;
        }
    }
}
