using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class Word
    {
        public string Text { get; set; }
        public string Pos { get; set; }
        public string Gender { get; set; }
        public List<string> Tense { get; set; }
        public List<string> Case { get; set; }
        public List<string> Register { get; set; }
        public List<string> Mood { get; set; }
        public List<Word> Inflections { get; set; }
        public List<Meaning> Meanings { get; set; }
        
        
        public Word(){

        }
    }

}
