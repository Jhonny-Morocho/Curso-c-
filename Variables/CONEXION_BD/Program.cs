using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace CONEXION_BD
{
    class Program
    {
        static void Main(string[] args)
        {
            //LLAMAMOS A LA BASE DE DATOS

            try
            {
                BeerDB ObjBeerDB = new BeerDB(@"DESKTOP-CCMB5TR\SQLEXPRESS", "curso_c_dev");
                bool again = true;
                int op = 0;

                while (again)
                {
                    mostrarMenu();
                    Console.WriteLine("ELIGE UNA OPCION : ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            mostrarInformacion(ObjBeerDB);
                            break;
                        case 2:
                            agregarCerveza(ObjBeerDB);
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            again = false;
                            break;
                    }
                }
         

            }
            catch (SqlException e)
            {
                Console.WriteLine($"ERROR AL CONECTARSE {e.Message}");
            }
        }
        public static void mostrarMenu()
        {
            Console.WriteLine("******* M E N U **********");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
        }
        public static void mostrarInformacion(BeerDB beerDB)

        {
            Console.Clear();
            Console.WriteLine("CERVESAS DE LA BASE DE DATOS: ");
      
            List<Beer> beers = beerDB.getAll();
            foreach (var beer in beers)
            {
                Console.WriteLine($"{ beer.Id} : { beer.Nombre}");
            }
        }
        public static void agregarCerveza(BeerDB beerDB) {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escriba el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el id de la marca");
            int brand_id = int.Parse(Console.ReadLine());

            Beer objBeer = new Beer(nombre, brand_id);

            beerDB.add(objBeer);

        }
       
    }
}
