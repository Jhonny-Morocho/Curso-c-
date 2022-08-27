using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            mostar();
            sumar(10,5);
            Console.WriteLine("El producto de a y b es "+producto(10,5));

        }
        //no retorna nada
        static void mostar()
        {
            Console.WriteLine("Hola soy un texto que se impre dede funciones");
        }
        static void sumar(int a, int b)
        {
            Console.WriteLine("LA SUMA ES "+ (a+b));
        }
        static int producto(int a,int b)
        {
            return a*b;
        }
    }
}
