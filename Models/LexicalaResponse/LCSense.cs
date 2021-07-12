using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LCSense // id, text, definition, pos, aspect, sentiment, register, semantic_category, semantic_subcategory, subcategorization, range, geo, synonyms, antonyms, see, seealso
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("inflections")]  
        public List<LCInflection> Inflections { get; set; }

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

        [JsonProperty("subcategorization")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Subcategorization { get; set; }

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

        [JsonProperty("compositional_phrases")]  
        public List<LCCompositionalPhrase> CompositionalPhrases { get; set; }

        [JsonProperty("translations")]
        public LCTranslation Translation { get; set; }

        [JsonProperty("see")]
        public string See { get; set; }

        [JsonProperty("see_also")]  
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> SeeAlso { get; set; }

        public List<string> GetExampleTextTranslations(string code){

            List<string> exampleTexts = new List<string>();

            foreach (LCExample example in Examples){

                if (example.Translations != null){
                    List<string> translations = example.Translations.GetTranslationList(code);
                    exampleTexts.AddRange(translations);
                }
            }

            return exampleTexts;
        }
        
        public List<string> GetIndividualTranslations(string code){
            return Translation.GetTranslationList(code);
        }

        public Dictionary<string, List<string>> GetExampleTranslations(string code){
            Dictionary<string, List<string>> exampleTranslations = new Dictionary<string, List<string>>();
            foreach (LCExample example in Examples){
                exampleTranslations.Add(example.Text, example.GetTranslationList(code));
            }
            return exampleTranslations;
        }
    }

    

}
