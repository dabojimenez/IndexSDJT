using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    public partial class UsuarioPrincipal : Form
    {
        private static int idUsuario;

        public UsuarioPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (!string.IsNullOrEmpty(txtConfrimarPassword.Text))
                    {
                        InsertarUusuarioXDefecto();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese para confirmar su Contraseña", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese su Contraseña", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese campo NOmbre de Usuario", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarUusuarioXDefecto()
        {
            LUsuarios data = new LUsuarios();
            DUsuarios dUsuarios = new DUsuarios();
            data.NombresApellidos = txtNombreUsuario.Text;
            data.Login = txtUsuario.Text;
            data.Password = txtPassword.Text;
            MemoryStream ms = new MemoryStream();
            ptbIcono.Image.Save(ms, ptbIcono.Image.RawFormat);
            data.Icono = ms.GetBuffer();
            if (dUsuarios.INSERTAR_USUARIO(data))
            {
                InsertarCopiasBd();
                InsertarModulos();
                ObtenerIdUsuario();
                InsertarPermisos();
            }
        }
        private void InsertarCopiasBd()
        {
            DCopiasBd dCopiasBd = new DCopiasBd();
            dCopiasBd.INSERTAR_COPIAS_BD();
        }
        private void InsertarModulos()
        {
            LModulos data = new LModulos();
            DModulos funcion = new DModulos();
            List<string> modulos = new List<string> { "Usuarios", "Respaldos", "Personal", "PrePlanillas"};
            foreach (string modulo in modulos)
            {
                data.Modulo = modulo;
                funcion.INSERTAR_MODULO(data);
            }
        }
        private void InsertarPermisos()
        {
            //Obtencion de los modulos insertados, obtendremos su Id
            DModulos dModulos = new DModulos();
            DataTable dt = new DataTable();
            dModulos.MOSTRAR_MODULOS(ref dt);

            foreach (DataRow modulo in dt.Rows)
            {
                LPermisos data = new LPermisos();
                DPermisos funcionPermisos = new DPermisos();
                data.IdModulo = Convert.ToInt32(modulo["IdModulo"]);
                data.IdUsuario = idUsuario;
                if (funcionPermisos.INSERTAR_PERMISO(data))
                {
                    
                }
                else
                {
                    MessageBox.Show("Error al Insertar Permisos");
                }
            }
            MessageBox.Show(@"Listo. \n Recuerda que para iniciar Sesión tus credenciales son las siguientes: \nUsuario: " + txtUsuario.Text + ", Contraseña: " + txtPassword.Text, "Registro Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
            LoginForm frmLogin = new LoginForm();
            frmLogin.ShowDialog();
        }
        private void ObtenerIdUsuario()
        {
            //Obener id de Usuario Admin
            DUsuarios dUsuarios = new DUsuarios();
            dUsuarios.OBTENER_ID_USUARIO(ref idUsuario, txtUsuario.Text);
        }

        private void UsuarioPrincipal_Load(object sender, EventArgs e)
        {
            pnlUsuarioPrincipal.Location = new Point(Width / 2 - pnlUsuarioPrincipal.Width / 2,
                Height / 2 - pnlUsuarioPrincipal.Height / 2);
        }
    }
}
