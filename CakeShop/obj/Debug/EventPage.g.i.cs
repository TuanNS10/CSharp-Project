﻿#pragma checksum "..\..\EventPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DEBD713D1531B32B9215DC34BD3FDE3893D6CB76DD73198A176D3AB45E6A8D5E"
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
    /// EventPage
    /// </summary>
    public partial class EventPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Title;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listEvent;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editSale;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editBuyGet_Buy;
        
        #line default
        #line hidden
        
        
        #line 291 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editBuyGet_Get;
        
        #line default
        #line hidden
        
        
        #line 305 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker editDateBegin;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker editDateEnd;
        
        #line default
        #line hidden
        
        
        #line 334 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddEvent;
        
        #line default
        #line hidden
        
        
        #line 350 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveEvent;
        
        #line default
        #line hidden
        
        
        #line 367 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editEventName;
        
        #line default
        #line hidden
        
        
        #line 374 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressBar;
        
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
            System.Uri resourceLocater = new System.Uri("/CakeShop;component/eventpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EventPage.xaml"
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
            this.Title = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.listEvent = ((System.Windows.Controls.ListView)(target));
            
            #line 72 "..\..\EventPage.xaml"
            this.listEvent.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListEvent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.editSale = ((System.Windows.Controls.TextBox)(target));
            
            #line 254 "..\..\EventPage.xaml"
            this.editSale.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberOnly_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.editBuyGet_Buy = ((System.Windows.Controls.TextBox)(target));
            
            #line 269 "..\..\EventPage.xaml"
            this.editBuyGet_Buy.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberOnly_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editBuyGet_Get = ((System.Windows.Controls.TextBox)(target));
            
            #line 282 "..\..\EventPage.xaml"
            this.editBuyGet_Get.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberOnly_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editDateBegin = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.editDateEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.btnAddEvent = ((System.Windows.Controls.Button)(target));
            
            #line 333 "..\..\EventPage.xaml"
            this.btnAddEvent.Click += new System.Windows.RoutedEventHandler(this.BtnAddEvent_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnRemoveEvent = ((System.Windows.Controls.Button)(target));
            
            #line 349 "..\..\EventPage.xaml"
            this.btnRemoveEvent.Click += new System.Windows.RoutedEventHandler(this.BtnRemoveEvent_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.editEventName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.ProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

