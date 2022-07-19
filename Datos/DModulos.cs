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
    public class DModulos
    {
        public void MOSTRAR_MODULOS(ref DataTable dt)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Modulos", ConexionMaestra.conectar);
                // le pasamos toda la informacion a la dataTable, creando asi una neurona, para la epsera d eun cerebro cuando sea llamada
                adapter.Fill(dt);
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

        public bool INSERTAR_MODULO(LModulos data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("INSERTAR_MODULO", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Modulo", data.Modulo);
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
