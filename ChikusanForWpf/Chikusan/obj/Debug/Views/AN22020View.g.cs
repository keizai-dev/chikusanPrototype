﻿#pragma checksum "..\..\..\Views\AN22020View.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "964608DE023AAF4EDBFBF76023A466951B267FA4"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using JaGunma.Chikusan.Behaviors;
using JaGunma.Chikusan.Converters;
using JaGunma.Chikusan.Loading;
using JaGunma.Chikusan.Message;
using JaGunma.Chikusan.Views;
using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace JaGunma.Chikusan.Views {
    
    
    /// <summary>
    /// AN22020View
    /// </summary>
    public partial class AN22020View : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 95 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HimmeiCodeStartTextBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HimmeiSearchButton;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HimmeiCodeEndTextBox;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HimmeiTextBox;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DantaiCodeStartTextBox;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DantaiCodeEndTextBox;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DantaiNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KoushinshaCodeTextBox;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KoushinshaNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KoushinDateStartTextBox;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KoushinDateEndTextBox;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox StopCheckBox;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DantaiDataGrid;
        
        #line default
        #line hidden
        
        
        #line 284 "..\..\..\Views\AN22020View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ErrorMessageTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Chikusan;component/views/an22020view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AN22020View.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 21 "..\..\..\Views\AN22020View.xaml"
            ((JaGunma.Chikusan.Views.AN22020View)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HimmeiCodeStartTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 95 "..\..\..\Views\AN22020View.xaml"
            this.HimmeiCodeStartTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.HimmeiCodeStartTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HimmeiSearchButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.HimmeiCodeEndTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 98 "..\..\..\Views\AN22020View.xaml"
            this.HimmeiCodeEndTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.HimmeiCodeEndTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.HimmeiTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\..\Views\AN22020View.xaml"
            this.HimmeiTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.HimmeiTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DantaiCodeStartTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 117 "..\..\..\Views\AN22020View.xaml"
            this.DantaiCodeStartTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.DantaiCodeStartTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DantaiCodeEndTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 120 "..\..\..\Views\AN22020View.xaml"
            this.DantaiCodeEndTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.DantaiCodeEndTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DantaiNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 123 "..\..\..\Views\AN22020View.xaml"
            this.DantaiNameTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.DantaiNameTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.KoushinshaCodeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 139 "..\..\..\Views\AN22020View.xaml"
            this.KoushinshaCodeTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.KoushinshaCodeTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.KoushinshaNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 141 "..\..\..\Views\AN22020View.xaml"
            this.KoushinshaNameTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.KoushinshaNameTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.KoushinDateStartTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 157 "..\..\..\Views\AN22020View.xaml"
            this.KoushinDateStartTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.KoushinDateStartTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.KoushinDateEndTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 159 "..\..\..\Views\AN22020View.xaml"
            this.KoushinDateEndTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.KoushinDateEndTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 13:
            this.StopCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 14:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.DantaiDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 17:
            this.ErrorMessageTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 16:
            
            #line 195 "..\..\..\Views\AN22020View.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

