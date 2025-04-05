using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_RealDictionary.Models
{
    internal class LanguageDictionary
    {
        public Dictionary<string, List<string>> DictionaryLang { get; set; } = new Dictionary<string, List<string>> ();
    }
}
