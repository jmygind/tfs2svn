﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tfs2svn.Winforms.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://my-tfs-server:8080/MyProject")]
        public string TFSUrl {
            get {
                return ((string)(this["TFSUrl"]));
            }
            set {
                this["TFSUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://my-svn-server:8443/svn/MyProject/trunk")]
        public string SVNUrl {
            get {
                return ((string)(this["SVNUrl"]));
            }
            set {
                this["SVNUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TFSUsername {
            get {
                return ((string)(this["TFSUsername"]));
            }
            set {
                this["TFSUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[MyDocuments]\\tfs2svn")]
        public string WorkingCopyPath {
            get {
                return ((string)(this["WorkingCopyPath"]));
            }
            set {
                this["WorkingCopyPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DoInitialCheckout {
            get {
                return ((bool)(this["DoInitialCheckout"]));
            }
            set {
                this["DoInitialCheckout"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>DEV\\dolsthoorn;dion</string>\r\n  <string>DEV\\kcolyar;kevin</string>\r\n</Arra" +
            "yOfString>")]
        public global::System.Collections.Specialized.StringCollection TFS2SVNUserMappings {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TFS2SVNUserMappings"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FromChangeset {
            get {
                return ((int)(this["FromChangeset"]));
            }
            set {
                this["FromChangeset"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\Colyar.SourceControl.Subversion\\libs\\svn-win32-1.4.6\\bin")]
        public string SvnBinFolder {
            get {
                return ((string)(this["SvnBinFolder"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TFSDomain {
            get {
                return ((string)(this["TFSDomain"]));
            }
            set {
                this["TFSDomain"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TFSClientProvider {
            get {
                return ((string)(this["TFSClientProvider"]));
            }
            set {
                this["TFSClientProvider"] = value;
            }
        }
    }
}
