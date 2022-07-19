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

namespace ORUSCURSO.Presentacion
{
    public partial class UsuariosControl : UserControl
    {
        int IdUsuario;

        public UsuariosControl()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            habilitarPaneles();
            MostrarModulos();
            Bases.PerzonalizarDataGridView(ref dgvListarModulos);
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtPassword.Clear();
            txtUsuario.Clear();
            txtUsuario.Enabled = true;
            dgvListarModulos.Enabled = true;
        }

        private void habilitarPaneles()
        {
            pnlRegistros.Visible = true;
            lblAnuncioIcono.Visible = true;
            pnlIcono.Visible = true;
            // expandimos complematemte al regstro
            pnlRegistros.Dock = DockStyle.Fill;
            // llamamos al frente a registro
            pnlRegistros.BringToFront();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;

        }

        private void MostrarModulos()
        {
            DModulos dModulos = new DModulos();
            DataTable dt = new DataTable();
            dModulos.MOSTRAR_MODULOS(ref dt);
            // le pasamos al cerebor, que en este caso seria el dataGridView
            dgvListarModulos.DataSource = dt;
            dgvListarModulos.Columns["IdModulo"].Visible = false;
        }

        private void InsertarUsuario()
        {
            LUsuarios data = new LUsuarios();
            DUsuarios dUsuarios = new DUsuarios();
            data.NombresApellidos = txtNombre.Text;
            data.Login = txtUsuario.Text;
            data.Password = txtPassword.Text;
            // para trabajr con imagenes, importamos la libreria (using System.IO)
            MemoryStream memoryStream = new MemoryStream();
            // trasnformamos a bites, la imagen
            ptbIcono.Image.Save(memoryStream, ptbIcono.Image.RawFormat);
            // obteemos el formato en bites del buffer, procesados, para asi poder enviar como imagen
            data.Icono = memoryStream.GetBuffer();
            if (dUsuarios.INSERTAR_USUARIO(data))
            {
                ObtenerIdUsuario();
                InsertarPermiso();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // validmaos los cmapos de texto
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        //validamos que se haya seleccionado un icono
                        if (lblAnuncioIcono.Visible == false)
                        {
                            InsertarUsuario();
                        }
                        else
                        {
                            MessageBox.Show("Campo de Icono esta Vacio", "Datos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campo de Contraseña esta Vacio","Datos Vacios",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campo de Usuario esta Vacio", "Datos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo de Nombre esta Vacio", "Datos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerIdUsuario()
        {
            DUsuarios dUsuarios = new DUsuarios();
            dUsuarios.OBTENER_ID_USUARIO(ref IdUsuario, txtUsuario.Text);
        }

        private void InsertarPermiso()
        {
            //recorreremos las columnas, y le eindicamos que sea de tipo de datos (DataGridViewRow)
            //en el dataGridView, espeficiamos que seran las columnas que se recorreran
            foreach (DataGridViewRow value in dgvListarModulos.Rows)
            {
                int idModulo = (int)value.Cells["IdModulo"].Value;
                // las partes que estan marcadas
                bool marcado = Convert.ToBoolean(value.Cells["Marcar"].Value);
                if (marcado == true)
                {
                    LPermisos lPermisos = new LPermisos();
                    DPermisos dPermisos = new DPermisos();
                    lPermisos.IdUsuario = IdUsuario;
                    lPermisos.IdModulo = idModulo;
                    dPermisos.INSERTAR_PERMISO(lPermisos);
                }
            }
            // QUE ME MUESTRE LOS QUE HAN REGISTRADO
            MostrarUsuarios();
            pnlRegistros.Visible = false;
        }

        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            DUsuarios dUsuarios = new DUsuarios();
            dUsuarios.MOSTRAR_USUARIOS(ref dt);
            dgvListadoUsuario.DataSource = dt;
            DisenarDGVUsuarios();
        }

        private void MostrarPanelIcono()
        {
            pnlIcono.Visible = true;
            pnlIcono.Dock = DockStyle.Fill;
            pnlIcono.BringToFront();
        }

        private void lblAnuncioIcono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ptbIcono.Image = pictureBox3.Image;
            ocultarPanelIocno();
        }

        private void ocultarPanelIocno()
        {
            pnlIcono.Visible = false;
            lblAnuncioIcono.Visible = false;
            ptbIcono.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ptbIcono.Image = pictureBox4.Image;
            ocultarPanelIocno();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ptbIcono.Image = pictureBox5.Image;
            ocultarPanelIocno();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ptbIcono.Image = pictureBox6.Image;
            ocultarPanelIocno();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ptbIcono.Image = pictureBox7.Image;
            ocultarPanelIocno();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ptbIcono.Image = pictureBox8.Image;
            ocultarPanelIocno();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ptbIcono.Image = pictureBox9.Image;
            ocultarPanelIocno();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ptbIcono.Image = pictureBox10.Image;
            ocultarPanelIocno();
        }

        private void agregarIconoPC_Click(object sender, EventArgs e)
        {
            //con el OpenFileDialog, abrira las carpetas donde va a estar por defecto
            dlg.InitialDirectory = "";
            //filter los tipos de archivos
            dlg.Filter = "Imagenes|*.jpg;*.png";
            //colocamos el numero de filtros deseados, como anteriormente pusimos dos, por jpg, y png, colocamos dos
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Imagenes";
            // validamos si el usuario, despues de dar doble click en la imagen que dese subir
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                //limpiamos pirmeor el pictureBox
                ptbIcono.BackgroundImage = null;
                // haremos un mapeado de la imagen que estamos trayendo
                ptbIcono.Image = new Bitmap(dlg.FileName);
                ocultarPanelIocno();
            }
        }

        private void ptbIcono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }

