using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            pnlBienvenida.Dock = DockStyle.Fill;
            ValidarPermiso();
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
                if (modulo == "PrePlantillas")
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
            PruebaForm frmPrueba = new PruebaForm();
            frmPrueba.ShowDialog();
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
    }
}
