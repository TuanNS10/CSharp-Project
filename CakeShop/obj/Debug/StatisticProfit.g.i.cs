﻿#pragma checksum "..\..\StatisticProfit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DFB5E094500E374CB654CE51CC226C311E9FEE89F54B3151A0D009A927558116"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CakeShop;
using InteractiveDataDisplay.WPF;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace CakeShop {
    
    
    /// <summary>
    /// StatisticProfit
    /// </summary>
    public partial class StatisticProfit : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\StatisticProfit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal InteractiveDataDisplay.WPF.Chart Plotter;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\StatisticProfit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Lines;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\StatisticProfit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox editMonth;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\StatisticProfit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox editYear;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\StatisticProfit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGrow;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\StatisticProfit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoDayMonth;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\StatisticProfit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoMonthYear;
        
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
            System.Uri resourceLocater = new System.Uri("/CakeShop;component/statisticprofit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StatisticProfit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.Plotter = ((InteractiveDataDisplay.WPF.Chart)(target));
            return;
            case 2:
            this.Lines = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.editMonth = ((System.Windows.Controls.ComboBox)(target));
            
            #line 100 "..\..\StatisticProfit.xaml"
            this.editMonth.DropDownOpened += new System.EventHandler(this.ComboProductTypes_DropDownOpened);
            
            #line default
            #line hidden
            
            #line 101 "..\..\StatisticProfit.xaml"
            this.editMonth.DropDownClosed += new System.EventHandler(this.ComboProductTypes_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.editYear = ((System.Windows.Controls.ComboBox)(target));
            
            #line 117 "..\..\StatisticProfit.xaml"
            this.editYear.DropDownOpened += new System.EventHandler(this.ComboProductTypes_DropDownOpened);
            
            #line default
            #line hidden
            
            #line 118 "..\..\StatisticProfit.xaml"
            this.editYear.DropDownClosed += new System.EventHandler(this.ComboProductTypes_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnGrow = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\StatisticProfit.xaml"
            this.btnGrow.Click += new System.Windows.RoutedEventHandler(this.BtnGrow_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rdoDayMonth = ((System.Windows.Controls.RadioButton)(target));
            
            #line 150 "..\..\StatisticProfit.xaml"
            this.rdoDayMonth.Checked += new System.Windows.RoutedEventHandler(this.RdoDayMonth_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rdoMonthYear = ((System.Windows.Controls.RadioButton)(target));
            
            #line 161 "..\..\StatisticProfit.xaml"
            this.rdoMonthYear.Click += new System.Windows.RoutedEventHandler(this.RdoMonthYear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
