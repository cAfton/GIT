using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para1
{
    public class MyDictionary
    {
        public Dictionary<string, string> Dictionar { get; set; }

        public MyDictionary()
        {
            Dictionar = new Dictionary<string, string>();
        }

        public bool LoadFile(string filename)
        {
            try
            {
                string readFormFile = File.ReadAllText(filename);
                Dictionar = JsonConvert.DeserializeObject<Dictionary<string, string>>(readFormFile, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public void WriteToFile(string file)
        {
            string line = JsonConvert.SerializeObject(Dictionar, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            File.WriteAllText(file, line);
        }
    }
}
