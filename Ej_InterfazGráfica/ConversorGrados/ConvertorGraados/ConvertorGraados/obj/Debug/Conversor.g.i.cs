﻿#pragma checksum "..\..\Conversor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "227C2FF26EAB72472CAAD91BD54F38F3542C499708466BE4D46524C9C9C0C948"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ConvertorGraados;
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


namespace ConvertorGraados {
    
    
    /// <summary>
    /// Conversor
    /// </summary>
    public partial class Conversor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Conversor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label etGradosC;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Conversor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ctGradocC;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Conversor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label etGradosF;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Conversor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ctGradocF;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Conversor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btGradosC;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Conversor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btGradosF;
        
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
            System.Uri resourceLocater = new System.Uri("/ConvertorGraados;component/conversor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Conversor.xaml"
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
            this.etGradosC = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ctGradocC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.etGradosF = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ctGradocF = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btGradosC = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Conversor.xaml"
            this.btGradosC.Click += new System.Windows.RoutedEventHandler(this.btGradosC_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btGradosF = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Conversor.xaml"
            this.btGradosF.Click += new System.Windows.RoutedEventHandler(this.btGradosF_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