        private void UsuariosControl_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void DisenarDGVUsuarios()
        {
            Bases.PerzonalizarDataGridView(ref dgvListadoUsuario);
            Bases.PerzonalizarDataGridViewEliminado(ref dgvListadoUsuario);
            //ocultaremos el IdUsuario
            dgvListadoUsuario.Columns[2].Visible = false;
            dgvListadoUsuario.Columns[5].Visible = false;
            dgvListadoUsuario.Columns[6].Visible = false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validaremos que solo digite numeros
            // (char), e suna tecla en si
            // (IsDigit), que estoy digitando, la tecla de borrado, espacio, coma, puntos, etc, las letras y numeros on aparte
            // (KeyChar), es el evento (e), que s enevia una vez ya presionado
            if (char.IsDigit(e.KeyChar))
            {
                // (handler), es para habilitar o no un control, en este caso desabilitarmeos el bloqueo, si en caso ingreso un digito
                e.Handled = false;// no bloquear ala escritura de numeros
            }
            // verificamos que no sea un contronl con (IsControl), ya q un conrol es por ejemplo el borrar
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                // habilitamos el bloqueo si ha presioando una letra o otra tecla q no se aun digito
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pnlRegistros.Visible = false;
        }

        private void btnRegresarCargo_Click(object sender, EventArgs e)
        {
            ocultarPanelIocno();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void ObtenerDatos()
        {
            ObtenerIdUsuario();
            txtNombre.Text = dgvListadoUsuario.SelectedCells[3].Value.ToString();
            txtUsuario.Text = dgvListadoUsuario.SelectedCells[4].Value.ToString();
            if (txtUsuario.Text == "admin")
            {
                txtUsuario.Enabled = false;
                dgvListarModulos.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                dgvListarModulos.Enabled = true;
            }
            txtPassword.Text = dgvListadoUsuario.SelectedCells[5].Value.ToString();

            ptbIcono.BackgroundImage = null;
            byte[] b = (byte[])(dgvListadoUsuario.SelectedCells[6].Value);
            MemoryStream ms = new MemoryStream(b);
            ptbIcono.Image = Image.FromStream(ms);
            pnlRegistros.Visible = true;
            pnlRegistros.Dock = DockStyle.Fill;
            lblAnuncioIcono.Visible = false;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
            MostrarModulos();
            //mostra
        }
        private void dgvListadoUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoUsuario.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Eliminar al Usuario?", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    
                }
            }
            if (e.ColumnIndex == dgvListadoUsuario.Columns["Editar"].Index)
            {
                ObtenerDatos();
            }
        }

        private void dgvListadoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
