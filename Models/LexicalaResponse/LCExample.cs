using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LCExample
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("translations")]
        public LCTranslation Translations { get; set; }

    }

}
