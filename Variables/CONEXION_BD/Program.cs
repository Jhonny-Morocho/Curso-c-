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
                            mostrarCervezas(ObjBeerDB);
                            break;
                        case 2:
                            agregarCerveza(ObjBeerDB);
                            break;
                        case 3:
                            editarCerveza(ObjBeerDB);
                            break;
                        case 4:
                            eliminarCerveza(ObjBeerDB);
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
        public static void mostrarCervezas(BeerDB beerDB)

        {
            Console.Clear();
            Console.WriteLine("CERVESAS DE LA BASE DE DATOS: ");
      
            List<Beer> beers = beerDB.getAll();
            foreach (var beer in beers)
            {
                Console.WriteLine($" [ Id: { beer.Id}]  [ Nombre : { beer.Nombre}]  [BrandId: {beer.Brand_Id}]");
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

        public static void editarCerveza(BeerDB beerDB)
        {
            Console.Clear();
            mostrarCervezas(beerDB);
            Console.WriteLine("EDITAR CERVEZA");
            Console.WriteLine("Escribe el ID de la cerveza a editar");
            int id = int.Parse(Console.ReadLine());
            //buscar la cerveza
            Beer objBeer = beerDB.get(id);
            if (objBeer!=null)
            {
                Console.WriteLine("Escribe el nombre de la cerveza: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Escribe brand_id de la cerveza: ");
                int brand_id = int.Parse(Console.ReadLine());
                objBeer.Nombre = nombre;
                objBeer.Brand_Id = brand_id;
                beerDB.edit(objBeer);

            }
            else
            {
                Console.WriteLine($"LA CERVEZA CON EL {id} no ha sido encontrad ");
            }
        }

        public static void eliminarCerveza(BeerDB beerDB)
        {
            Console.Clear();
            mostrarCervezas(beerDB);
            Console.WriteLine("Eliminar CERVEZA");
            Console.WriteLine("Escribe el ID de la cerveza a editar");
            int id = int.Parse(Console.ReadLine());
            //buscar la cerveza
            Beer objBeer = beerDB.get(id);
            if (objBeer != null)
            {
                beerDB.delete(id);
            }
            else
            {
                Console.WriteLine($"LA CERVEZA CON EL {id} no ha sido encontrad ");
            }
        }

    }
}
