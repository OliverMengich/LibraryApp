﻿#pragma checksum "C:\Users\olive\source\repos\LibraryApp\LibraryApp\CustomerSignUp.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "716AE7630D30935CE6A48E7676AE56A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp
{
    partial class CustomerSignUp : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // CustomerSignUp.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).SecondaryButtonClick += this.ContentDialog_SecondaryButtonClick;
                }
                break;
            case 2: // CustomerSignUp.xaml line 27
                {
                    this.Selected1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // CustomerSignUp.xaml line 45
                {
                    this.Selected2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // CustomerSignUp.xaml line 72
                {
                    this.Selected3 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // CustomerSignUp.xaml line 42
                {
                    this.emailIdBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // CustomerSignUp.xaml line 38
                {
                    this.otherNameIdBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // CustomerSignUp.xaml line 34
                {
                    this.surNameIdBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // CustomerSignUp.xaml line 30
                {
                    this.customerIdBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // CustomerSignUp.xaml line 19
                {
                    this.accountComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.accountComboBox).SelectionChanged += this.accountComboBox_SelectionChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

