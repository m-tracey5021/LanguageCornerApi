using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LCTranslationValue
    {
        [JsonProperty("text")]
        public string Text { get; set; }


    }

}
