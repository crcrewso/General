using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TOML_Testing
{
    public class Config
    {
        public bool Use_Flash = true;
        public enum FlashTypeEnum {Global, local };
        public FlashTypeEnum Flash_Type = FlashTypeEnum.Global;
        public double Flash_Margin = 0.5;
        public double Target_Margin = 0.5;
        public bool Test = true;


        public Config()
        {

        }

        /// <summary>
        /// Only valid if file is toml file
        /// </summary>
        /// <param name="file"></param>
        public Config (string file)
        {

            throw new NotImplementedException();
        }

        public void Load()
        {
            var appSettings = ConfigurationManager.AppSettings;
            Use_Flash = Boolean.Parse(appSettings["Use_Flash"]);
            Enum.TryParse(appSettings["Flash_Type"], out Flash_Type);
            Flash_Margin = Double.Parse(appSettings["Flash_Margin"]);
        }

        public void Save()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Use_Flash"].Value = Use_Flash.ToString();
            config.AppSettings.Settings["Flash_Type"].Value = Flash_Type.ToString();
            config.AppSettings.Settings["Test"].Value = Test.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
