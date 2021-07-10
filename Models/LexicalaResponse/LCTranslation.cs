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




    }

}
