using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WinFormsApp1.Materials
{
    public class MyDictionary
    {

        public Dictionary<string, string> myDictionary;
        public MyDictionary() { myDictionary = new Dictionary<string, string>(); }

        public bool LoadFile(string filepath)
        {
            try
            {
                string readFromFile = File.ReadAllText(filepath);
                myDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(readFromFile, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                return true;


            }
            catch (Exception)
            {

                return false;
            }

        }

        public void SaveFile(string filepath)
        {
            string writeToFile = JsonConvert.SerializeObject(myDictionary, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            File.WriteAllText(filepath, writeToFile);
        }
    }
}
