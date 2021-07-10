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
        public async Task<Translation> Get(string source, string target, string original)
        {
            
            LexicalaResponse LCResponse = await GetTranslation(source, target, original);
            Translation translation = new Translation();
            translation.Inflections.Add("hello", "ola");
            return translation;
        }
        public async Task<LexicalaResponse> GetTranslation(string source, string target, string original){
            string translationUrl = String.Format("{0}search-entries?source=global&language={1}&text={2}&morph=true&analyzed=true", apiEndpoint, source, original);
            HttpResponseMessage response = await client.GetAsync(translationUrl);
            string content = await response.Content.ReadAsStringAsync();
            LexicalaResponse LCResponse = JsonConvert.DeserializeObject<LexicalaResponse>(content);
            return LCResponse;

        }
        public async Task GetTranslationDetails(){

        }
    }
}
