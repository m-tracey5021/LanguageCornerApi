using System;
using System.Collections.Generic;

namespace LanguageCornerApi
{
    public class Translation
    {
        public Guid Id { get; set; }
        public string LCId {get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public string Original { get; set; }
        public List<Word> Translations { get; set; }
        public List<string> ExampleTexts { get; set; }

        public Translation(){

        }
        public Translation(string LCId, string source, string target, string original){
            this.Id = Guid.NewGuid();
            this.LCId = LCId;
            this.Source = source;
            this.Target = target;
            this.Original = original;
            this.Translations = new List<Word>();
            this.ExampleTexts = new List<string>();
        }
        public Translation(string LCId, string source, string target, string original, List<Word> translations, List<string> exampleTexts){
            this.Id = Guid.NewGuid();
            this.LCId = LCId;
            this.Source = source;
            this.Target = target;
            this.Original = original;
            this.Translations = translations;
            this.ExampleTexts = exampleTexts;
        }
    }

}
