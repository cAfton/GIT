using Dictionary.Dictionary.Menu;
using Dictionary.Dictionary.MyDictionaries;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dictionary.Dictionary
{
    public static class ProgramMeneger
    {
        private static bool IsProgramWorking = true;
        private static string filePath = "Dictionaries.json";
        public static void Start()
        {
            Menu.Menu menu = null;
            menu = new Menu.Menu();
            if (File.Exists(filePath))
            {
                string jsonFromFile = File.ReadAllText(filePath);
                menu.Dictionaries = JsonConvert.DeserializeObject<List<MyDictionary>>(jsonFromFile, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            }

            while (IsProgramWorking == true)
            {
                menu.ProgramMenu();
                Console.ReadLine();
                Console.Clear();
            }
        }
            public static void Stop()
        {
            
            IsProgramWorking = false;
        }
    }
}
