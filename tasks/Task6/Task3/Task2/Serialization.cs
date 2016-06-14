using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



namespace Task4
{
    class Serialization
    {
        public static void Run(IUnterkunft[] items)
        { 

            // 1. serialize a single unterkunft to a JSON string 
            //Console.WriteLine(JsonConvert.SerializeObject(items));


            // 2. ... with nicer formatting 
            //Console.WriteLine(JsonConvert.SerializeObject(items, Formatting.Indented));


            // 3. serialize all items 
            // ... include type, so we can deserialize sub-classes to interface type 
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            //Console.WriteLine(JsonConvert.SerializeObject(items, settings));


            // 4. store json string to file "items.json" on your Desktop 
            var text = JsonConvert.SerializeObject(items, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);


            // 5. deserialize items from "items.json" 
            // ... and print name and Price of deserialized items 
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<IUnterkunft[]>(textFromFile, settings);
            
            foreach (var x in itemsFromFile)
            {
                Console.WriteLine($"Name: {x.Name}      Preis: {x.Preis}");
            }
        }
    }

}

