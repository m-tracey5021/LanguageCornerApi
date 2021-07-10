using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LCHeadword
    {

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("pos")]
        public string Pos { get; set; }

        [JsonProperty("tense")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Tenses { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("case")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Cases { get; set; }

        [JsonProperty("inflections")]
        public List<LCInflection> Inflections { get; set; }

        [JsonProperty("register")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Registers { get; set; }

        [JsonProperty("mood")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Moods { get; set; }

        [JsonProperty("geographical_usage")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> GeographicalUsages { get; set; }

    

    }

}
