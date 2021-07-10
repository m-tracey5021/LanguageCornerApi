using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LexicalaResponse // id, text, definition, pos, aspect, sentiment, register, semantic_category, semantic_subcategory, subcategorization, range, geo, synonyms, antonyms, see, seealso
    {
        [JsonProperty("results")]  
        [JsonConverter(typeof(SingleOrArrayConverter<LCResult>))]
        public List<LCResult> Results { get; set; }


    }

}
