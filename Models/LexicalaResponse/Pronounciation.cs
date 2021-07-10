using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class Pronounciation
    {
        [JsonProperty("value")]
        public string Value { get; set; }

    }

}
