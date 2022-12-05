using System;
using System.Collections.Generic;
using System.Text;

namespace YamlTesting
{
    class Settings
    {
        public bool Use_Flash = true;
        public enum FlashTypeEnum { Global, local };
        public FlashTypeEnum Flash_Type = FlashTypeEnum.Global;
        public double Flash_Margin = 0.5;
        public double Target_Margin = 0.5;
        public bool Test = true;
        
    }



}
