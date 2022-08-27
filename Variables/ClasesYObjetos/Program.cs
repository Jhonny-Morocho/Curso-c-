using System;

namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            sale objeSale = new sale(10,DateTime.Now);
            Console.WriteLine( objeSale.getInfo());
        }
    }
    class sale
    {
        int total;
        DateTime date;

        public sale(int total,DateTime time)
        {
            this.total = total;
            this.date = time;
        }
        public void show()
        {
            Console.WriteLine("HOLA SOY UNA VENTA");
        }
        public string getInfo()
        {
            return "El total Total es " + this.total + " y la fecha es " + this.date.ToLongDateString();
        }
    }
}
