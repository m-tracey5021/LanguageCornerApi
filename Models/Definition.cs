using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class Definition
    {
        public Guid Id { get; set; }
        public string LCId { get; set; }
        public string Text { get; set; } // comes from sense defintion
        public List<Translation> TranslatedWords { get; set; } // comes from sense translations
        public List<Phrase> TranslatedPhrases { get; set; } // example in source and target
        public Definition(){
            this.Id = Guid.NewGuid();
            this.TranslatedWords = new List<Translation>();
            this.TranslatedPhrases = new List<Phrase>();
        }
    }

}
