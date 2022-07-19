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
    public partial class TomarAsistencias : Form
    {
        string Identificacion;
        int Contador;
        int IdPersonal;
        DateTime fechaRegistro;

        public TomarAsistencias()
        {
            InitializeComponent();
        }

        private void TomarAsistencias_Load(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            //indicamos el formato de la hora
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            //Le damos un formato de fecha corta con ( ToShortDateString ), que seria el dia/mes/ano
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonalIdentidad();
            if(Identificacion == txtIdentificacion.Text)
            {
                BuscarAsistenciasId();
                if (Contador == 0)
                {
                    DialogResult resultado = MessageBox.Show("¿Agregar una Observación?", "Observaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        pnlObservacion.Visible = true;
                        pnlObservacion.Location = new Point((pnlRegistroAsistencia.Location.X), (pnlRegistroAsistencia.Location.Y));
                        //le damos un nuevo tamano a nuestro panel d eobservaciones
                        pnlObservacion.Size = new Size(pnlRegistroAsistencia.Width, pnlRegistroAsistencia.Height);
                        //traemos al frente el panel
                        pnlObservacion.BringToFront();
                        rtxObervacion.Clear();
                        //colocamos el focus (la barrita parpadeante) en el txt
                        rtxObervacion.Focus();
                        
                    }
                    else
                    {
                        InsertarAsistencias();
                    }
                }
                else
                {
                    ConfirmarSalida();
                }
            }
        }

        private void ConfirmarSalida()
        {
            LAsistencias lAsistencias = new LAsistencias();
            DAsistencias dAsistencias = new DAsistencias();
            lAsistencias.Id_personal = IdPersonal;
            lAsistencias.Fecha_salida = DateTime.Now;
            // Calculamos las horas
            lAsistencias.Horas = Bases.DateDiff(Bases.DateIntervalo.Hour, fechaRegistro, DateTime.Now);
            if (dAsistencias.CONFIRMAR_SALIDA(lAsistencias) == true)
            {
                lblAviso.Text = "SALIDA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
            }
        }

        private void InsertarAsistencias()
        {
            LAsistencias lAsistencias = new LAsistencias();
            DAsistencias dAsistencias = new DAsistencias();
            lAsistencias.Id_personal = IdPersonal;
            lAsistencias.Fecha_entrada = DateTime.Now;
            lAsistencias.Fecha_salida = DateTime.Now;
            lAsistencias.Estado = "ENTRADA";
            lAsistencias.Horas = 0;
            if (string.IsNullOrEmpty(rtxObervacion.Text))
            {
                rtxObervacion.Text = "-";
            }
            lAsistencias.Observacion = rtxObervacion.Text;
            if (dAsistencias.INSERTAR_ASISTENCIAS(lAsistencias))
            {
                lblAviso.Text = "ENTRADA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                pnlObservacion.Visible = false;
            }
        }

        private void BuscarAsistenciasId()
        {
            DataTable dataTable = new DataTable();
            DAsistencias dAsistencias = new DAsistencias();
            dAsistencias.BUSCARASISTENCIASID(ref dataTable, IdPersonal);
            Contador = dataTable.Rows.Count;
            if (Contador > 0)
            {
                fechaRegistro = (DateTime)dataTable.Rows[0]["Fecha_entrada"];
            }
        }

        private void BuscarPersonalIdentidad()
        {
            DataTable dataTable = new DataTable();
            DPersonal dPersonal = new DPersonal();
            dPersonal.BUSCARPERSONALIDENTIDAD(ref dataTable, txtIdentificacion.Text);
            if (dataTable.Rows.Count > 0)
            {
                //  Escribirmos el nombre de la comlumna a capturar, y le enviamos [0], ya que es solo la unica fila que va a mostrar
                //evitamos asi con esto, trabaja con dataGridViews
                Identificacion = dataTable.Rows[0]["Identificacion"].ToString();
                IdPersonal = (int) dataTable.Rows[0]["Id_personal"];
                lblNombre.Text = dataTable.Rows[0]["Nombres"].ToString();
            }
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            InsertarAsistencias();
        }
    }
}
