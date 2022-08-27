using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> objLista = new MyList<int>(10);
            objLista.add(10);
            objLista.add(6);
            Console.WriteLine(objLista.getString());

            MyList<string> objListaString = new MyList<string>(10);
            objListaString.add("Hector");
            objListaString.add("MARTIA");
            objListaString.add("Andre");

            Console.WriteLine(objLista.getElement(11));
            Console.WriteLine(objListaString.getElement(0));

            Console.WriteLine(objListaString.getString());

            MyList<People> objListaPersona = new MyList<People>(10);
            People Persona = new People() { Name = "Pedro", Country = "Ecuador" };
            objListaPersona.add(Persona);
            Console.WriteLine(objListaPersona.getString());

        }
    }
    public class People
    {
        public string Name
        {
            get;set;
        }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"Nombre: {Name}, Pais {Country}";
        }
    }
    public class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            _elements = new T[n];
        }
        public void add(T e)
        {
            if (_index<_elements.Length)
            {
                _elements[_index]=e;
                _index++;
            }
        }
        public T getElement(int i)
        {
            if (i<=_index && i>=0)
            {
                return _elements[i];
            }
            return default(T);
        }
        public string getString()
        {
            int i = 0;
            string result = "";
            while (i<_index)
            {
                result += _elements[i].ToString()+"|";
                i++;
            }
            return result;
        }
    }
}
