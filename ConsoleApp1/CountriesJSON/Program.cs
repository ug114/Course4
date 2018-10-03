using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CountriesJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = JsonConvert.DeserializeObject<Data>(System.IO.File.ReadAllText("YOUR_FILE_PATH\User.json"));

            foreach (Item item in data.Response.Items)
            {
                listBox1.Items.Add(new ListBoxItem() { Content = item });
            }

            var data = JsonConvert.DeserializeObject<List<Person>>(s);
        }
    }
}
