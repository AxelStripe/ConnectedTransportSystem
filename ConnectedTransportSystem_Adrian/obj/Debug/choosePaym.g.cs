﻿#pragma checksum "..\..\choosePaym.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "225147645436BE21E210D38AAF0616DDF56CC25D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ConnectedTransportSystem_Adrian;
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


namespace ConnectedTransportSystem_Adrian {
    
    
    /// <summary>
    /// choosePaym
    /// </summary>
    public partial class choosePaym : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\choosePaym.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pageTitle;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\choosePaym.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCash;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\choosePaym.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCard;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\choosePaym.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPayPal;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\choosePaym.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\choosePaym.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuUser;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\choosePaym.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuChangePw;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\choosePaym.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem logOut;
        
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
            System.Uri resourceLocater = new System.Uri("/ConnectedTransportSystem_Adrian;component/choosepaym.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\choosePaym.xaml"
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
            this.pageTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnCash = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\choosePaym.xaml"
            this.btnCash.Click += new System.Windows.RoutedEventHandler(this.btnCash_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCard = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\choosePaym.xaml"
            this.btnCard.Click += new System.Windows.RoutedEventHandler(this.btnCard_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnPayPal = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\choosePaym.xaml"
            this.btnPayPal.Click += new System.Windows.RoutedEventHandler(this.btnPayPal_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\choosePaym.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mnuUser = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 7:
            this.mnuChangePw = ((System.Windows.Controls.MenuItem)(target));
            
            #line 46 "..\..\choosePaym.xaml"
            this.mnuChangePw.Click += new System.Windows.RoutedEventHandler(this.mnuChangePw_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.logOut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 51 "..\..\choosePaym.xaml"
            this.logOut.Click += new System.Windows.RoutedEventHandler(this.logOut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

