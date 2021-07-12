using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class WordData
    {
        public Guid Id { get; set; }
        public List<Word> Words { get; set; }

        public WordData(){
            this.Id = Guid.NewGuid();
        }
    }

}
