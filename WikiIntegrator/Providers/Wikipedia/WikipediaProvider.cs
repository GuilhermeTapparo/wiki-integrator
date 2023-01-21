using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WikiIntegrator.Helpers;
using WikiIntegrator.Models;
using WikiIntegrator.Providers.Wikipedia.Mapper;
using WikiIntegrator.Providers.Wikipedia.Models;

namespace WikiIntegrator.Providers.Wikipedia
{
    public class WikipediaProvider : IProvider
    {
        private IMapper<WikipediaContent, ProviderResult> mapper;

        public WikipediaProvider()
        {
            mapper = new WikipediaMapper();
        }

        public ProviderResult GetPhrase()
        {
            ProviderResult wikiContent;
            while (true)
            {
                string wikiPage = GetRandomPage();
                wikiContent = FetchProviderContent(wikiPage);

                int lenght = wikiContent.Phrase.Length > 240 ? 240 : wikiContent.Phrase.Length;

                string phrase = wikiContent.Phrase.Substring(0, lenght);

                if (phrase.Contains(".") && phrase.Split(".")[1].ToCharArray()[0] == ' ')
                {
                    phrase = phrase.Split(".")[0];
                }
                else {
                    continue;
                }

                if (phrase.Length > 100 && ImageHelper.isValidate(wikiContent.imageUrl) &&
                    !(phrase.ToLower().Contains("futebol") || phrase.ToLower().Contains("comuna") || phrase.ToLower().Contains("galáxia") || phrase.ToLower().Contains("estrela")))
                {
                    wikiContent.Phrase = phrase;
                    break;
                }
            }
            return wikiContent;
        }
        public ProviderResult FetchProviderContent(string url)
        {
            var client = new RestClient("https://pt.wikipedia.org/api/rest_v1/page/random/summary");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            WikipediaContent wikiResponse = JsonConvert.DeserializeObject<WikipediaContent>(response.Content);
            return mapper.Map(wikiResponse);
        }
        public string GetRandomPage()
        {
            return "https://pt.wikipedia.org/api/rest_v1/page/random/summary";
        }
        public string GetSingleSentence(WikipediaContent content)
        {
            return content.Extract;
        }
    }
}
