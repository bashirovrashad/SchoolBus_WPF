﻿#pragma checksum "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AB67D069DBA84761D5005AC0A20D47B61365A87"
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
using schoolbus;


namespace schoolbus {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create_ride_button;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rides_button;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button class_button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button student_button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button parent_button;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button driver_button;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button car_button;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button holiday_button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainframe;
        
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
            System.Uri resourceLocater = new System.Uri("/schoolbus;component/views/viewwindows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
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
            this.create_ride_button = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
            this.create_ride_button.Click += new System.Windows.RoutedEventHandler(this.create_ride_page_open);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rides_button = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
            this.rides_button.Click += new System.Windows.RoutedEventHandler(this.rides_page_open);
            
            #line default
            #line hidden
            return;
            case 3:
            this.class_button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
            this.class_button.Click += new System.Windows.RoutedEventHandler(this.class_page_open);
            
            #line default
            #line hidden
            return;
            case 4:
            this.student_button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
            this.student_button.Click += new System.Windows.RoutedEventHandler(this.student_page_open);
            
            #line default
            #line hidden
            return;
            case 5:
            this.parent_button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
            this.parent_button.Click += new System.Windows.RoutedEventHandler(this.parent_page_open);
            
            #line default
            #line hidden
            return;
            case 6:
            this.driver_button = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
            this.driver_button.Click += new System.Windows.RoutedEventHandler(this.driver_page_open);
            
            #line default
            #line hidden
            return;
            case 7:
            this.car_button = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
            this.car_button.Click += new System.Windows.RoutedEventHandler(this.car_page_open);
            
            #line default
            #line hidden
            return;
            case 8:
            this.holiday_button = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\Views\ViewWindows\MainWindow.xaml"
            this.holiday_button.Click += new System.Windows.RoutedEventHandler(this.holiday_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mainframe = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

