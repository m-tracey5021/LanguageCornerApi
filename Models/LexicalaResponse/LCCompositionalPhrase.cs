using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LCCompositionalPhrase // id, text, definition, pos, aspect, sentiment, register, semantic_category, semantic_subcategory, subcategorization, range, geo, synonyms, antonyms, see, seealso
    {

        [JsonProperty("text")]
        public string Id { get; set; }

        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("pos")]
        public string Pos { get; set; }

        [JsonProperty("aspect")]
        public string Aspect { get; set; }

        [JsonProperty("register")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Register { get; set; }

        [JsonProperty("sentiment")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Sentiment { get; set; }

        [JsonProperty("semantic_category")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> SemanticCategory { get; set; }

        [JsonProperty("semantic_subcategory")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> SemanticSubcategory { get; set; }

        [JsonProperty("range_of_application")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> RangeOfApplication { get; set; }

        [JsonProperty("geographical_usage")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> GeographcialUsage { get; set; }

        [JsonProperty("synonyms")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Synonyms { get; set; }

        [JsonProperty("antonyms")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Antonyms { get; set; }

        [JsonProperty("examples")]  
        public List<LCExample> Examples { get; set; }

        [JsonProperty("senses")]  
        public List<LCSense> Senses { get; set; }

        [JsonProperty("translations")]
        public LCTranslation Translation { get; set; }

    }

}
