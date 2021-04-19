﻿#pragma checksum "..\..\..\DoctorFunctional.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D0DE8F831D96A2243858D0AEF68918241CFE9DDE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Sims;
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


namespace Sims {
    
    
    /// <summary>
    /// DoctorFunctional
    /// </summary>
    public partial class DoctorFunctional : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Sims;V1.0.0.0;component/doctorfunctional.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DoctorFunctional.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Appointment);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_Appointments);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Appointment);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 13 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Appointment);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Request);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_Requests);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 16 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Request);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 17 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Request);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 18 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Operation);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 19 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Operation);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 20 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Operation);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 21 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_Operation);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 22 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_Schedule);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 23 "..\..\..\DoctorFunctional.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Create_Receipe);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

