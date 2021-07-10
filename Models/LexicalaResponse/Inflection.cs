using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LanguageCornerApi
{
    public class Inflection
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("aspect")]
        public string Aspect { get; set; }

        [JsonProperty("tense")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Tenses { get; set; }

        [JsonProperty("register")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Registers { get; set; }

    }

}
