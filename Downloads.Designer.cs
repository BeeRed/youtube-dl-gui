﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace youtube_dl_gui {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Downloads : global::System.Configuration.ApplicationSettingsBase {
        
        private static Downloads defaultInstance = ((Downloads)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Downloads())));
        
        public static Downloads Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string downloadPath {
            get {
                return ((string)(this["downloadPath"]));
            }
            set {
                this["downloadPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool separateDownloads {
            get {
                return ((bool)(this["separateDownloads"]));
            }
            set {
                this["separateDownloads"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool saveParams {
            get {
                return ((bool)(this["saveParams"]));
            }
            set {
                this["saveParams"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool deleteYtdlOnClose {
            get {
                return ((bool)(this["deleteYtdlOnClose"]));
            }
            set {
                this["deleteYtdlOnClose"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useYtdlUpdater {
            get {
                return ((bool)(this["useYtdlUpdater"]));
            }
            set {
                this["useYtdlUpdater"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%(title)s-%(id)s.%(ext)s")]
        public string fileNameSchema {
            get {
                return ((string)(this["fileNameSchema"]));
            }
            set {
                this["fileNameSchema"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool fixReddit {
            get {
                return ((bool)(this["fixReddit"]));
            }
            set {
                this["fixReddit"] = value;
            }
        }
    }
}