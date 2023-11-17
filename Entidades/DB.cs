using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DB
    {
        public static SqlConnection connection;

        public static SqlCommand command;

        static DB()
        {
            var sqlStringConnection = @"Server=.;Database=prog2;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
            connection = new SqlConnection(sqlStringConnection);

            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Select()
        {
            try
            {
                connection.Open();

                var query = "SELECT * FROM alumnos";
                command.CommandText = query;

                using( var reader = command.ExecuteReader() )
                {
                    while (reader.Read())
                    {
                        var nombre = reader["nombre"].ToString() ?? "";
                        Console.WriteLine(nombre);
                    }
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex);
            }
            finally {
                connection.Close(); 
            }
        }

        public static void Insert(string apellido, string nombre, int edad)
        {
            try
            {
                connection.Open();

                command.Parameters.Clear();

                var query = $"INSERT INTO alumnos (apellido, nombre, edad) VALUES ('{apellido}', '{nombre}', {edad})";
                command.CommandText = query;
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@edad", edad);

                var filasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
