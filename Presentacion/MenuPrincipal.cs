using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        //variables globales
        public int IdUsuario;
        public string LoginV;
        string NameBaseDatos = "TestBD";
        string Servidor = @".\SQLEXPRESS";
        string ruta;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            pnlBienvenida.Dock = DockStyle.Fill;
            ValidarPermiso();
            lblUsuario.Text = LoginV;
        }
        //validacion de permisos
        private void ValidarPermiso()
        {
            DataTable dt = new DataTable();
            DPermisos dPermisos = new DPermisos();
            LPermisos lPermisos = new LPermisos();
            //Capturamos los datos enviados a las varibales globales al momento q inicaorn sesion
            lPermisos.IdUsuario = IdUsuario;
            dPermisos.MOSTRAR_PERMISOS(ref dt, lPermisos);
            //Inavilitamos los botonos
            btnConsultas.Enabled = false;
            btnPersonal.Enabled = false;
            btnRegistro.Enabled = false;
            btnUsuarios.Enabled = false;
            btnRestaurarBD.Enabled = false;
            btnRespaldos.Enabled = false;
            //recorreremos los permisos, que han sido almacenados en el DataTable
            foreach (DataRow rowPermiso in dt.Rows)
            {
                string modulo = Convert.ToString(rowPermiso["Modulo"]);
                if (modulo == "PrePlanillas")
                {
                    btnConsultas.Enabled = true;
                }
                if (modulo == "Usuarios")
                {
                    btnUsuarios.Enabled = true;
                    btnRegistro.Enabled = true;
                }
                if (modulo == "Personal")
                {
                    btnPersonal.Enabled = true;
                }
                if (modulo == "Respaldos")
                {
                    btnRespaldos.Enabled = true;
                    btnRestaurarBD.Enabled = true;
                }
            }

        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            //PruebaForm frmPrueba = new PruebaForm();
            //frmPrueba.ShowDialog();
            
            //limpiamos los contorles de nuetsro panel padre
            pnlWall.Controls.Clear();
            PrePlanilla contol = new PrePlanilla();
            contol.Dock = DockStyle.Fill;
            //agregamos el control al panel padre
            pnlWall.Controls.Add(contol);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PruebasControl controlPruebas = new PruebasControl();
            //limpiamos el panel principal para mostrar, que se quite la bienvenida en este caso
            pnlWall.Controls.Clear();
            //para que el control se pueda expandir de manera total
            //controlPruebas.Dock = DockStyle.Fill;
            //llamamos a nuestro controlador de formulario, dentro del mismo panel, sin tener que salir del panel principal
            //pnlWall.Controls.Add(controlPruebas);
            PersonalControl personalControl = new PersonalControl();
            personalControl.Dock = DockStyle.Fill;
            pnlWall.Controls.Add(personalControl);
            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //limpiamos el panel pricipal, o de fondo
            pnlWall.Controls.Clear();
            UsuariosControl usuarioControl = new UsuariosControl();
            // Hacemos una expansion total del control de usuarios
            usuarioControl.Dock = DockStyle.Fill;
            // Agregamos en el panel de fondo, el control que deseamos mostrar
            pnlWall.Controls.Add(usuarioControl);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Dispose();
            TomarAsistencias frm = new TomarAsistencias();
            frm.ShowDialog();
        }

        private void btnRestaurarBD_Click(object sender, EventArgs e)
        {
            RestaurarBDExpress();
        }
        private void RestaurarBDExpress()
        {
            //limpiamos la ruta de directoro incial, para no tener errores
            ofd.InitialDirectory = "";
            //realizaremos un filtrado
            ofd.Filter = "Backup "+ NameBaseDatos + "|*.bak";
            //index del filtro, sera a 2 por defecto
            ofd.FilterIndex = 2;
            //titulo de la ventana
            ofd.Title = "Cargador de BackUp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //obtendremos el archivo, la extension, el path
                ruta = Path.GetFileName(ofd.FileName);
                ruta = Path.GetFullPath(ofd.FileName);
                //verificaremos que el archiuvo a restaruar sea reciente
                DialogResult pregunta = MessageBox.Show("Usted esta apunto de restaurar la base de datos, "+"asegurese de que el archivo .bak sea reciente, de"+"lo contrario podría perder información y no podrá"+"recuperarla, Desea continuar?","Restauracion de Base de Datos",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta ==  DialogResult.Yes)
                {
                    //estableceremos la cadena de conecion
                    SqlConnection cone = new SqlConnection("Server=" + Servidor + ";database=master; integrated security=yes");
                    try
                    {
                        cone.Open();
                        //proceso de SQL de eliminar y restaurar una base de datos
                        string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + NameBaseDatos + "' USE [master] ALTER DATABASE [" + NameBaseDatos + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATBASE [" + NameBaseDatos + "] RESTORE DATABASE " + NameBaseDatos + " FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                        //borraremos la base actual que este en uso
                        SqlCommand borrarRestaurar = new SqlCommand(Proceso, cone);
                        //ejecutamos el proceso
                        borrarRestaurar.ExecuteNonQuery();
                        MessageBox.Show("La base de daos ha sido restaurada satisfactoriamente! Vuelve a Iniciar el Aplicativo", "Restauracion de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //destrumios el form
                        Dispose();
                    }
                    catch (Exception)
                    {
                        RestaurarBDNoExpress();
                    }
                    finally
                    {
                        if (cone.State == ConnectionState.Open)
                        {
                            cone.Close();
                        }
                    }
                }
            }
        }
        private void RestaurarBDNoExpress()
        {
            Servidor = ".";
            ofd.InitialDirectory = "";
            ofd.Filter = "Backup " + NameBaseDatos + "|*.bak";
            ofd.FilterIndex = 2;
            ofd.Title = "Cargador de BackUp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //ruta = Path.GetFileName(ofd.FileName);
                ruta = Path.GetFullPath(ofd.FileName);
                DialogResult pregunta = MessageBox.Show("Usted esta apunto de restaurar la base de datos, " + "asegurese de que el archivo .bak sea reciente, de" + "lo contrario podría perder información y no podrá" + "recuperarla, Desea continuar?", "Restauracion de Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {
                    SqlConnection cone = new SqlConnection("Server=" + Servidor + ";database=master; integrated security=yes");
                    try
                    {
                        cone.Open();
                        string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + NameBaseDatos + "' USE [master] ALTER DATABASE [" + NameBaseDatos + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + NameBaseDatos + "] RESTORE DATABASE " + NameBaseDatos + " FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                        SqlCommand borrarRestaurar = new SqlCommand(Proceso, cone);
                        borrarRestaurar.ExecuteNonQuery();
                        MessageBox.Show("La base de daos ha sido restaurada satisfactoriamente! Vuelve a Iniciar el Aplicativo", "Restauracion de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        if (cone.State == ConnectionState.Open)
                        {
                            cone.Close();
                        }
                    }
                }
            }
        }
        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            pnlWall.Controls.Clear();
            CopiasBd copiasBdControl = new CopiasBd();
            copiasBdControl.Dock = DockStyle.Fill;
            pnlWall.Controls.Add(copiasBdControl);
        }
    }
}
