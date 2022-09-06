using System;

namespace ExepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Beer objBeer = new Beer() { 
                Name="London"
                };
                //objBeer.Brand = "Fuller";
                Console.WriteLine(objBeer);

            }
            catch (InvalidBeerException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
    class InvalidBeerException : Exception
    {
        public InvalidBeerException() : base("La carvesa no tiene nombre o marca")
        {

        }
    }
    class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            if (Name == null || Brand == null)
            
                throw new InvalidBeerException();
            
            return $"Cerveza: {Name },Brand: {Brand}";

            
        }


    }
}
