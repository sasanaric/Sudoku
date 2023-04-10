﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F2E657D2F7E2006B9213CD2E30D76A735152FAD17FDA3E034573DCE32966CAB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SudokuWPF;
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


namespace SudokuWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNewGame;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSolve;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridFilledNumbers;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelMistakes;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockMistakes;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelTime;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTime;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SudokuGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/SudokuWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.ButtonNewGame = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.ButtonNewGame.Click += new System.Windows.RoutedEventHandler(this.NewGame);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonSolve = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.ButtonSolve.Click += new System.Windows.RoutedEventHandler(this.SolveGame);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GridFilledNumbers = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.LabelMistakes = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.TextBlockMistakes = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.LabelTime = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.TextBlockTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.SudokuGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            
            #line 94 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 95 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 96 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 97 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 98 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 99 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 100 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 101 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 102 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 104 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 105 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 106 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 107 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 108 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 109 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 110 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 111 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 112 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 114 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 115 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 116 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 117 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 118 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 119 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 120 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 121 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 122 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 124 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 125 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 126 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 127 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 128 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 129 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 130 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 131 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 132 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 134 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 47:
            
            #line 135 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 48:
            
            #line 136 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 49:
            
            #line 137 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 50:
            
            #line 138 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 51:
            
            #line 139 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 52:
            
            #line 140 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 53:
            
            #line 141 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 54:
            
            #line 142 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 55:
            
            #line 144 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 56:
            
            #line 145 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 57:
            
            #line 146 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 58:
            
            #line 147 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 59:
            
            #line 148 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 60:
            
            #line 149 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 61:
            
            #line 150 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 62:
            
            #line 151 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 63:
            
            #line 152 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 64:
            
            #line 154 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 65:
            
            #line 155 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 66:
            
            #line 156 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 67:
            
            #line 157 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 68:
            
            #line 158 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 69:
            
            #line 159 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 70:
            
            #line 160 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 71:
            
            #line 161 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 72:
            
            #line 162 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 73:
            
            #line 164 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 74:
            
            #line 165 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 75:
            
            #line 166 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 76:
            
            #line 167 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 77:
            
            #line 168 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 78:
            
            #line 169 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 79:
            
            #line 170 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 80:
            
            #line 171 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 81:
            
            #line 172 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 82:
            
            #line 174 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 83:
            
            #line 175 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 84:
            
            #line 176 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 85:
            
            #line 177 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 86:
            
            #line 178 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 87:
            
            #line 179 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 88:
            
            #line 180 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 89:
            
            #line 181 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            case 90:
            
            #line 182 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.OnCellClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 9:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent;
            
            #line 59 "..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewTextInputEvent;
            
            #line 60 "..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

