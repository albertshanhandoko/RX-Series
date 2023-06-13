using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerPage.Library
{
    public class SQL_Data_Setting
    {
        // public int Config_Id { get; set; }
        public string Config_Param { get; set; }
        public string Config_Value { get; set; }

        public void set(string set_Config_Param, string set_Config_Value)
        {
            //     Config_Id = set_Config_Id;
            Config_Param = set_Config_Param;
            Config_Value = set_Config_Value;

        }
        public SQL_Data_Setting(string Config_Param, string Config_Value)
        {
            set(Config_Param, Config_Value);
        }

    }
}
