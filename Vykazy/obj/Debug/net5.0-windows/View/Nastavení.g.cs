#pragma checksum "..\..\..\..\View\Nastavení.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40796B8671BE6871C072746B723FD25C101B4766"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Vykazy.View;


namespace Vykazy.View {
    
    
    /// <summary>
    /// Nastavení
    /// </summary>
    public partial class Nastavení : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\View\Nastavení.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Jmeno;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\Nastavení.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Text1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\Nastavení.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Text2;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\Nastavení.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Ulozit;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\Nastavení.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Nahrat;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\Nastavení.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Vymazat;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\Nastavení.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Nastaveni;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vykazy;component/view/nastaven%c3%ad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Nastavení.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TB_Jmeno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TB_Text1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TB_Text2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_Ulozit = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\View\Nastavení.xaml"
            this.btn_Ulozit.Click += new System.Windows.RoutedEventHandler(this.btn_Ulozit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Nahrat = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\View\Nastavení.xaml"
            this.btn_Nahrat.Click += new System.Windows.RoutedEventHandler(this.btn_Nahrat_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Vymazat = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\View\Nastavení.xaml"
            this.btn_Vymazat.Click += new System.Windows.RoutedEventHandler(this.btn_Vymazat_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Nastaveni = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\View\Nastavení.xaml"
            this.btn_Nastaveni.Click += new System.Windows.RoutedEventHandler(this.btn_Nastaveni_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

