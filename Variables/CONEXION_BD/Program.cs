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
                BeerDB ObjBeerDB = new BeerDB(@"DESKTOP-CCMB5TR\SQLEXPRESS","curso_c_dev");
                List<Beer> beers = ObjBeerDB.getAll();

                foreach (var beer in beers)
                {
                    Console.WriteLine($"Id: { beer.Id} { beer.Nombre}");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine($"ERROR AL CONECTARSE {e.Message}");
            }
        }
    }
}
