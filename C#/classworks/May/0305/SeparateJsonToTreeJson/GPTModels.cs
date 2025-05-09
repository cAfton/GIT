using SeparateJsonToTreeJson.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateJsonToTreeJson
{
    public class FeatureResolved
    {
        public string description { get; set; }
        public string code { get; set; }
        public List<OptionRequest> options { get; set; }
        public List<Material> materials { get; set; }
        public int default_option_idx { get; set; }
    }
    public class ResolvedProduct
    {
        public string code { get; set; }
        public int price { get; set; }
        public string manufacturer_code { get; set; }
        public int lead_time { get; set; }
        public List<ResolvedFeatureRequest> features { get; set; }
        public string description { get; set; }
    }

    public class ResolvedOption
    {
        public double add_on_price { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public List<Material> materials { get; set; }
        public List<ResolvedFeatureRequest> features { get; set; }
    }

    public class ResolvedFeatureRequest
    {
        public string description { get; set; }
        public string code { get; set; }
        public List<ResolvedOption> options { get; set; }
        public List<Material> materials { get; set; }
        public int default_option_idx { get; set; }
    }

    public class ResolvedInputJson
    {
        public ResolvedProduct product { get; set; }
        public Dictionary<string, ResolvedFeatureRequest> features { get; set; }
    }

}
