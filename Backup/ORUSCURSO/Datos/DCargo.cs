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
    public class DCargo
    {
        public bool INSERTAR_CARGO(LCargo data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand sqlCommand = new SqlCommand("INSERTAR_CARGO", ConexionMaestra.conectar);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Cargo", data.Cargo);
                sqlCommand.Parameters.AddWithValue("@SueldoPorHora", data.SueldoPorHora);
                sqlCommand.ExecuteNonQuery();
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

        public bool EDITAR_CARGO(LCargo data)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlCommand sqlCommand = new SqlCommand("EDITAR_CARGO", ConexionMaestra.conectar);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id_Cargo", data.Id_Cargo);
                sqlCommand.Parameters.AddWithValue("@Cargo", data.Cargo);
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

        public void BUSCAR_CARGO(ref DataTable dataTable, string buscador)
        {
            try
            {
                ConexionMaestra.AbrirBD();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BUSCAR_CARGO", ConexionMaestra.conectar);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    }
}
