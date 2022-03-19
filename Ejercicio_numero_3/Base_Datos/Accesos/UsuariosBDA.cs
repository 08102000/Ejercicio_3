using Base_Datos.Atributos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Datos.Accesos
{
    public class UsuariosBDA //Conexion de Usuarios a Base de Datos Acceso
    {
        readonly string conexion = "Server=localhost; Port=3306; Database=programacion3; Uid=root; Pwd=15082000;";

        MySqlConnection conn;
        MySqlCommand cmd; 

        public Usuario Login(string CodigoU, string contrasenia)

        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE  CodigoU = @CodigoU AND Contraseña=@contrasenia;";
                conn = new MySqlConnection(conexion);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CodigoU", CodigoU);
                cmd.Parameters.AddWithValue("@Contraseña", contrasenia);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.CodigoU = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Identidad = reader[2].ToString();
                    user.RolUsuario = reader[3].ToString();
                    user.Genero = reader[4].ToString();
                    user.Contraseña = reader[5].ToString();
                    user.Edad = Convert.ToInt32(reader[6]);
                }
                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {

            }
            return user;
        }

        public DataTable ListarUsuarios()
        {
            DataTable listaUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuario;";
                conn = new MySqlConnection(conexion);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaUsuariosDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaUsuariosDT;
        }
        public bool NuevoUsuario(Usuario usuario)
        {
            bool Nuevo = false;
            try
            {
                string sql = "INSERT INTO usuario VALUES (@CodigoU, @Nombre, @Identidad, @RolUsuario, @Genero, @Contraseña, @Edad);";

                conn = new MySqlConnection(conexion);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CodigoU", usuario.CodigoU);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Identidad", usuario.Identidad);
                cmd.Parameters.AddWithValue("@RolUsuario", usuario.RolUsuario);
                cmd.Parameters.AddWithValue("@Genero", usuario.Genero);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Edad", usuario.Edad);

                cmd.ExecuteNonQuery();
                Nuevo = true;

                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return Nuevo;
        }

        public bool EditarUsuario(Usuario usuario)
        {
            bool modifico = false;
            try
            {
                string sql = "UPDATE usuario SET CodigoU = @Codigo, Nombre = @Nombre, Identidad = @Identidad, RolUsuario = @RolUsuario, Genero = @Genero, Contraseña = @Contraseña, Edad = @Edad WHERE CodigoU = @Codigo;";

                conn = new MySqlConnection(conexion);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo", usuario.CodigoU);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Identidad", usuario.Identidad);
                cmd.Parameters.AddWithValue("@RolUsuario", usuario.RolUsuario);
                cmd.Parameters.AddWithValue("@Genero", usuario.Genero);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Edad", usuario.Edad);

                cmd.ExecuteNonQuery();
                modifico = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return modifico;
        }
    
        public bool EliminarUsuario(string codigoU)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM usuario WHERE CodigoU = @CodigoU;";

                conn = new MySqlConnection(conexion);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CodigoU", codigoU);

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }
    }
}
