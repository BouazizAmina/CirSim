﻿#pragma checksum "..\..\..\Controleurs\Gate_Or.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C40DD1FDE0C89D0C47AC2A1B7EE0A60E01F03A8630758DC42920C5B8412EF1E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Projet.Controleurs;
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


namespace Projet.Controleurs {
    
    
    /// <summary>
    /// Gate_Or
    /// </summary>
    public partial class Gate_Or : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Controleurs\Gate_Or.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gates;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Controleurs\Gate_Or.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.TranslateTransform tt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Controleurs\Gate_Or.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse sortie;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp6;component/controleurs/gate_or.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controleurs\Gate_Or.xaml"
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
            this.gates = ((System.Windows.Controls.Grid)(target));
            
            #line 10 "..\..\..\Controleurs\Gate_Or.xaml"
            this.gates.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Controleurs\Gate_Or.xaml"
            this.gates.MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Controleurs\Gate_Or.xaml"
            this.gates.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\Controleurs\Gate_Or.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Supprimer_Click);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Controleurs\Gate_Or.xaml"
            ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuItem_MouseEnter);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Controleurs\Gate_Or.xaml"
            ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuItem_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 14 "..\..\..\Controleurs\Gate_Or.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Copier_Click);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Controleurs\Gate_Or.xaml"
            ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuItem_MouseEnter);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Controleurs\Gate_Or.xaml"
            ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuItem_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tt = ((System.Windows.Media.TranslateTransform)(target));
            return;
            case 5:
            this.sortie = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 38 "..\..\..\Controleurs\Gate_Or.xaml"
            this.sortie.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.sortie_MouseDown);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\Controleurs\Gate_Or.xaml"
            this.sortie.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.sortie_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
