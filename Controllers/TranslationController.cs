using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace LanguageCornerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TranslationController : ControllerBase
    {

        private string apiEndpoint = "https://dictapi.lexicala.com/";
        private readonly string apiUsername = "m.tracey5021@gmail.com";
        private readonly string apiPass = "y_W0rd53cUr!t";
        private HttpClient client;

        public TranslationController()
        {

            Byte[] bytes = Encoding.ASCII.GetBytes(apiUsername + ":" + apiPass);
            client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(bytes));
        }

        [HttpGet]
        [Route("translate/{source}/{target}/{original}")]
        public async Task<WordData> Get(string source, string target, string original)
        {

            // List<Translation> translations = await GetTranslation(source, target, original);
            // return translations;

            List<Word> translations = await GetTranslation(source, target, original);
            WordData data = new WordData { Words = translations };
            return data;

        }
        public async Task<List<Word>> GetTranslation(string source, string target, string original){

            string translationUrl = String.Format("{0}search-entries?source=global&language={1}&text={2}&morph=true&analyzed=true", apiEndpoint, source, original);

            HttpResponseMessage response = await client.GetAsync(translationUrl);
            string content = await response.Content.ReadAsStringAsync();

            LexicalaResponse LCResponse = JsonConvert.DeserializeObject<LexicalaResponse>(content);

            // List<Translation> translations = new List<Translation>();
            // List<string> headwords = new List<string>();
            
            // foreach (LCResult result in LCResponse.Results){

            //     if (!headwords.Contains(result.Headword.Text)){ // make sure not to make calls for duplicates
            //         headwords.Add(result.Headword.Text);
            //         foreach (LCSense sense in result.Senses){

            //             List<string> translationList = sense.Translation.GetTranslationList(target);
            //             List<Word> individualTranslations = new List<Word>();

            //             foreach (string word in translationList){
            //                 Word individualTranslation = await GetWordData(target, word);
            //                 individualTranslations.Add(individualTranslation);
            //             }

            //             Translation translation = new Translation
            //             (
            //                 sense.Id,
            //                 source, 
            //                 target, 
            //                 result.Headword.Text, 
            //                 individualTranslations, 
            //                 sense.GetExampleTextTranslations(target)
            //             );
            //             translations.Add(translation);
            //         }
            //     }
            // }

            List<Word> words = new List<Word>();

            foreach (LCResult result in LCResponse.Results){

                Word word = new Word { Text = result.Headword.Text, Language = source };

                foreach (LCSense sense in result.Senses){

                    Definition definition = new Definition { Text = sense.Definition, LCId = sense.Id };

                    List<string> individualTranslationList = sense.GetIndividualTranslations(target);
                    Dictionary<string, List<string>> exampleTranslationList = sense.GetExampleTranslations(target);

                    foreach (string individualTranslation in individualTranslationList){

                        definition.TranslatedWords.Add(new Translation 
                        { 
                            Source = source, 
                            Target = target, 
                            Original = original, 
                            Translated = individualTranslation
                        });
                    }

                    foreach (KeyValuePair<string, List<string>> exampleTranslation in exampleTranslationList){

                        definition.TranslatedPhrases.Add(new Phrase 
                        {
                            Text = exampleTranslation.Key,
                            Translations = exampleTranslation.Value.Select((translation, index) => new Translation 
                                {  
                                    Source = source,
                                    Target = target,
                                    Original = exampleTranslation.Key,
                                    Translated = translation
                                })
                                .ToList()
                        });
                    }

                    word.Definitions.Add(definition);
                    
                }

                words.Add(word);

            }
            
            return words;

        }
        public async Task<Word> GetWordData(string language, string word){

            string detailsUrl = String.Format("{0}search-entries?source=global&language={1}&text={2}&morph=true&analyzed=true", apiEndpoint, language, word);

            HttpResponseMessage response = await client.GetAsync(detailsUrl);
            string content = await response.Content.ReadAsStringAsync();

            LexicalaResponse LCResponse = JsonConvert.DeserializeObject<LexicalaResponse>(content);

            return new Word();

            // LCResult result = LCResponse.Results[0];

            // Word wordData = new Word 
            // { 
            //     Text = word, 
            //     Pos = result.Headword.Pos, 
            //     Gender = result.Headword.Gender, 
            //     Tense = result.Headword.Tenses, 
            //     Case = result.Headword.Cases, 
            //     Register = result.Headword.Registers, 
            //     Mood = result.Headword.Moods
            // };

            // List<Word> inflections = new List<Word>();
            // if (result.Headword.Inflections != null){
            //     foreach (LCInflection inflection in result.Headword.Inflections){
            //         // add inflections here somehow
            //     }
            // }
            
            // List<Meaning> meanings = new List<Meaning>();
            // if (result.Senses != null){
            //     foreach (LCSense sense in result.Senses){
            //         Meaning meaning = new Meaning { Definition = sense.Definition, Sentiment = sense.Sentiment};
            //         if (sense.Examples != null){
            //             foreach (LCExample example in sense.Examples){
            //                 meaning.Examples.Add(example.Text);
            //             }
            //         }
                    
            //         meanings.Add(meaning);
            //     }
            // }
            
            // wordData.Inflections = inflections;
            // wordData.Meanings = meanings;

            // return wordData; // dont iterate for now
            
        }
    }
}
