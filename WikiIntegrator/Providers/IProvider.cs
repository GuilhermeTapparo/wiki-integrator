using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WikiIntegrator.Models;

namespace WikiIntegrator.Providers
{
    public interface IProvider
    {
        ProviderResult GetPhrase();
        string GetRandomPage();
        ProviderResult FetchProviderContent(string url);
        
    }
}
