using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CountriesJSON
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var s = @"[{""name"":""Ivan"",""age"":10},{""name"":""Petr"",""age"":30}]"; 
            //var persons = JsonConvert.DeserializeObject<List<Person>>(s);
            //Console.WriteLine(persons[0].Name);
            //string s = File.ReadAllText(@"C:\Users\user\Source\Repos\Course4\CountriesJSON\americas.json");
            //Console.WriteLine(s);
            var countries = JsonConvert.DeserializeObject<List<Country>>(File.ReadAllText(@"C:\Users\Ug114\Source\repos\Course4\CountriesJSON\americas.json").Replace("[", "").Replace("]", ""));
        }
    }
}
