using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion
{
    public partial class CopiasBd : UserControl
    {
        public CopiasBd()
        {
            InitializeComponent();
        }

        string ruta;
        string NameSoftware = "OrusIndex369";
        string NameBaseDatos = "TestBD";
        //delcaramos unavaribale de tipo Hilo (Thread), ya que no sabemos cuanto tiempo se va a tardar la copia de seguridad
        //con este hilo haremos e seguimiento, cuanod terminara la copia
        private Thread Hilo;
        //variable ligada al hilo de copia de seguridad
        private bool acabaCopiaBD = false;

        private void CopiasBd_Load(object sender, EventArgs e)
        {
            MostrarRuta();
        }
        private void MostrarRuta()
        {
            DCopiasBd dCopiasBd = new DCopiasBd();
            dCopiasBd.MostrarRuta(ref ruta);
            txtRuta.Text = ruta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarCopia();
        }
        private void GenerarCopia()
        {
            if (!string.IsNullOrEmpty(txtRuta.Text))
            {
                //hacemos el seguimiento al hilo, desde el incio, pasnadole la funcion donde se realiza el proceso de backup
                Hilo = new Thread(new ThreadStart(Ejecucion));
                //le dmaos inciar
                Hilo.Start();
                //activamos el timer
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Selecciona una Ruta donde guardar las Copias de Seguridad", "Copia de Seguridad", MessageBoxButtons.OK,MessageBoxIcon.Error);
                //indicamos la barrita parpadeante
                txtRuta.Focus();
            }
        }
        private void Ejecucion()
        {
            string NameCarpetaCopias = "Copias_Seguridad_de_" + NameSoftware;
            //verificamos si existe la ruta creada en el directorio, para poder crear la carpeta
            if (System.IO.Directory.Exists(txtRuta.Text+NameCarpetaCopias))
            {

            }
            else
            {
                //si no existe se creara la carpeta de copias de seguridad
                System.IO.Directory.CreateDirectory(txtRuta.Text + NameCarpetaCopias);
            }
            //cramos la ruta comleta donde se crearan las copias
            string rutaCompleta = txtRuta.Text + NameCarpetaCopias;
            //crearemos una subcarpeta, que estara dentro de la carpeta que selecciono el usuario
            string subCarpeta = rutaCompleta + @"\Respaldo_al_" + (DateTime.Now.Day) + "_" + (DateTime.Now.Month) + "_" + (DateTime.Now.Year) + "_" + (DateTime.Now.Hour) + "_" + (DateTime.Now.Minute);
            try
            {
                //combinamos la direccion, y crearemos la carpeta dentro de la carpeta principal
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(rutaCompleta, subCarpeta));
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                //creamos el archivo de tipo bakup
                string nombreRespaldo = NameBaseDatos + ".bak";
                ConexionMaestra.AbrirBD();
                //CREAREMOS EL BACKUP, CON EL SIGUIENTE COMANDO perteneciente al lenguaje SQL
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE "+NameBaseDatos+" TO DISK = '" + subCarpeta + @"\"+nombreRespaldo+"'", ConexionMaestra.conectar);
                cmd.ExecuteNonQuery();
                acabaCopiaBD = true;
            }
            catch (Exception ex)
            {
                acabaCopiaBD = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionMaestra.CerrarBD();
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            ObtenerRuta();
        }
        private void ObtenerRuta()
        {
            //(folderBrowserDialog1), solo me trae el path/ruta dela carpeta, mas no me trae el archivo o archvos q tenga, ni siquiera la extención
            //a diferencia del (OpenFileDialog)
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //enviamso el path completo d ela carpeta seleccionada
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ObtenerRuta();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //si la copia ha finalizado con exito, relaizaremos la finalizacion del timer
            if (acabaCopiaBD == true)
            {
                timer1.Stop();
                EditarRespaldos();
            }
        }
        private void EditarRespaldos()
        {
            LCopiasBd data = new LCopiasBd();
            DCopiasBd dCopiasBd = new DCopiasBd();
            data.Ruta = txtRuta.Text;
            if (dCopiasBd.Editar_COPIAS_BD(data))
            {
                MessageBox.Show("Copia de Base de Datos Generado", "Copia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
