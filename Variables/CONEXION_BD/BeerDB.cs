﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEXION_BD
{
    public class BeerDB:DB
    {
        public BeerDB(string server,string db):base(server,db)
        {

        }

        public  List<Beer> getAll()
        {

                List<Beer> beers = new List<Beer>();
                Connect();
                string query = "SELECT id,nombre,brand_id from beer";
                SqlCommand command = new SqlCommand(query,_connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    int brandId = reader.GetInt32(2);
                    beers.Add(new Beer(id,nombre,brandId));
                }

                Close();
                return beers;
        }
    }
}
