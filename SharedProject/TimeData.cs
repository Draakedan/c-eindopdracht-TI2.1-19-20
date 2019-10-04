﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SharedProject
{
    class TimeData
    {
        public string day { get; set; }
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
