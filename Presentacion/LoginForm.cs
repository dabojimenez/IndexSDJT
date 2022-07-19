using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using ORUSCURSO.Presentacion.AsistenteInstalacion;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string Usuario;
        int IdUsuario;
        int Contador;
        string Indicador;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ValidarConexion();
        }

        //Validaremos la conexion a la base de datos con el usuario que ingrese al configurar
        private void ValidarConexion()
        {
            VerificarConexion();
            if (Indicador == "Correcto")
            {
                MostrarUsuarios();
                if (Contador == 0)
                {
                    //Destrurimos el formulario, d elogin, y mostrarmeos al usuario principal, que es un formulario
                    Dispose();
                    UsuarioPrincipal frmUsuarioPrincipal = new UsuarioPrincipal();
                    frmUsuarioPrincipal.ShowDialog();
                }
                else
                {
                    DibujarUsuarios();
                }

            }
            else
            {
                //si el usuairo de la base de datos es incorrecto, se destruira este formulairo
                //y le haremos seleccionar el servidor
                Dispose();
                EleccionServidor frmEleccionServidor = new EleccionServidor();
                frmEleccionServidor.ShowDialog();
            }
        }

        // verificarmeos la conexion
        private void VerificarConexion()
        {
            DUsuarios dUsuario = new DUsuarios();
            dUsuario.VerificarUsuarios(ref Indicador);
        }
        //dibujaremos los usuarios a partir de ocdigo
        private void DibujarUsuarios()
        {
            try
            {
                pnlSeleccionUsuario.Visible = true;
                pnlSeleccionUsuario.Dock = DockStyle.Fill;
                //traemos al frente al panel
                pnlSeleccionUsuario.BringToFront();
                DataTable dt = new DataTable();
                DUsuarios dUsuarios = new DUsuarios();
                dUsuarios.MOSTRAR_USUARIOS(ref dt);
                foreach (DataRow rdr in dt.Rows)
                {
                    Label lbl = new Label();
                    Panel pnl = new Panel();
                    PictureBox ptb = new PictureBox();
                    //colocamos en el texto, lo que traemos en el campo Login de la BD
                    lbl.Text = rdr["Login"].ToString();
                    //en el nombre colocaremos el id, que traemos de la base de datos
                    lbl.Name = rdr["IdUsuario"].ToString();
                    //indicaremos el tamano que tendra nuestro label
                    lbl.Size = new Size(175, 25);
                    //cambiamos el tipo de familia de letra y el tamano
                    lbl.Font = new Font("Microsoft Sans Serif", 13);
                    //colocarmeos el color transparente
                    lbl.BackColor = Color.Transparent;
                    //colocaremos el color de la letra de color blanco
                    lbl.ForeColor = Color.White;
                    //fijarmeos en la parte inferior
                    lbl.Dock = DockStyle.Bottom;
                    //alinearmeos nuetsro texto al centro
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    //colocarmeos un hand, para cmabiar la forma del cursor
                    lbl.Cursor = Cursors.Hand;
                    //traemos al frente
                    lbl.BringToFront();
                    //para enviar o mandar la fondo es
                    //lbl.SendToBack();

                    //  CONFIGURACION DEL PANEL
                    //colocaremos las dimenicones del panel (ancho, alto)
                    pnl.Size = new Size(155, 167);
                    //le quitamos los bordes
                    pnl.BorderStyle = BorderStyle.None;
                    //como contendra al label y al picturebox, colocarmeos un color desde RGB
                    pnl.BackColor = Color.FromArgb(20, 20, 20);

                    //  CONFIGURACION PICTUREBOX
                    //le daremos las dimenciones igual que el panel
                    ptb.Size = new Size(175, 132);
                    //lo colocaremos en la parte superior
                    ptb.Dock = DockStyle.Top;
                    //le daremos un fondo de color de tipo nulo
                    ptb.BackgroundImage = null;
                    //le damos o colocamos la imagen que ha sido seleccionada, traida desde la BD
                    byte[] bi = (byte[])rdr["Icono"];
                    //almacenamos en memoria, la imagen
                    MemoryStream ms = new MemoryStream(bi);
                    //mostramos en el picturebox, ya que ya la tenemos en memoria
                    ptb.Image = Image.FromStream(ms);
                    //escalaremos la imagen
                    ptb.SizeMode = PictureBoxSizeMode.Zoom;
                    //colocaremos el tag, para mostrar el login, de la base de datos
                    ptb.Tag = rdr["Login"].ToString();
                    //cambiarmeos la forma del cursor cuando este encima de la imagen
                    ptb.Cursor = Cursors.Hand;

                    //  AGREGAMOS EL LABEL Y EL PICTURE BOX DENTRO DEL CONTROL
                    //agregamos el label
                    pnl.Controls.Add(lbl);
                    //agregamos el picturebox
                    pnl.Controls.Add(ptb);

                    //  AGREGAMOS AL FLOYOUTPANEL
                    //agregamos el panel que creamos
                    flpUsuarios.Controls.Add(pnl);

                    //  MANEJAREMOS EL EVENTO CLICK (recuerda dar dos veces en tabulador, depsues de += para q se cree el metodo automaticamente) 
                    //lbl.Click += Lbl_Click;       <------
                    //cambiamso el nombre para q no eixsta conflictos y quedaria asi:
                    //lbl.Click += new EventHandler(MiEventoLabel);//         <----- forma correcta, mas detallada
                    ptb.Click += MiEventoImagen;//  <------------ forma correcta, y directa asigando el metodo
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void MiEventoImagen(object sender, EventArgs e)
        {
            //capturamos el tag que le pasamos en el picturebox
            Usuario = ((PictureBox)sender).Tag.ToString();
            //enviamos la imagen de icono dle usuario al picturebox
            ptbIcono.Image = ((PictureBox)sender).Image;
            //mostramos el panel de password
            MostrarPanelIngresarPassword();
        }

        // CREADO AUTOMATICMAENTE OCN DOS VECES TAB (recordar cambiar el nombre, para q no exista problemas, ya que dond efue creado esta en un foreach)
        /*
        private void MiEventoLabel(object sender, EventArgs e)
        {
            //capturamos el usuario, que le colocamos en el label, y de esta manera podemos acceder al label y a sus propiedades
            Usuario = ((Label)sender).Text;
            MostrarPanelIngresarPassword();
        }
        */
        private void MostrarPanelIngresarPassword()
        {
            pnlPassword.Visible = true;
            // realizamos el calculo, de restar el ancho del panel principal con el del panel de ingresar la clave., tanto para el ancho como el alto
            //al alto, le dividimos entre dos nada mas
            //pnlPassword.Location = new Point((Width - pnlPassword.Width), (Height - pnlPassword.Height)/2);
            pnlPassword.Location = new Point((Width/2 - pnlPassword.Width / 2), (Height  / 2 - pnlPassword.Height / 2));
            pnlSeleccionUsuario.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidarUsuarios();
        }

        private void ValidarUsuarios()
        {
            LUsuarios data = new LUsuarios();
            DUsuarios dUsuarios = new DUsuarios();
            data.Login = Usuario;
            data.Password = txtPassword.Text;
            dUsuarios.VALIDAR_USUARIO(data,ref IdUsuario);
            if (IdUsuario > 0)
            {
                // aumenta el rendimiento el usar Dispose, ya que se tendra un formulario limpio, pero este tambien destruye todo el formulario de manera forzada
                Dispose();
                // con hide, oculta el formulario, pero seguiura consumiendo memoria
                //Hide();
                MenuPrincipal frmMenuPrincipal = new MenuPrincipal();
                //enviaremos los dtos del usuario que se loguea, llevando el IdUsuario, el login(Usuario) y el Icono
                frmMenuPrincipal.IdUsuario = IdUsuario;
                frmMenuPrincipal.LoginV = Usuario;
                //en el icono lo colocaremos publico, ya que en su propiedad de interface grafica, colocamos su Modifiers, en publico
                frmMenuPrincipal.ptbIcono.Image = ptbIcono.Image;
                frmMenuPrincipal.ShowDialog();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clave ingresada Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Podemos asignar el valor de la siguiente ofmra no hay problema usando ( += )
            txtPassword.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int contador;
            contador = txtPassword.Text.Count();
            if (contador > 0)
            {
                //eliminaremos carcater por caracter ingresado en el contador
                txtPassword.Text = txtPassword.Text.Substring(0, (contador - 1));
            }
        }
        //Con esta funcion, obtendremos la cantidad de registros que han sido recuperados de la BD, y lo usarmeos para mostrar el aisstente de instalacion en caso de que no registre usuarios
        private void MostrarUsuarios()
        {
            DUsuarios dUsuarios = new DUsuarios();
            DataTable dt = new DataTable();
            dUsuarios.MOSTRAR_USUARIOS(ref dt);
            Contador = dt.Rows.Count;
        }
    }
}
