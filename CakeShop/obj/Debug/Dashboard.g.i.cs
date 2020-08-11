﻿#pragma checksum "..\..\Dashboard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C78F77BADB996737F836031BE584BE7B7BC5463BD707B1D3461D19EE85EF72C"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTitle;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame _mainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/CakeShop;component/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dashboard.xaml"
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
            
            #line 9 "..\..\Dashboard.xaml"
            ((CakeShop.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Dashboard_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\Dashboard.xaml"
            ((MaterialDesignThemes.Wpf.ColorZone)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ColorZone_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 40 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCommands_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 52 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCommands_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 62 "..\..\Dashboard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCommands_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this._mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

