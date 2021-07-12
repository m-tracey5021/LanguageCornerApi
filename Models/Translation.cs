using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class Translation
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public string Original { get; set; }
        public string Translated { get; set; } // comes from sense defintion
        public Translation(){
            this.Id = Guid.NewGuid();
        }
    }
}
