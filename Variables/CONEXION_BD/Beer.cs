using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEXION_BD
{
    public class Beer
    {
        //variables de las tablas
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Brand_Id { get; set; }
        //declarar construcotr
        public Beer(int id, string nombre,int brandId)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Brand_Id = brandId;
        }
        public Beer(string nombre, int brandId)
        {
            this.Nombre = nombre;
            this.Brand_Id = brandId;
        }
    }
}
