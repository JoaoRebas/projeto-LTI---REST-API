﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI_App
{
    public class Duration
    {
        [JsonProperty("second")]
        public long Second { get; set; }

        [JsonProperty("nanosecond")]
        public long Nanosecond { get; set; }
    }
}
