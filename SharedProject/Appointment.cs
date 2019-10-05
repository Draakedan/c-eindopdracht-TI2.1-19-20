using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SharedProject
{
    public class Appointment
    {
        [JsonProperty(PropertyName = "username")]
        public string username { get; set; }

        [JsonProperty(PropertyName = "day")]
        public string day { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string time { get; set; }

        public Appointment()
        { }

        public string ToJSONString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
