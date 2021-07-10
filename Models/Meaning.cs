using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class Meaning
    {
        public string Definition { get; set; }
        public List<string> Sentiment { get; set; }
        public List<string> Examples { get; set; }
        public Meaning(){
            this.Sentiment = new List<string>();
            this.Examples = new List<string>();
        }
    }

}
