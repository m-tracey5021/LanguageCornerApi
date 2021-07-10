using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LanguageCornerApi
{
    public class LexicalaResponse
    {
        [JsonProperty("results")]  
        [JsonConverter(typeof(SingleOrArrayConverter<LCResult>))]
        public List<LCResult> Results { get; set; }


    }

}
