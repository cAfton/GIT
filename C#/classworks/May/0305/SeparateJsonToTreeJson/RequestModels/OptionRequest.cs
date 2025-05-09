using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateJsonToTreeJson.RequestModels
{
    public class OptionRequest
    {
        public double add_on_price { get; set; }

        public string description { get; set; }

        public string code { get; set; }

        public List<Material> materials { get; set; }

        public List<FeatureCode> features { get; set; }

    }
}
