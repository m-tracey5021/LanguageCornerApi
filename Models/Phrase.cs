using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class Phrase
    {
        public Guid Id { get; set; }
        public string Text { get; set; } // comes from sense defintion
        public List<Translation> Translations { get; set; } // comes from sense translations
        public Phrase(){
            this.Id = Guid.NewGuid();
            this.Translations = new List<Translation>();
        }
    }

}
