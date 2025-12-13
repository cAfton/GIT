using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Main_class
{
    public class AppConfig
    {
        private static AppConfig _instance;
        private Dictionary<string, string> config;
        private AppConfig()
        {
            config = new Dictionary<string, string>();
        }
        public static AppConfig Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppConfig();
                return _instance;
            }
        }
        public void SetSetting(string key, string value) 
        {
            config[key] = value;
        }
        public string GetSetting(string key)
        {
            return config[key];
        }
    }
}
