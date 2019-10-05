using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SharedProject
{
    public class TimeData
    {
        [JsonProperty(PropertyName = "day")]
        public string day { get; set; }

        [JsonProperty(PropertyName = "times")]
        public List<string> times { get; set; }

        public TimeData()
        {
            times = new List<string>();
        }

        public string ToJSONString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
