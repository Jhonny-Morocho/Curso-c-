using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IAnimal
    {
        public string Name { get; set; }
    }
    public interface IFish
    {
        public int Speed { get; set; }
        public string Swim();
    }

    // usando las intefaces
    public class Shark : IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Swim()
        {
            return $"{Name} Nada {Speed}";
        }
    }

}
