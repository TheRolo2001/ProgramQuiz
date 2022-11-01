using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.Windows.Forms;

namespace DataAccess
{
    public class UserDao:ConnectionToSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Pass = @Pass";
                    command.Parameters.AddWithValue("@Usuario", user);
                    command.Parameters.AddWithValue("@Pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Id_Usuario = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.Cargo = reader.GetString(2);
                            UserLoginCache.Usuario = reader.GetString(3);
                            UserLoginCache.Contraseña = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }
        public bool Register(string name, string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Usuarios (Nombre, Usuario, Pass) VALUES (@Nombre, @Usuario, @Pass)";
                    command.Parameters.AddWithValue("@Nombre", name);
                    command.Parameters.AddWithValue("@Usuario", user);
                    command.Parameters.AddWithValue("@Pass", pass);
                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex) 
                    { 
                        MessageBox.Show("No se pudo ejecutar " + ex.ToString());
                        return false; 
                    }   
                }
            }
        }
        public void EditarPefil(int id, string nombre, string usuario, string contraseña)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Usuarios set Nombre=@Nombre, Usuario=@Usuario, Pass=@Pass where Id_Usuario=@Id_Usuario";
                    command.Parameters.AddWithValue("@Id_Usuario", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Pass", contraseña);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
