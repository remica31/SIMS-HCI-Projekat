#pragma checksum "..\..\..\DoctorXAML\Appointments.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3BFCAFBB58C82BC998795430A2F23CB443F4A2DB37B5EB9D8CBD199D338DF4E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RefaktorisaniSims.DoctorXAML;
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


namespace RefaktorisaniSims.DoctorXAML {
    
    
    /// <summary>
    /// Appointments
    /// </summary>
    public partial class Appointments : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 104 "..\..\..\DoctorXAML\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label name;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\DoctorXAML\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label surname;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\DoctorXAML\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label phone;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\DoctorXAML\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label address;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\DoctorXAML\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label appId;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\DoctorXAML\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView bindingApps;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\DoctorXAML\Appointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date;
        
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
            System.Uri resourceLocater = new System.Uri("/RefaktorisaniSims;component/doctorxaml/appointments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DoctorXAML\Appointments.xaml"
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
            
            #line 41 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Info_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 49 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 59 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.translate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 79 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Info_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 83 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.prescribe_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.name = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.surname = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.phone = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.address = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.appId = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.bindingApps = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            this.date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 13:
            
            #line 132 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.show_click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 133 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.select_click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 136 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hospital_treatment);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 137 "..\..\..\DoctorXAML\Appointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

