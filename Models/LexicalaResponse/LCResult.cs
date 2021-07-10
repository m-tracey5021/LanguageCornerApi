using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LCResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("headword")]
        public Headword Headword { get; set; }

        [JsonProperty("senses")]  
        public List<Sense> Senses { get; set; }

        [JsonProperty("related_entries")]
        public List<string> RelatedEntries { get; set; }


    }

}
