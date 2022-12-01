using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Server_GUI
{
    public class MyUserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public string FirstStartup
        {
            get
            {
                return ((string)this["FirstStartup"]);
            }
            set
            {
                this["FirstStartup"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public string DarkMode
        {
            get
            {
                return ((string)this["DarkMode"]);
            }
            set
            {
                this["DarkMode"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string ServerPath
        {
            get
            {
                return ((String)this["ServerPath"]);
            }
            set
            {
                this["ServerPath"] = (string)value;
            }
        }

        
    }
}
