using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateJsonToTreeJson.RequestModels
{
    public class FeatureRequest
    {
        public string description { get; set; }

        public string code { get; set; }

        public List<OptionRequest> options { get; set; }

        public List<Material> materials { get; set; }

        public int default_option_idx { get; set; }
    }
}
