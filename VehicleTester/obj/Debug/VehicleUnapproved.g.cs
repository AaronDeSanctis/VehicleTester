﻿#pragma checksum "..\..\VehicleUnapproved.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "05816D4DC4ACBCE4AD0C747C0C39C522"
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
    /// VehicleUnapproved
    /// </summary>
    public partial class VehicleUnapproved : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\VehicleUnapproved.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\VehicleUnapproved.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RestartQuestionaire;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\VehicleUnapproved.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindMechanic;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\VehicleUnapproved.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Failure0;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\VehicleUnapproved.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Failure1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\VehicleUnapproved.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Failure2;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\VehicleUnapproved.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Failed;
        
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
            System.Uri resourceLocater = new System.Uri("/VehicleTester;component/vehicleunapproved.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VehicleUnapproved.xaml"
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
            
            #line 11 "..\..\VehicleUnapproved.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RestartQuestionaire = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\VehicleUnapproved.xaml"
            this.RestartQuestionaire.Click += new System.Windows.RoutedEventHandler(this.RestartQuestionaire_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FindMechanic = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\VehicleUnapproved.xaml"
            this.FindMechanic.Click += new System.Windows.RoutedEventHandler(this.FindMechanic_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Failure0 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Failure1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Failure2 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Failed = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

