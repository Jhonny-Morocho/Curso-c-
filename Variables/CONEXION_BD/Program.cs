using System;
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
                DB dbConexion = new DB(@"DESKTOP-CCMB5TR\SQLEXPRESS","curso_c_dev");
                dbConexion.Connect();
                dbConexion.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine($"ERROR AL CONECTARSE {e.Message}");
            }
        }
    }
}
