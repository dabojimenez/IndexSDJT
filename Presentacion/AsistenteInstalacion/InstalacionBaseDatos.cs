using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ORUSCURSO.Logica;

namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    public partial class Instalacion_de_Base_de_Datos : Form
    {
        string nombreEquipoUsuario;
        string ruta;
        private Encryptacion Aes = new Encryptacion();
        public static int milisegundo;
        public static int segundos;

        public Instalacion_de_Base_de_Datos()
        { 
            InitializeComponent();
        }

        private void Instalacion_de_Base_de_Datos_Load(object sender, EventArgs e)
        {
            CentrarPanel();
            Reemplazar();
            ComprobarExistenciaSqlEXPRESS();
        }
        private void CentrarPanel()
        {
            pnlInstalarServidor.Location = new Point((Width/2 - pnlInstalarServidor.Width / 2), (Height / 2 - pnlInstalarServidor.Height / 2));
            //obtendremos el nombre del equipo dle usuario
            nombreEquipoUsuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Cursor = Cursors.WaitCursor;
            pnlContadores.Visible = false;
            pnlContadores.Dock = DockStyle.None;
        }
        //con esta funcion remplazaremos el nombre de la base de la base de datos con la que el usuario quiere crear
        private void Reemplazar()
        {
            // Campo que sera modificado
            rtxCrearProcedimiento.Text = rtxCrearProcedimiento.Text.Replace("ORUSBD", txtNameBD.Text);
            // eliminar base de datos en caso de que este creada o inservible
            rtxEliminarBD.Text = rtxEliminarBD.Text.Replace("BASE_INDEX",txtNameBD.Text);
            //Crearemos el usuario de la base de datos
            rtxCrearUsuarioBD.Text = rtxCrearUsuarioBD.Text.Replace("ada369", txtUsuario.Text);
            rtxCrearUsuarioBD.Text = rtxCrearUsuarioBD.Text.Replace("BASEADA", txtNameBD.Text);
            rtxCrearUsuarioBD.Text = rtxCrearUsuarioBD.Text.Replace("sofwarereal",txtPasswordBD.Text);
            //adjuntando al textbox que contiene los procedimientos almacenados (Environment.NewLine), crea una nueva linea y sigue concatenando
            rtxCrearProcedimiento.Text = rtxCrearProcedimiento.Text + Environment.NewLine + rtxCrearUsuarioBD.Text;

        }
        //comprobacion si existen instalado servidores de BD de tipo SQL_EXPRESS
        private void ComprobarExistenciaSqlEXPRESS()
        {
            rtxServidor.Text = "";
            rtxServidor.Text = @".\" + txtInstancia.Text;
            EliminarBaseDatosComprobacionInicio();
            CrearBaseDatosComprobacionInicio();

        }
        //eliminar base de datos, con comprobacion de incio
        private void EliminarBaseDatosComprobacionInicio()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data source="+rtxServidor.Text+";Initial Catalog=master;Integrated Security=True");
            str = rtxEliminarBD.Text;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        //Crearemos la base de datos con comprobacion de inicio
        private void CrearBaseDatosComprobacionInicio()
        {
            SqlConnection cnn = new SqlConnection("Server="+rtxServidor.Text+"; "+"database=master; Integrated security=yes");
            //creamos la base de datos
            string str = "CREATE DATABASE " + txtNameBD.Text;
            SqlCommand cmd = new SqlCommand(str, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                //guardaremos la cadena de conexion
                GuardarXML(Aes.Encrypt("Data Source="+rtxServidor.Text+";Initial Catalog="+txtNameBD.Text+";Integrated Security=True",Desencryptacion.appPwdUnique,int.Parse("256")));
                EjecutarScriptCrearBD();
                pnlContadores.Visible = true;
                pnlContadores.Dock = DockStyle.Fill;
                lblMensajeInstalacion.Text = @"Instancia Encontrada...
            No cierre esta ventana, se cerrara Automaticamente cuando este todo Listo";
                pnlTemporizador.Visible = false;
                timer3.Start();

            }
            catch (Exception)
            {
                //throw;
            }
        }
        //guardaremos el archivo XML
        private void GuardarXML(object dbcnString)
        {
            XmlDocument documento = new XmlDocument();
            documento.Load("ConnectionString.xml");
            // sobreescribiremos el mismo archivo
            XmlElement root = documento.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter textWriter = new XmlTextWriter("ConnectionString.xml", null);
            textWriter.Formatting = Formatting.Indented;
            documento.Save(textWriter);
            textWriter.Close();
        }
        //funcion para ejecutar el script de crear la base de datos a nivel de c#
        private void EjecutarScriptCrearBD()
        {
            //buscara en donde este el script, de .txt. ( GetCurrentDirectory ), apunta al directorio Binario (bin)
            ruta = Path.Combine(Directory.GetCurrentDirectory(), txtScript.Text+".txt");
            //con este permitiremos poder crear archivos
            //FileInfo fi = new FileInfo(ruta);

            //sobreescribiremos el archivo creado
            StreamWriter sw;
            try
            {
                // validmaos de que exista el archivo en la ruta
                if (File.Exists(ruta) == false)
                {
                    //si no existe crearemos el archivo, vacio
                    sw = File.CreateText(ruta);
                    //le pasmaos el script, y lo sobreescribimos
                    sw.WriteLine(rtxCrearProcedimiento.Text);
                    //procesamos,cerrrando la ultima linea donde termina el archivo
                    sw.Flush();
                    //cerramos el proceso
                    sw.Close();
                }//si el archivo ya existe, lo eliminaremos
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(rtxCrearProcedimiento.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            //esta parte de codigo nos servira para restaurar el escript por consola, ya que el cliente no tendra el administrador de la Base de Datos
            try
            {
                //con esta instancia, indicamos que abra la consola (cmd)
                Process proceso = new Process();
                //indicaremos que ejcute un archivo, pero es importante el usdo de ( sqlcmd )
                proceso.StartInfo.FileName = "sqlcmd";
                //que es lo que va a ejecutar ( -S), indica que ejcutara un script, ejecutando el escript por consola
                proceso.StartInfo.Arguments = " -S "+rtxServidor.Text+" -i "+txtScript.Text+".txt";
                //arrancamos el cmd
                proceso.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            //incrmento en uno
            milisegundo += 1;
            //asignamos a los labales para indicar el temporizador
            lblMilisegundo.Text = milisegundo.ToString();
            //sim el segundo es 60, lo cambiaremos en el segundo
            if (milisegundo == 60)
            {
                segundos += 1;
                lblSegundo.Text = segundos.ToString();
                milisegundo = 0;
            }
            //si es a 15 segundo, pediremos q se detenga
            if (segundos == 15 )
            {
                timer3.Stop();
                //eliminaremos el archivo .txt que hemos creado
                try
                {
                    File.Delete(ruta);
                }
                catch (Exception)
                {

                    throw;
                }
                //destruiremos el formulario, terminando el proceso
                Dispose();
            }
        }
    }
}
