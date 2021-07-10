using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class Headword
    {

        // strings

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("pos")]
        public string Pos { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        // lists of strings

        [JsonProperty("case")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Case { get; set; }

        [JsonProperty("register")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Register { get; set; }

        [JsonProperty("geographical_usage")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> GeographicalUsage { get; set; }

        [JsonProperty("mood")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Mood { get; set; }

        [JsonProperty("tense")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Tense { get; set; }

        // integers

        [JsonProperty("homograph_number")]
        public int HomographNumber { get; set; }

        // lists of objects

        [JsonProperty("inflections")]
        public List<Inflection> Inflections { get; set; }

        // objects

        [JsonProperty("pronounciation")]
        public Pronounciation pronounciation { get; set; }

    }

}
