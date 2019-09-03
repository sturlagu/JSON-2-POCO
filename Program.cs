using System.Net;
using System;
// Provides methods for converting between .NET types and JSON types.
using Newtonsoft.Json;
namespace oppgaveGurusoft{
    public class Program{
        public static void Main(string[] args){
            json2PocoFromAPI();
        }
       
        /*  Metoden henter JSON-dataen fra API'et ved hjelp av en webtjener.
        Deretter deserialiserers JSON-dataen inn i POCO-strukturen vi har laget i
        Poco.cs. */
        public static void json2PocoFromAPI(){
            using(WebClient wc = new WebClient()){
                var json = wc.DownloadString("https://data.brreg.no/enhetsregisteret/api/enheter/991543732");
                var data = JsonConvert.DeserializeObject<RootObject>(json);
                
                // Testing
                /*
                Console.WriteLine(json);
                Console.WriteLine();
                Console.WriteLine(data.navn);
                Console.WriteLine(data._links);
                Console.WriteLine(data._links.self);
                Console.WriteLine(data._links.self.href);
                Console.WriteLine();
                Console.WriteLine(data.organisasjonsform._links.self.href);
                Console.WriteLine();
                Console.WriteLine(data.forretningsadresse.adresse[0]);
                 */
            }
        }
    }
}