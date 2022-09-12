using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEXION_BD
{
    public abstract class  DB
    {
        //el privado solo le pertence a la clase
        private string _strConexion;


        protected SqlConnection _connection;

        public DB(string strServe,string db)
        {
            _strConexion = $"Data Source={strServe}; Initial Catalog={db};Integrated Security=true";
        }

        public void Connect()
        {
            _connection = new SqlConnection(_strConexion);
            _connection.Open();
        }
        public void Close()
        {
            if (_connection!=null && _connection.State==System.Data.ConnectionState.Open)
            {
                _connection.Close();

            }

        }
    }
}
