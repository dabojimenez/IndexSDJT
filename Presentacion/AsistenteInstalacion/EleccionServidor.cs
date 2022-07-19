using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    public partial class EleccionServidor : Form
    {
        public EleccionServidor()
        {
            InitializeComponent();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            // Destruiremos el formulario
            Dispose();
            // Llamaremos al formulario de instalar una base de datos
            Instalacion_de_Base_de_Datos frmInstalacionBD = new Instalacion_de_Base_de_Datos();
            frmInstalacionBD.ShowDialog();
        }

        private void btnPuntoControl_Click(object sender, EventArgs e)
        {
            // Destruiremos el formulario
            Dispose();
            // llamaremos al formulario de conexion remota
            ConexionRemota frmRemota = new ConexionRemota();
            frmRemota.ShowDialog();
        }
    }
}
