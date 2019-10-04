using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SharedProject
{
    class DayData
    {
        [JsonProperty(PropertyName ="times")]
        public List<TimeData> times { get; set; }

        public DayData()
        {
            times = new List<TimeData>();
        }

        public string ToJSONString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
