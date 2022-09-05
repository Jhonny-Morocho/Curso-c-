using System;
using System.Collections.Generic;
using System.IO;
namespace LISTAS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            number.Add(5);
            number.Add(10);
            Console.WriteLine(number.Count);

            var num = new List<int>();
            var n = 5;


            List<string> country = new List<string>() {"Mexico","Argentina","Ecuador" };
            foreach (string e in country)
            {
                Console.WriteLine(e);
            }

            // lista
            List<People> ListaPersonas=new List<People>();
            People objPersona1 = new People();
            People objPersona2 = new People();
            objPersona1.name = "Jhonny";
            objPersona1.country = "Ecuador";

            objPersona2.name = "Kevin";
            objPersona2.country = "Peru";


            ListaPersonas.Add(objPersona1);

            Console.WriteLine("OBJ PERSONA: "+objPersona1.name);
            Console.WriteLine("LISTA "+ListaPersonas);
            foreach (People e in ListaPersonas)
            {
                Console.WriteLine("Persona "+e.name);
            }


            // *********** FUNCIONES PARA LAS LISTAS ******** //
            List<int> ListaNumeros = new List<int>();
            ListaNumeros.Add(1);
            ListaNumeros.Add(2);
            ListaNumeros.Add(3);
            ListaNumeros.Add(4);

            Console.WriteLine("PRIMER RECORRIDO");
            recorrerArrrayNm(ListaNumeros);
            //recorrer array

            //****** insertar valores en la listas  **//
            Console.WriteLine("SEGUNDO RECORRIDO");
            ListaNumeros.Insert(0,1);
            recorrerArrrayNm(ListaNumeros);
            //buscar la pisucion de un nmero
            int pos = 1;
            Console.WriteLine("En la posicion "+pos+" SE ENCUENTRA " +ListaNumeros.IndexOf(1));
            //pregunta si un elemnto existe
            Boolean boolParar = false;
            while (boolParar==false)
            {
                Console.WriteLine("INGRESE EL NUMERO A BUSCAR");
                try
                {
                    int elementoBuscar = Convert.ToInt32(Console.ReadLine());

                    if (ListaNumeros.Contains(elementoBuscar))
                    {
                        Console.WriteLine("El elemento " + elementoBuscar + " Si encontrado");
                    }
                    else
                    {
                        Console.WriteLine("El elemento " + elementoBuscar + " No encontrado");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("SE HA PRODUCIDO UN ERROR "+e.Message);
                }
            

            }



        }
        static void recorrerArrrayNm (List<int> listaNumeros)
        {
            foreach (int num in listaNumeros)
            {
                Console.WriteLine("** EL NUMERO : ** "+num);
            }
        }
    }

    class People
    {
        public string name;
        public string country;

        public string Country { get => country; set => country = value; }
        public string Name { get => name; set => name = value; }
    }
}
