﻿#pragma checksum "..\..\DoctorMedicinesUpdate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E32171D01C05559266C9F6C5693490C1CA70417A7FFE3625D6537CCD9EF5D8E8"
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
    /// DoctorMedicinesUpdate
    /// </summary>
    public partial class DoctorMedicinesUpdate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\DoctorMedicinesUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDataBinding;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\DoctorMedicinesUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdMedicine;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\DoctorMedicinesUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DoctorExplain;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DoctorMedicinesUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameMedicine;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DoctorMedicinesUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionMedicine;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\DoctorMedicinesUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ingredientsMedicine;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\DoctorMedicinesUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox statusMedicine;
        
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
            System.Uri resourceLocater = new System.Uri("/RefaktorisaniSims;component/doctormedicinesupdate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DoctorMedicinesUpdate.xaml"
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
            this.lvDataBinding = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            
            #line 28 "..\..\DoctorMedicinesUpdate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewApproved_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 29 "..\..\DoctorMedicinesUpdate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewWaiting_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.IdMedicine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 31 "..\..\DoctorMedicinesUpdate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DoctorExplain = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.nameMedicine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.descriptionMedicine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ingredientsMedicine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.statusMedicine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 43 "..\..\DoctorMedicinesUpdate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Select_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

