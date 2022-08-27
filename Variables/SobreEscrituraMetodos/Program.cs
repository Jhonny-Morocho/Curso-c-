using System;

namespace SobreEscrituraMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            B objeB = new B();
            Console.WriteLine(objeB.hi());
            //
            Sale objSale = new Sale(10);
            objSale.add(2);
            objSale.add(3);
            Console.WriteLine("El resultado es " + objSale.getTotal());
            //

            SaleWithTax objSaleWithTax = new SaleWithTax(10,1.16m);
            objSaleWithTax.add(2);
            objSaleWithTax.add(3);
            Console.WriteLine("TOTAL SOBRE ESCRIBIENDO CON TAX "+objSaleWithTax.getTotal());

        }
    }
    class A
    {
        public  virtual string hi()
        {
            return "Hola soy A ";
        }
    }
    class B:A
    {
       public override string hi() 
        {
            //ampliar la funcionalidad existente
            return base.hi()+"Hola soy B ";

        }
    }

    public class Sale
    {
        private decimal[] _amountArrays;
        private int _n;
        private int _end;
        public Sale(int n)
        {
            _amountArrays = new decimal[n];
            _n = n;
            _end = 0;
        }

        public void add(decimal amount)
        {
            if (_end<_n)
            {
                _amountArrays[_end]=amount;
                _end++;
            }
        }
        public virtual decimal getTotal()
        {
            decimal resul = 0;
            int i = 0;
            while (i<_amountArrays.Length)
            {
                resul += _amountArrays[i];
                i++;
            }
            return resul;
        }
    }
    public class SaleWithTax:Sale
    {
        private decimal _tax;
        public SaleWithTax(int n, decimal tax):base(n)
        {
            _tax = tax;
        }
        public override decimal getTotal()
        {
            return base.getTotal()*_tax;
        }
    }


}
