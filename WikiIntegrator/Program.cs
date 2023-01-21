using System;
using WikiIntegrator.Destinators;
using WikiIntegrator.Destinators.Twitter;
using WikiIntegrator.Helpers;
using WikiIntegrator.Models;
using System.Threading;
using WikiIntegrator.Providers.Wikipedia;

namespace WikiIntegrator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[JOB] To trabalhando oo filho da puta!");
            while (true)
            {
                try
                {
                    WikipediaProvider wikiProv = new WikipediaProvider();
                    var destinator = new TwitterDestinator();

                    ProviderResult result = wikiProv.GetPhrase();

                    destinator.Send(result.Phrase, ImageHelper.DownloadImage(result.imageUrl));
                    Console.WriteLine($"[INFO] {DateTime.Now} - {result.Phrase} | img: {result.imageUrl} | ref: {result.ReferenceUrl}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Thread.Sleep(3600000);

                }
                catch (Exception e)
                {
                    if (e.Message.ToLower().Contains("index was outside the bounds of the array."))
                        continue;

                    Console.WriteLine();
                    Console.WriteLine($"[ERRO FILHO DA PUTA] Tivemos o erro abaixo, acho que vou dormir um pouco. {e.Message} - {e.StackTrace}");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
