﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inSSIDer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string gpsSerialPort {
            get {
                return ((string)(this["gpsSerialPort"]));
            }
            set {
                this["gpsSerialPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.IO.Ports.Parity gpsParity {
            get {
                return ((global::System.IO.Ports.Parity)(this["gpsParity"]));
            }
            set {
                this["gpsParity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.IO.Ports.Handshake gpsHandshake {
            get {
                return ((global::System.IO.Ports.Handshake)(this["gpsHandshake"]));
            }
            set {
                this["gpsHandshake"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("One")]
        public global::System.IO.Ports.StopBits gpsStopBits {
            get {
                return ((global::System.IO.Ports.StopBits)(this["gpsStopBits"]));
            }
            set {
                this["gpsStopBits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int gpsDataBits {
            get {
                return ((int)(this["gpsDataBits"]));
            }
            set {
                this["gpsDataBits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4800")]
        public int gpsBaud {
            get {
                return ((int)(this["gpsBaud"]));
            }
            set {
                this["gpsBaud"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool gpsEnabled {
            get {
                return ((bool)(this["gpsEnabled"]));
            }
            set {
                this["gpsEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1, -1")]
        public global::System.Drawing.Point formLocation {
            get {
                return ((global::System.Drawing.Point)(this["formLocation"]));
            }
            set {
                this["formLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1024, 600")]
        public global::System.Drawing.Size formSize {
            get {
                return ((global::System.Drawing.Size)(this["formSize"]));
            }
            set {
                this["formSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState formWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["formWindowState"]));
            }
            set {
                this["formWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string gridOrder {
            get {
                return ((string)(this["gridOrder"]));
            }
            set {
                this["gridOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string lastFilters {
            get {
                return ((string)(this["lastFilters"]));
            }
            set {
                this["lastFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2010-08-01")]
        public global::System.DateTime VersionNextUpdateCheck {
            get {
                return ((global::System.DateTime)(this["VersionNextUpdateCheck"]));
            }
            set {
                this["VersionNextUpdateCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0.0.0")]
        public string VersionIgnoreThisVersion {
            get {
                return ((string)(this["VersionIgnoreThisVersion"]));
            }
            set {
                this["VersionIgnoreThisVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int VersionDaysBetweenUpdateReminders {
            get {
                return ((int)(this["VersionDaysBetweenUpdateReminders"]));
            }
            set {
                this["VersionDaysBetweenUpdateReminders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("inssider2")]
        public string AnalyticsMedium {
            get {
                return ((string)(this["AnalyticsMedium"]));
            }
            set {
                this["AnalyticsMedium"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool lastMini {
            get {
                return ((bool)(this["lastMini"]));
            }
            set {
                this["lastMini"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1, -1")]
        public global::System.Drawing.Size miniSize {
            get {
                return ((global::System.Drawing.Size)(this["miniSize"]));
            }
            set {
                this["miniSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("536, 300")]
        public global::System.Drawing.Point miniLocation {
            get {
                return ((global::System.Drawing.Point)(this["miniLocation"]));
            }
            set {
                this["miniLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState miniWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["miniWindowState"]));
            }
            set {
                this["miniWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string miniGridOrder {
            get {
                return ((string)(this["miniGridOrder"]));
            }
            set {
                this["miniGridOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int formTabIndex {
            get {
                return ((int)(this["formTabIndex"]));
            }
            set {
                this["formTabIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OK")]
        public string settingsTest {
            get {
                return ((string)(this["settingsTest"]));
            }
            set {
                this["settingsTest"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection gpxLastInputFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["gpxLastInputFiles"]));
            }
            set {
                this["gpxLastInputFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string gpxLastOutputDir {
            get {
                return ((string)(this["gpxLastOutputDir"]));
            }
            set {
                this["gpxLastOutputDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gpxLastGpsLockedup {
            get {
                return ((bool)(this["gpxLastGpsLockedup"]));
            }
            set {
                this["gpxLastGpsLockedup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gpxLastGpsFixLost {
            get {
                return ((bool)(this["gpxLastGpsFixLost"]));
            }
            set {
                this["gpxLastGpsFixLost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int gpxLastMinimumStas {
            get {
                return ((int)(this["gpxLastMinimumStas"]));
            }
            set {
                this["gpxLastMinimumStas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gpxLastMinimumSatsEnabled {
            get {
                return ((bool)(this["gpxLastMinimumSatsEnabled"]));
            }
            set {
                this["gpxLastMinimumSatsEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("70")]
        public int gpxLastMaxSpeed {
            get {
                return ((int)(this["gpxLastMaxSpeed"]));
            }
            set {
                this["gpxLastMaxSpeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool gpxLastMaxSpeedEnabled {
            get {
                return ((bool)(this["gpxLastMaxSpeedEnabled"]));
            }
            set {
                this["gpxLastMaxSpeedEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-20")]
        public int gpxLastMaxRssi {
            get {
                return ((int)(this["gpxLastMaxRssi"]));
            }
            set {
                this["gpxLastMaxRssi"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gpxLastMaxRssiEnabled {
            get {
                return ((bool)(this["gpxLastMaxRssiEnabled"]));
            }
            set {
                this["gpxLastMaxRssiEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool gpxLastRssiLabels {
            get {
                return ((bool)(this["gpxLastRssiLabels"]));
            }
            set {
                this["gpxLastRssiLabels"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gpxLastOrganizeEThenC {
            get {
                return ((bool)(this["gpxLastOrganizeEThenC"]));
            }
            set {
                this["gpxLastOrganizeEThenC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gpxLastSummary {
            get {
                return ((bool)(this["gpxLastSummary"]));
            }
            set {
                this["gpxLastSummary"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool gpxLastEachAp {
            get {
                return ((bool)(this["gpxLastEachAp"]));
            }
            set {
                this["gpxLastEachAp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool gpxLastComprehensive {
            get {
                return ((bool)(this["gpxLastComprehensive"]));
            }
            set {
                this["gpxLastComprehensive"] = value;
            }
        }
    }
}