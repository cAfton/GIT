using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateJsonToTreeJson.RequestModels
{
    public class Product
    {
        public string code { get; set; }

        public int price { get; set; }

        public string manufacturer_code { get; set; }

        public int lead_time {  get; set; }

        public List<FeatureCode> features { get; set; }

        public string description {  get; set; }

    }
}
