using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dictionary
{
    public static class ProgramMeneger
    {
        private static bool IsProgramWorking = true;
        public static void Start()
        {
            string jsonFromFile = File.ReadAllText("Dictionaries.json");
            Menu.Menu menu = JsonConvert.DeserializeObject<Menu.Menu>(jsonFromFile);

            while (IsProgramWorking == true)
            {
                menu.ProgramMenu();
            }
        }
        public static void Stop()
        {
            IsProgramWorking = false;
        }
    }
}
