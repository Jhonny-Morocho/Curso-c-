using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor ObjDoctor = new Doctor("Juan",40,"Cardialogo");
            Console.WriteLine(ObjDoctor.getInfo());
            Console.WriteLine(ObjDoctor.getInfoDoc());

        }
    }
    class People
    {
        private string _nombre;
        private int _edad;
        public People(string nombre,int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }
        public string getInfo()
        {
            return _nombre + " " + _edad;
        }
    }
    class Doctor : People
    {
        private string _especialidad;
        //herebncia
        public Doctor(string nombre,int edad,string  especialidad) :base(nombre, edad)
        {
            _especialidad = especialidad;
        }

        public string getInfoDoc()
        {
            return getInfo()+" "+_especialidad;
        }
    }
}
