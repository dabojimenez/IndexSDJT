using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORUSCURSO.Datos
{
    internal class ConexionMaestra
    {
        //realizaremos la conexion de forma mas dinamica a traves de un archivo XML, encriptado para la seguridad del programa
        //llamamos a la funcion checkserver, para poder ller la cadena de conexion
        private static string Conexion = Convert.ToString(Logica.Desencryptacion.checkServer());
        ///private static string Conexion = @"Data source=DESKTOP-BRSSJE8; Initial Catalog=ORUSBD; Integrated Security=true";

        public static SqlConnection conectar = new SqlConnection(Conexion);

        public static void AbrirBD()
        {
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void CerrarBD()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
