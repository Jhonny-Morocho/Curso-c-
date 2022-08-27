using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            sale objSale = new sale(100,DateTime.Now);
            objSale.Total = -12;
            Console.WriteLine("EL get es "+objSale.Total);
        }
    }
    class sale
    {
        int total;
        DateTime date;

        //propiedades para regglas de negocio
        public int Total
        {
            get
            {
                return this.total;
            }
            set
            {
                if (value<0) {
                    value = 0;
                    this.total = value;
                }
            }
        }
        //funciones
        public sale(int total,DateTime time)
        {
            this.total = total;
            this.date = time;
        }
    }
}
