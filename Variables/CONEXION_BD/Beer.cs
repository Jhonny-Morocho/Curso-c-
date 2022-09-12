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
        public int BrandId { get; set; }
        //declarar construcotr
        public Beer(int id, string nombre,int brandId)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.BrandId = brandId;
        }
    }
}
