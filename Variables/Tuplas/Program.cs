using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) producto = (1,"Cerveza pilser");
            Console.WriteLine("EL PRODUCTO ES "+producto.name+" TIENE EL ID "+producto.id);

            (int id, string name) producto1;
            producto1.id = 2;
            producto1.name = "Cerveza corona";
            Console.WriteLine("EL PRODUCTO ES " + producto1.name + " TIENE EL ID " + producto1.id);

            //EDITANDO LOS VALORES DE LAS TUPLAS
            producto.name = "CERVEZA BRAMA";
            Console.WriteLine("EL PRODUCTO EDITADO ES  " + producto.name + " TIENE EL ID " + producto.id);

            // otra forma de crear tupla
            var producto3 = (99,"Poncho");
            Console.WriteLine("EL PRODUCTO ES "+ producto3);
            Console.WriteLine($"EL PRODUCTO ES { producto3.Item1} { producto3.Item2}");

            //ARRAYS CON TUPLAS

            (int id, string nombre)[] producto4 = new[]{
            (1,"Zaptos"),
            (2,"Cartera"),
            (3,"Camisea")
            };

            foreach (var p in producto4)
            {
                Console.WriteLine($"RECORRIENDO EL PRODUCTO { p.id} {p.nombre}");
            }
            // VALORES REGRESADOS
            var cityInfo = getLocarion();
            Console.WriteLine($"VALORES REGRESADOS DE LA FUNCION { cityInfo}");
            //OBTENER SOLO LOS Q NECESITO
            var (_, lng, _) = getLocarion();
            Console.WriteLine($"SOLO REGRESANDO EL DATO Q ME INTERESA {lng }");

        }
        public static (float lat,float lng,string name) getLocarion()
        {
            float lat = 19.12f;
            float lng = -99.17f;
            string name = "CDM";
            return (lat,lng,name);
        }
    }
}
