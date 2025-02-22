﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONEXION_BD
{
    public class BeerDB : DB
    {
        public BeerDB(string server, string db) : base(server, db)
        {

        }

        public List<Beer> getAll()
        {

            List<Beer> beers = new List<Beer>();
            Connect();
            string query = "SELECT id,nombre,brand_id from beer";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                beers.Add(new Beer(id, nombre, brandId));
            }

            Close();
            return beers;
        }
        public void add (Beer beer){
            Connect();
            string query = "INSERT INTO beer (nombre,brand_id) "+
                "VALUES(@nombre,@brand_id)";
            SqlCommand command = new SqlCommand(query,_connection);
            command.Parameters.AddWithValue("@nombre",beer.Nombre);
            command.Parameters.AddWithValue("brand_id", beer.Brand_Id);
            command.ExecuteNonQuery();
            Close();
        }
        public void edit(Beer beer)
        {
            Console.WriteLine(beer.Id);
            Console.WriteLine(beer.Brand_Id);
            Console.WriteLine(beer.Nombre);
            Connect();
            string query = "UPDATE beer SET nombre=@nombre, brand_id=@brand_id "+
                "WHERE id=@id";
            SqlCommand command = new SqlCommand(query,_connection);
            command.Parameters.AddWithValue("@nombre",beer.Nombre);
            command.Parameters.AddWithValue("@brand_id", beer.Brand_Id);
            command.Parameters.AddWithValue("@id", beer.Id);
            command.ExecuteNonQuery();
            Close();
        }
        public Beer get(int id)
        {
            Connect();
            Beer objBeer = null;
            string query = "SELECT *FROM beer WHERE id=@id";
            SqlCommand command = new SqlCommand(query,_connection);
            command.Parameters.AddWithValue("@id",id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nombre = reader.GetString(1);
                int brand_id = reader.GetInt32(2);
                objBeer = new Beer(id,nombre,brand_id);
            }

            Close();
            return objBeer;
        }
        public void delete(int id)
        {
            Connect();
            string query = "DELETE FROM beer where id=@id";
            SqlCommand command = new SqlCommand(query,_connection);
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();
            Close();

        }
    }
}
