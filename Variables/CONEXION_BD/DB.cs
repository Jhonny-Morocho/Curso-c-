using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEXION_BD
{
    class DB
    {
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
            Console.WriteLine("CONEXION EXITOSA");
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
