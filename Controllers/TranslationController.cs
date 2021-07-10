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
        public async Task<List<Translation>> Get(string source, string target, string original)
        {

            List<Translation> translations = await GetTranslation(source, target, original);
            return translations;

        }
        public async Task<List<Translation>> GetTranslation(string source, string target, string original){

            string translationUrl = String.Format("{0}search-entries?source=global&language={1}&text={2}&morph=true&analyzed=true", apiEndpoint, source, original);

            HttpResponseMessage response = await client.GetAsync(translationUrl);
            string content = await response.Content.ReadAsStringAsync();

            LexicalaResponse LCResponse = JsonConvert.DeserializeObject<LexicalaResponse>(content);

            List<Translation> translations = new List<Translation>();
            
            foreach (LCResult result in LCResponse.Results){
                foreach (LCSense sense in result.Senses){

                    List<string> translationList = sense.Translation.GetTranslationList(target);
                    List<Word> individualTranslations = new List<Word>();

                    foreach (string word in translationList){
                        Word individualTranslation = await GetWordData(target, word);
                        individualTranslations.Add(individualTranslation);
                    }

                    Translation translation = new Translation
                    (
                        sense.Id,
                        source, 
                        target, 
                        original, 
                        individualTranslations, 
                        sense.GetExampleTextTranslations(target)
                    );
                    translations.Add(translation);
                }
            }
            
            return translations;

        }
        public async Task<Word> GetWordData(string language, string word){

            string detailsUrl = String.Format("{0}search-entries?source=global&language={1}&text={2}&morph=true&analyzed=true", apiEndpoint, language, word);

            HttpResponseMessage response = await client.GetAsync(detailsUrl);
            string content = await response.Content.ReadAsStringAsync();

            LexicalaResponse LCResponse = JsonConvert.DeserializeObject<LexicalaResponse>(content);

            // foreach (LCResult result in LCResponse.Results){

            LCResult result = LCResponse.Results[0];

            Word wordData = new Word 
            { 
                Text = word, 
                Pos = result.Headword.Pos, 
                Gender = result.Headword.Gender, 
                Tense = result.Headword.Tenses, 
                Case = result.Headword.Cases, 
                Register = result.Headword.Registers, 
                Mood = result.Headword.Moods
            };

            List<Word> inflections = new List<Word>();
            if (result.Headword.Inflections != null){
                foreach (LCInflection inflection in result.Headword.Inflections){
                    // add inflections here somehow
                }
            }
            
            List<Meaning> meanings = new List<Meaning>();
            if (result.Senses != null){
                foreach (LCSense sense in result.Senses){
                    Meaning meaning = new Meaning { Definition = sense.Definition, Sentiment = sense.Sentiment};
                    if (sense.Examples != null){
                        foreach (LCExample example in sense.Examples){
                            meaning.Examples.Add(example.Text);
                        }
                    }
                    
                    meanings.Add(meaning);
                }
            }
            
            wordData.Inflections = inflections;
            wordData.Meanings = meanings;

            return wordData; // dont iterate for now
            // }
        }
    }
}
