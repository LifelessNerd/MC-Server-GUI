using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Server_GUI
{
    public class MyUserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("gray")]
        public Color BackgroundColor
        {
            get
            {
                return ((Color)this["BackgroundColor"]);
            }
            set
            {
                this["BackgroundColor"] = (Color)value;
            }
        }
    }
}
