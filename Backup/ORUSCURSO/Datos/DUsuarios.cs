using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Datos
{
    public class DUsuarios
    {
        public bool INSERTAR_USUARIO(LUsuarios data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("INSERTAR_USUARIO", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombresApellidos", data.NombresApellidos);
                cmd.Parameters.AddWithValue("@Login", data.Login);
                cmd.Parameters.AddWithValue("@Password", data.Password);
                cmd.Parameters.AddWithValue("@Icono", data.Icono);
                cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }
        public void MOSTRAR_USUARIOS(ref DataTable dt)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Usuarios", ConexionMaestra.conectar);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }
        public void OBTENER_ID_USUARIO(ref int IdUsuario, string Login)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("OBTENER_ID_USUARIO",ConexionMaestra.conectar);
                // Indicamos que es un tipo de ocmando de procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Login", Login);
                // obtiene el primer valor de la consulta y no toma en cuenta las demas columnas en caso de que exista en la consulta
                IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }
        public void VerificarUsuarios(ref string Indicador)
        {
            try
            {
                int IsUsuario;
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("SELECT IdUsuario FROM Usuarios", ConexionMaestra.conectar);
                IsUsuario = (int)cmd.ExecuteNonQuery();
                ConexionMaestra.CerrarBD();
                Indicador = "Correcto";
            }
            catch (Exception)
            {
                Indicador = "Incorrecto";
            }
            //finally
            //{
            //    ConexionMaestra.CerrarBD();
            //}
        }
        public void VALIDAR_USUARIO(LUsuarios data, ref int Id)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("VALIDAR_USUARIO", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Password", data.Password);
                cmd.Parameters.AddWithValue("@Login", data.Login);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                Id = 0;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }
    }
}
