using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Beer> ListBeer = new List<Beer>() {
                new Beer()
                {
                    Nombre="Brama",Pais="Brazil",
                },
                 new Beer()
                {
                    Nombre="Club",Pais="Ecuador",
                },
            };

            Beer ObjCerveza1 = new Beer();
            ObjCerveza1.Nombre = "Corna";
            ObjCerveza1.Pais = "Mexico";

            ListBeer.Add(ObjCerveza1);

            foreach (var beer in ListBeer)
            {
                Console.WriteLine(beer);
               
            }
            Console.WriteLine("================================");


            //select
            var beerName = from b in ListBeer select new { Name=b.Nombre,Letters=b.Nombre.Length} ;

            foreach (var b in beerName)
            {
                Console.WriteLine($"{b.Name} {b.Letters}");
            }

           
            
        }
    }
    public class Beer
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
        //tosring exite en la clase object
        public override string ToString()
        {
            return $"Nombre : {Nombre} País: {Pais}";

        }
    }
}
