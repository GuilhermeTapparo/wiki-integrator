using System;
using System.Collections.Generic;
using System.Text;
using WikiIntegrator.Models;
using WikiIntegrator.Providers.Wikipedia.Models;

namespace WikiIntegrator.Providers.Wikipedia.Mapper
{
    public class WikipediaMapper : IMapper<WikipediaContent, ProviderResult>
    {
        public ProviderResult Map(WikipediaContent source)
        {
            return new ProviderResult()
            {
                Phrase = source.Extract,
                ReferenceUrl = source?.ContentUrls?.Desktop?.Page ?? "",
                imageUrl = source?.Originalimage?.Source.ToString() ?? ""

            };
        }
    }
}
