﻿#pragma checksum "..\..\Create_UpdateSubjects.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BB3FE63FE17FAED2FBCF68D8F689478E10DE13DA1E70F52BAA0DA082BB3FAAA7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using _29._02._2020;


namespace _29._02._2020 {
    
    
    /// <summary>
    /// Create_UpdateSubjects
    /// </summary>
    public partial class Create_UpdateSubjects : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Create_UpdateSubjects.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Create_UpdateSpecializationLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Create_UpdateSubjects.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Create_UpdateSpecializatinTextBoxName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Create_UpdateSubjects.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Create_UpdateSpecializatinTextBoxAmounthOfHour;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Create_UpdateSubjects.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Create_UpdateSpecializatinTextBoxSpecialization_Id;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Create_UpdateSubjects.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Create_UpdateSpecializationButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Create_UpdateSubjects.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UpdateSpecializatinIDLabel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Create_UpdateSubjects.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateSpecializatinID;
        
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
            System.Uri resourceLocater = new System.Uri("/29.02.2020;component/create_updatesubjects.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Create_UpdateSubjects.xaml"
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
            this.Create_UpdateSpecializationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Create_UpdateSpecializatinTextBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Create_UpdateSpecializatinTextBoxAmounthOfHour = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Create_UpdateSpecializatinTextBoxSpecialization_Id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Create_UpdateSpecializationButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Create_UpdateSubjects.xaml"
            this.Create_UpdateSpecializationButton.Click += new System.Windows.RoutedEventHandler(this.Create_UpdateSpecializationButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpdateSpecializatinIDLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.UpdateSpecializatinID = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\Create_UpdateSubjects.xaml"
            this.UpdateSpecializatinID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.UpdateSpecializatinID_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
