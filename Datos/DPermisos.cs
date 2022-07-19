using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ORUSCURSO.Logica;
using System.Windows.Forms;

namespace ORUSCURSO.Datos
{
    public class DPermisos
    {
        public bool INSERTAR_PERMISO(LPermisos data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("INSERTAR_PERMISOS", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModulo", data.IdModulo);
                cmd.Parameters.AddWithValue("@IdUsuario", data.IdUsuario);
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

        public void MOSTRAR_PERMISOS(ref DataTable dt, LPermisos data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("MOSTRAR_PERMISOS", ConexionMaestra.conectar);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@IdUsuario", data.IdUsuario);
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

        public bool ELIMINAR_PERMISOS(LPermisos data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("ELIMINAR_PERMISOS", ConexionMaestra.conectar);
                cmd.Parameters.AddWithValue("@IdUsuario", data.IdUsuario);
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
    }
}
