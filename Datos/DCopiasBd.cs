using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Datos
{
    public class DCopiasBd
    {
        public bool INSERTAR_COPIAS_BD()
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("INSERTAR_COPIAS_BD",ConexionMaestra.conectar);
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
        public void MostrarRuta(ref string ruta)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("SELECT Ruta FROM CopiasBd", ConexionMaestra.conectar);
                ruta = Convert.ToString(cmd.ExecuteScalar());
                ConexionMaestra.CerrarBD();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }
        public bool Editar_COPIAS_BD(LCopiasBd data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("Editar_COPIAS_BD", ConexionMaestra.conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ruta", data.Ruta);
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
