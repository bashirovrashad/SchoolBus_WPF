﻿#pragma checksum "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596F60B9F056D17F9EA94F53CF15C07B6800E045"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using schoolbus.Views.ViewWindows;


namespace schoolbus.Views.ViewWindows {
    
    
    /// <summary>
    /// New_Car_Window
    /// </summary>
    public partial class New_Car_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name_textbox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox number_textbox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox count_textbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/schoolbus;V1.0.0.0;component/views/viewwindows/new_car_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.name_textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
            this.name_textbox.GotFocus += new System.Windows.RoutedEventHandler(this._focus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
            this.name_textbox.LostFocus += new System.Windows.RoutedEventHandler(this._lost_focus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.number_textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
            this.number_textbox.GotFocus += new System.Windows.RoutedEventHandler(this._focus);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
            this.number_textbox.LostFocus += new System.Windows.RoutedEventHandler(this._lost_focus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.count_textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
            this.count_textbox.GotFocus += new System.Windows.RoutedEventHandler(this._focus);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
            this.count_textbox.LostFocus += new System.Windows.RoutedEventHandler(this._lost_focus);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\..\..\..\Views\ViewWindows\New_Car_Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.create_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

