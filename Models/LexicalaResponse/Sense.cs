using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class Sense // id, text, definition, pos, aspect, sentiment, register, semantic_category, semantic_subcategory, subcategorization, range, geo, synonyms, antonyms, see, seealso
    {

        // strings
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("see")]
        public string See { get; set; }

        // lists of strings

        [JsonProperty("semantic_category")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> SemanticCategory { get; set; }

        [JsonProperty("semantic_subcategory")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> SemanticSubcategory { get; set; }

        [JsonProperty("register")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Register { get; set; }

        [JsonProperty("sentiment")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Sentiment { get; set; }

        [JsonProperty("geographical_usage")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> GeographcialUsage { get; set; }

        [JsonProperty("range_of_application")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> RangeOfApplication { get; set; }

        [JsonProperty("subcategorization")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Subcategorization { get; set; }

        [JsonProperty("synonyms")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Synonyms { get; set; }

        [JsonProperty("antonyms")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Antonyms { get; set; }

        [JsonProperty("see_also")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> SeeAlso { get; set; }

        // arrays

        [JsonProperty("examples")]  
        public List<Example> Examples { get; set; }

        // [JsonProperty("compositional_phrases")]  
        // public List<CompositionalPhrase> CompositionalPhrases { get; set; }

        [JsonProperty("inflections")]  
        public List<Inflection> Inflections { get; set; }

        [JsonProperty("senses")]  
        public List<Sense> Senses { get; set; }

        // objects

        [JsonProperty("translations")]
        public LCTranslation Translation { get; set; }

    }

}
