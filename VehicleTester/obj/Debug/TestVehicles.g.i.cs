﻿#pragma checksum "..\..\TestVehicles.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C51A0158EE06392DC5A8101DF56DBB9D"
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
using VehicleTester;


namespace VehicleTester {
    
    
    /// <summary>
    /// TestVehicles
    /// </summary>
    public partial class TestVehicles : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\TestVehicles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\TestVehicles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Test;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TestVehicles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Done;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\TestVehicles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox UnapprovedVehicles;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\TestVehicles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ApprovedVehicles;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\TestVehicles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UnapprLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\TestVehicles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ApprLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/VehicleTester;component/testvehicles.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TestVehicles.xaml"
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
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\TestVehicles.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Test = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\TestVehicles.xaml"
            this.Test.Click += new System.Windows.RoutedEventHandler(this.Test_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Done = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\TestVehicles.xaml"
            this.Done.Click += new System.Windows.RoutedEventHandler(this.Done_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UnapprovedVehicles = ((System.Windows.Controls.ListBox)(target));
            
            #line 14 "..\..\TestVehicles.xaml"
            this.UnapprovedVehicles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UnapprovedVehicles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ApprovedVehicles = ((System.Windows.Controls.ListBox)(target));
            
            #line 28 "..\..\TestVehicles.xaml"
            this.ApprovedVehicles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ApprovedVehicles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UnapprLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.ApprLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

