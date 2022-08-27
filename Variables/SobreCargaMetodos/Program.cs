using System;

namespace SobreCargaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Math objMat = new Math();
            Console.WriteLine(objMat.suma(1,1));
            Console.WriteLine(objMat.suma("1", "1"));
            int[] numeros = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(objMat.suma(numeros));
        }
    }
    class Math
    {
        public int suma(int a, int b)
        {
            return a + b;
        }
        public int suma(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        public int suma(int[] numbers)
        {
            int resultado = 0;
            int cont = 0;
            while (cont < numbers.Length)
            {
                resultado = numbers[cont]+resultado;
                cont++;
            }
            return resultado;
        }
    }
}
