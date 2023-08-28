using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{
    public class PolicySerializer
    {
        public Policy GetPolicyFromJsonString(string JsonStr)
        {
            return JsonConvert.DeserializeObject<Policy>(JsonStr,
                new StringEnumConverter()); 
        }
    }
}
