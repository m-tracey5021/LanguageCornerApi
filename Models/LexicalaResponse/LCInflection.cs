using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LCInflection
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("tense")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Tenses { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("case")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Cases { get; set; }

        [JsonProperty("aspect")]
        public string Aspect { get; set; }

        [JsonProperty("register")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Registers { get; set; }

        [JsonProperty("mood")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Moods { get; set; }

        [JsonProperty("subcategorization")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Subcategorizations { get; set; }

    }

}
