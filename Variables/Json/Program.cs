using System;
using System.Text.Json;
namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer objBeer = new Beer(){ Name = "Pilser",Brand="CN" };
            //creacion de un json
            string json = JsonSerializer.Serialize(objBeer);
            Console.WriteLine(json);
            Beer objBerr2 = JsonSerializer.Deserialize<Beer>(json);
            Console.WriteLine(objBerr2);

        }
    }
    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
    }
}
