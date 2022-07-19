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
    public class DAsistencias
    {
        public void BUSCARASISTENCIASID(ref DataTable dataTable, int Idpersonal)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BUSCARASISTENCIASID", ConexionMaestra.conectar);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@IdPersonal", Idpersonal);
                sqlDataAdapter.Fill(dataTable);
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
        public bool INSERTAR_ASISTENCIAS(LAsistencias lAsistencias)
        {
            try 
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("INSERTAR_ASISTENCIAS", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_persoanl", lAsistencias.Id_personal);
                cmd.Parameters.AddWithValue("@Fecha_entrada", lAsistencias.Fecha_entrada);
                cmd.Parameters.AddWithValue("@Fecha_salida", lAsistencias.Fecha_salida);
                cmd.Parameters.AddWithValue("@Estado", lAsistencias.Estado);
                cmd.Parameters.AddWithValue("@Horas", lAsistencias.Horas);
                cmd.Parameters.AddWithValue("@Observacion", lAsistencias.Observacion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }
        public bool CONFIRMAR_SALIDA(LAsistencias lAsistencias)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand cmd = new SqlCommand("CONFIRMARSALIDA", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", lAsistencias.Id_personal);
                cmd.Parameters.AddWithValue("@Fecha_salida", lAsistencias.Fecha_salida);
                cmd.Parameters.AddWithValue("@Horas", lAsistencias.Horas);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }
        public void MOSTRAR_ASISTENCIAS_DIARIAS(ref DataTable dt, DateTime desde, DateTime hasta, int semana)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter sda = new SqlDataAdapter("MOSTRAR_ASISTENCIAS_DIARIAS", ConexionMaestra.conectar);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@DESDE", desde);
                sda.SelectCommand.Parameters.AddWithValue("@HASTA", hasta);
                sda.SelectCommand.Parameters.AddWithValue("@SEMANA",semana);
                sda.Fill(dt);
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
    }
}
