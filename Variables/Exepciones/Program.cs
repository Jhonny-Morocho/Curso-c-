using System;
using System.IO;
namespace Exepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                throw new Exception("Ocurrio algo raro");
                string content = File.ReadAllText(@"C:\xampp\htdocs\Curso_C-\archivos_prueba.txt");
                Console.WriteLine(content);
            }
            catch(FieldAccessException e)
            {
                Console.WriteLine($" ERROR ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //cerrar el archivo
            finally
            {
                Console.WriteLine("CERRAMOS EL ARCHIVO Y FINALIZADO PASE LO Q PASE ");
            }
        }
    }
}
