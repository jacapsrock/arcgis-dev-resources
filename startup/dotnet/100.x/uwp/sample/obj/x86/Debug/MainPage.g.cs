﻿#pragma checksum "D:\ArcGIS Runtime SDK for .NET v100.1\arcgis-dev-resources\startup\dotnet\100.x\uwp\sample\sample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A4563E571EBD8F3455C3B9D73B15838E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sample
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MyMapView = (global::Esri.ArcGISRuntime.UI.Controls.MapView)(target);
                    #line 12 "..\..\..\MainPage.xaml"
                    ((global::Esri.ArcGISRuntime.UI.Controls.MapView)this.MyMapView).Loaded += this.MyMapView_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.addressTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.geocoording = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.geocoording).Click += this.geocoording_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

