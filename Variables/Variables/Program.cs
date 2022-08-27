using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi primer programa con C#");
            //integer
            int numero1 = 1;
            int numero2 = 5;
            //cadena
            string postre = "Gelatina de fresa";
            //char
            char calificacion = 'c';
            //bolena
            bool existe = true;


            Console.WriteLine("La suma es "+(numero1+numero2));
            Console.WriteLine("La cadena es"+ postre);
            Console.WriteLine("EL caracterer es" + calificacion);
            Console.WriteLine("Existe la variable boolenan "+existe);

        }
    }
}
