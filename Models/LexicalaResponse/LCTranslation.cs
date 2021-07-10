using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LCTranslation
    {
        [JsonProperty("ar")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Arabic { get; set; }

        [JsonProperty("zh")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Chinese { get; set; }

        [JsonProperty("cs")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Czech { get; set; }

        [JsonProperty("dk")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Danish { get; set; }

        [JsonProperty("nl")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Dutch { get; set; }

        [JsonProperty("en")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> English { get; set; }

        [JsonProperty("fr")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> French { get; set; }

        [JsonProperty("de")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> German { get; set; }

        [JsonProperty("el")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Greek { get; set; }

        [JsonProperty("he")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Hebrew { get; set; }

        [JsonProperty("hi")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Hindi { get; set; }

        [JsonProperty("it")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Italian { get; set; }

        [JsonProperty("ja")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Japanese { get; set; }

        [JsonProperty("ko")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Korean { get; set; }

        [JsonProperty("la")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Latin { get; set; }

        [JsonProperty("no")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Norwegian { get; set; }

        [JsonProperty("pl")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Polish { get; set; }

        [JsonProperty("pt")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Portuguese { get; set; }

        [JsonProperty("br")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> BrazilianPortuguese { get; set; }

        [JsonProperty("ru")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Russian { get; set; }

        [JsonProperty("es")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Spanish { get; set; }

        [JsonProperty("sv")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Swedish { get; set; }

        [JsonProperty("th")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Thai { get; set; }

        [JsonProperty("tr")]
        [JsonConverter(typeof(SingleOrArrayConverter<LCTranslationValue>))]
        public List<LCTranslationValue> Turkish { get; set; }

        public List<LCTranslationValue> GetTranslationValue(string code){
            if (code == "ar"){
                return Arabic;
            }else if (code == "zh"){
                return Chinese;
            }else if (code == "cs"){
                return Czech;
            }else if (code == "dk"){
                return Danish;
            }else if (code == "nl"){
                return Dutch;
            }else if (code == "en"){
                return English;
            }else if (code == "fr"){
                return French;
            }else if (code == "de"){
                return German;
            }else if (code == "el"){
                return Greek;
            }else if (code == "he"){
                return Hebrew;
            }else if (code == "hi"){
                return Hindi;
            }else if (code == "it"){
                return Italian;
            }else if (code == "ja"){
                return Japanese;
            }else if (code == "ko"){
                return Korean;
            }else if (code == "la"){
                return Latin;
            }else if (code == "no"){
                return Norwegian;
            }else if (code == "pl"){
                return Polish;
            }else if (code == "pt"){
                return Portuguese;
            }else if (code == "br"){
                return BrazilianPortuguese;
            }else if (code == "ru"){
                return Russian;
            }else if (code == "es"){
                return Spanish;
            }else if (code == "sv"){
                return Swedish;
            }else if (code == "th"){
                return Thai;
            }else if (code == "tr"){
                return Turkish;
            }else{
                throw new Exception("Code does not correspond to a supported language");
            }
        }
        public List<string> GetTranslationList(string code){

            List<LCTranslationValue> values = GetTranslationValue(code);

            List<string> translationList = new List<string>();

            foreach (LCTranslationValue value in values){
                translationList.Add(value.Text);
            }

            return translationList;
        }
    }
}
