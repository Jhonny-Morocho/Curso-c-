using System;

namespace SetenciaIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {   
            //asignando datos al array con datos quemados
            string[] arrayFrutas = { "Pera", "Manzana" };
            Console.WriteLine("Longitud del array "+arrayFrutas.Length);
            //defiendo el tamaño del arreglo sin datos
            int[] arrayNumeros =new int[3];
            int cont = 0;
            while (cont<=1)
            {
                Random rnd = new Random();
                arrayNumeros[cont]=rnd.Next(1,10);
                Console.WriteLine("RANDO ARRAY : "+arrayNumeros[cont]);
                cont++;
            }
            cont = 0;
            while (cont<=1)
            {
                Console.WriteLine(arrayFrutas[cont]);
                cont++;
            }

            bool areYourHungry = true;
            if (areYourHungry)
            {
                Console.WriteLine("DEBES COMER");
            }
            Console.WriteLine("El restaurante esta abierto ? "+ isOpenRestaruant("l",0));

            for (int i=0;i<arrayFrutas.Length;i++)
            {
                Console.WriteLine(arrayFrutas[i]);
            }
      
        }
        static bool isOpenRestaruant(string name,int hour=0)
        {
            if (name=="lonche" && hour>0)
            {
                return true;
            }
            return false;
        }
    }
}
