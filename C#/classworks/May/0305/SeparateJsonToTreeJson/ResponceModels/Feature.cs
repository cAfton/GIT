using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateJsonToTreeJson.ResponceModels
{
    public class Feature
    {
        public string description { get; set; }

        public string code { get; set; }

        public List<Option> options { get; set; }

        public List<Material> materials { get; set; }

        public int default_option_idx { get; set; }
    }
}
