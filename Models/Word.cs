using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class Word
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Language { get; set; }
        public List<Definition> Definitions { get; set; } // many definitions

        public Word(){
            this.Id = Guid.NewGuid();
            this.Definitions = new List<Definition>();
        }
    }

}
