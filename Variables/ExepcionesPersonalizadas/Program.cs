using System;

namespace ExepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Beer objBeer = new Beer();
                objBeer.Brand = "Fuller";
                Console.WriteLine(objBeer);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
    class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            if (Name == null || Brand == null)
                throw new Exception();
            return $"Cerveza: {Name },Brand: {Brand}";
        }


    }
}
