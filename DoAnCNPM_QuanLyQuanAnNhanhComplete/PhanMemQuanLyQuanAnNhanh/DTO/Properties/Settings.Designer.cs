﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MMT-LEVANTHONG\\SQLEXPRE;Initial Catalog=QL_QuanAnNhanh;Integrated Sec" +
            "urity=True")]
        public string QL_QuanAnNhanhConnectionString {
            get {
                return ((string)(this["QL_QuanAnNhanhConnectionString"]));
            }
            set {
                this["QL_QuanAnNhanhConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MMT-LEVANTHONG\\SQLEXPRESS;Initial Catalog=QL_QuanAnNhanh;Integrated S" +
            "ecurity=True")]
        public string QL_QuanAnNhanhConnectionString2 {
            get {
                return ((string)(this["QL_QuanAnNhanhConnectionString2"]));
            }
            set {
                this["QL_QuanAnNhanhConnectionString2"] = value;
            }
        }
    }
}
