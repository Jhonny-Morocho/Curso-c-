using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People objPeople = new People()
            {
                nombre = "Jhonny",
                edad = 12,
            };
            People objPeople2= new People()
            {
                nombre = "Juan",
                edad = 12,
            };

            Console.WriteLine(People.getCount());


        }
    }
    public class People
    {
        public static int count = 0;
        public string nombre { get; set; }
        public decimal edad { get; set; }
        public People()
        {
            count++;
        }
        public static string getCount()
        {
            return $"Esta clase se ha utilizado {count} veces ";
        }
    }
}
