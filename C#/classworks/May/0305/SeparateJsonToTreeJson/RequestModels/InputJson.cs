using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateJsonToTreeJson.RequestModels
{
    public class InputJson
    {
        public Product product {  get; set; }

        public Dictionary<string, FeatureRequest> features { get; set; }
    }
}
