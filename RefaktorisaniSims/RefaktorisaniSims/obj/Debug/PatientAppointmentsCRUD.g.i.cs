﻿#pragma checksum "..\..\PatientAppointmentsCRUD.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B05BEF351FC11B0AC6E4DD9EF12B9F20BD340DE9D1FAE9813A23EC666E121EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RefaktorisaniSims;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace RefaktorisaniSims {
    
    
    /// <summary>
    /// PatientAppointmentsCRUD
    /// </summary>
    public partial class PatientAppointmentsCRUD : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDataBinding3;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox2;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox3;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datum;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox4;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox5;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox6;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\PatientAppointmentsCRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datum2;
        
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
            System.Uri resourceLocater = new System.Uri("/RefaktorisaniSims;component/patientappointmentscrud.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PatientAppointmentsCRUD.xaml"
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
            this.lvDataBinding3 = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            
            #line 32 "..\..\PatientAppointmentsCRUD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_appointment);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 33 "..\..\PatientAppointmentsCRUD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.View_appointments);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 34 "..\..\PatientAppointmentsCRUD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_appointment);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 35 "..\..\PatientAppointmentsCRUD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_appointment);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textBox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.textBox3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.datum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.textBox4 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.textBox5 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.textBox6 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.datum2 = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

