using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class Translation
    {
        public string Original { get; set; }

        public string Translated { get; set; }

        public string Pos { get; set; }

        public Dictionary<string, string> Inflections { get; set; }

        public Translation(){
            Inflections = new Dictionary<string, string>();
        }
    }

}
