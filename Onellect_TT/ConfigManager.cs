using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Onellect_TT
{
    public class ConfigManager
    {
        const string FILE_NAME = "config.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConfigData));


        private string ConfigPath { get => Path.Combine(Environment.CurrentDirectory, FILE_NAME); }

        public bool ConfigExists
        {
            get
            {
                return File.Exists(ConfigPath);
            }
        }

        public bool TryGetConfigData(out ConfigData data)
        {
            data = new ConfigData();

            var configExists = ConfigExists;

            using (FileStream fs = new FileStream(ConfigPath, FileMode.OpenOrCreate))
            {
                data = (ConfigData)xmlSerializer.Deserialize(fs);
            }
            return configExists;
        }
    }
}
