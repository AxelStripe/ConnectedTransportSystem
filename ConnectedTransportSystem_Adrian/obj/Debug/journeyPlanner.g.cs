﻿#pragma checksum "..\..\journeyPlanner.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C66C8621AB00E6CCFF2855AC997B4B17A5E33448"
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
    /// journeyPlanner
    /// </summary>
    public partial class journeyPlanner : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pageTitle;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboStart;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEnd;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStart;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEnd;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgSearch;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuUser;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\journeyPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuChangePw;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\journeyPlanner.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ConnectedTransportSystem_Adrian;component/journeyplanner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\journeyPlanner.xaml"
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
            this.cboStart = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\journeyPlanner.xaml"
            this.cboStart.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboStart_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboEnd = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\journeyPlanner.xaml"
            this.cboEnd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboEnd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtStart = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\journeyPlanner.xaml"
            this.txtStart.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtStart_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtEnd = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\journeyPlanner.xaml"
            this.txtEnd.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEnd_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\journeyPlanner.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.imgSearch = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\journeyPlanner.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mnuUser = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 10:
            this.mnuChangePw = ((System.Windows.Controls.MenuItem)(target));
            
            #line 58 "..\..\journeyPlanner.xaml"
            this.mnuChangePw.Click += new System.Windows.RoutedEventHandler(this.mnuChangePw_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.logOut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 63 "..\..\journeyPlanner.xaml"
            this.logOut.Click += new System.Windows.RoutedEventHandler(this.logOut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

