using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CrudWithAdoNETFinal
{
    public class PersonasDb
    {
        private string connectionString = "Server=VARITECH\\SQLEXPRESS; Database=CrudWithAdoNET; Integrated security=true";

        public bool Ok()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Personas> Get()
        {
            List<Personas> persona = new List<Personas>();
            string query = "SELECT Id, Nombre, Apellido, Direccion, Edad FROM Personas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        Personas objPersona = new Personas();
                        objPersona.Id = dr.GetInt32(0);
                        objPersona.Nombre = dr.GetString(1);
                        objPersona.Apellido = dr.GetString(2);
                        objPersona.Direccion = dr.GetString(3);
                        objPersona.Edad = dr.GetInt32(4);
                        persona.Add(objPersona);
                    }
                    dr.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
            return persona;
        }

        public Personas Get(int id)
        {
            string query = "SELECT Id, Nombre, Apellido, Direccion, Edad FROM Personas" + " WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();

                    dr.Read();
                    Personas objPersona = new Personas();
                    objPersona.Id = dr.GetInt32(0);
                    objPersona.Nombre = dr.GetString(1);
                    objPersona.Apellido = dr.GetString(2);
                    objPersona.Direccion = dr.GetString(3);
                    objPersona.Edad = dr.GetInt32(4);

                    dr.Close();
                    connection.Close();
                    return objPersona;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
        }

        public void Agregar(string nombre, string apellido, string direccion, int edad)
        {
            string query = "INSERT INTO Personas(Nombre, Apellido, Direccion, Edad) VALUES" + "(@Nombre, @Apellido, @Direccion, @Edad) ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@Edad", edad);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
        }

        public void Editar(string nombre, string apellido, string direccion, int edad, int id)
        {
            string query = "UPDATE Personas SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Edad = @Edad" + " WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@Edad", edad);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
        }

        public void Eliminar(int id)
        {
            string query = "DELETE FROM Personas" + " WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
        }
    }
}
