using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ORUSCURSO.Logica;
using System.Windows.Forms;

namespace ORUSCURSO.Datos
{
    public class DPersonal
    {
        public bool INSERTAR_PERSONAL(LPersonal data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                 SqlCommand sqlCommand = new SqlCommand("INSERTAR_PERSONAL", ConexionMaestra.conectar);
                 sqlCommand.CommandType = CommandType.StoredProcedure;
                 sqlCommand.Parameters.AddWithValue("@Nombres",data.Nombres);
                 sqlCommand.Parameters.AddWithValue("@Identificacion", data.Identificacion);
                 sqlCommand.Parameters.AddWithValue("@Pais", data.Pais);
                 sqlCommand.Parameters.AddWithValue("@Id_Cargo", data.Id_Cargo);
                 sqlCommand.Parameters.AddWithValue("@SueldoPorHora", data.SueldoPorHora);
                 sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //StackTrace me enviea un mensaje de error mas detallado, pero no me trae el del SQL SERVER
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }

        public bool EDITAR_PERSONAL(LPersonal data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand sqlCommand = new SqlCommand("EDITAR_PERSONAL", ConexionMaestra.conectar);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id_personal", data.Id_personal);
                sqlCommand.Parameters.AddWithValue("@Nombres", data.Nombres);
                sqlCommand.Parameters.AddWithValue("@Identificacion", data.Identificacion);
                sqlCommand.Parameters.AddWithValue("@Pais", data.Pais);
                sqlCommand.Parameters.AddWithValue("@Id_Cargo", data.Id_Cargo);
                sqlCommand.Parameters.AddWithValue("@SueldoPorHora", data.SueldoPorHora);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //StackTrace me enviea un mensaje de error mas detallado, pero no me trae el del SQL SERVER
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }

        public bool ELIMINAR_PERSONAL(LPersonal data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand sqlCommand = new SqlCommand("ELIMINAR_PERSONAL", ConexionMaestra.conectar);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id_personal", data.Id_personal);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //StackTrace me enviea un mensaje de error mas detallado, pero no me trae el del SQL SERVER
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }

        public bool RESTAURAR_PERSONAL(LPersonal data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand sqlCommand = new SqlCommand("RESTAURAR_PERSONAL", ConexionMaestra.conectar);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@IdPersonal", data.Id_personal);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //StackTrace me enviea un mensaje de error mas detallado, pero no me trae el del SQL SERVER
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }

        //Hacemos referencia que usaremos DataTable, ya que podremos usarlo par aun combo box, datagridvIew, etc
        public void MOSTRAR_PERSONAL_PAGINADO(ref DataTable dataTable, int desde, int hasta)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("MOSTRAR_PERSONAL",ConexionMaestra.conectar);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
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

        public void BUSCAR_PERSONAL(ref DataTable dataTable, int desde, int hasta, string buscador)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BUSCAR_PERSONAL", ConexionMaestra.conectar);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
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

        public void BUSCARPERSONALIDENTIDAD(ref DataTable dataTable, string buscador)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BUSCARPERSONALIDENTIDAD", ConexionMaestra.conectar);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@BUSCADOR", buscador);
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

        public void CONTARPERSONAL(ref int Contador)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(Id_personal) FROM Personal",ConexionMaestra.conectar);
                //(ExecuteScalar), ejecuta la ocnsulta, y devuelve la primera fila del conjunto de resultados devuelto por la consulta, Las demas filas o columnas no se toma en cuenta
                Contador = (int) sqlCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                Contador = 0;
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }
        }
    }
}
