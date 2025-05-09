
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateJsonToTreeJson
{
    public class GPTAnswer
    {
        public static class FeatureResolver
        {
            public static ResolvedInputJson ResolveFeatures(RequestModels.InputJson input)
            {
                var resolvedFeatures = new Dictionary<string, ResolvedFeatureRequest>();

                foreach (var kvp in input.features)
                {
                    resolvedFeatures[kvp.Key] = new ResolvedFeatureRequest
                    {
                        code = kvp.Value.code,
                        description = kvp.Value.description,
                        materials = kvp.Value.materials,
                        default_option_idx = kvp.Value.default_option_idx,
                        options = kvp.Value.options?.Select(o => new ResolvedOption{
                            code = o.code,
                            description = o.description,
                            add_on_price = o.add_on_price,
                            materials = o.materials,
                            features = o.features?.Select(f => resolvedFeatures.ContainsKey(f.code) ? resolvedFeatures[f.code] : ResolveFeature(input.features, f.code)).ToList()
                        }).ToList()
                    };
                }

                return new ResolvedInputJson
                {
                    product = new ResolvedProduct
                    {
                        code = input.product.code,
                        price = input.product.price,
                        manufacturer_code = input.product.manufacturer_code,
                        lead_time = input.product.lead_time,
                        description = input.product.description,
                        features = input.product.features?.Select(f => resolvedFeatures.ContainsKey(f.code) ? resolvedFeatures[f.code] : ResolveFeature(input.features, f.code)).ToList()
                    },
                    features = resolvedFeatures
                };
            }

            private static ResolvedFeatureRequest ResolveFeature(Dictionary<string, RequestModels.FeatureRequest> featureDict, string code)
            {
                if (!featureDict.ContainsKey(code)) return null;

                var feature = featureDict[code];

                return new ResolvedFeatureRequest
                {
                    code = feature.code,
                    description = feature.description,
                    materials = feature.materials,
                    default_option_idx = feature.default_option_idx,
                    options = feature.options?.Select(o => new ResolvedOption
                    {
                        code = o.code,
                        description = o.description,
                        add_on_price = o.add_on_price,
                        materials = o.materials,
                        features = o.features?.Select(f => ResolveFeature(featureDict, f.code)).ToList()
                    }).ToList()
                };
            }
        }

    }
}
