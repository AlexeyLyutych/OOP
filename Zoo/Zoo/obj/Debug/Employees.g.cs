﻿#pragma checksum "..\..\Employees.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66497F9D37C0DAA2A4A6FE1CF95904E60A016A20"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Zoo;


namespace Zoo {
    
    
    /// <summary>
    /// Employees
    /// </summary>
    public partial class Employees : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeesGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchtext;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clearbtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Employees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Searchbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Zoo;component/employees.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Employees.xaml"
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
            this.EmployeesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.updateButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Employees.xaml"
            this.updateButton.Click += new System.Windows.RoutedEventHandler(this.updateButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Employees.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Employees.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Clearbtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Employees.xaml"
            this.Clearbtn.Click += new System.Windows.RoutedEventHandler(this.Clearbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Searchbtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Employees.xaml"
            this.Searchbtn.Click += new System.Windows.RoutedEventHandler(this.Searchbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

