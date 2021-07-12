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

        public List<string> GetTranslationList(string code){
            if (Translations != null){
                return Translations.GetTranslationList(code);
            }else{
                return new List<string>();
            }
            
        }

    }

}
