using ORUSCURSO.Datos;
using ORUSCURSO.Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion
{
    public partial class PrePlanilla : UserControl
    {
        public PrePlanilla()
        {
            InitializeComponent();
        }

        private void PrePlanilla_Load(object sender, EventArgs e)
        {
            CalcularNumeroSemanas();
            ReporteAsistencia();
        }
        private void ReporteAsistencia()
        {
            ReportAsistencia rpt = new ReportAsistencia();
            DataTable dt = new DataTable();
            DAsistencias dAsistencias = new DAsistencias();
            dAsistencias.MOSTRAR_ASISTENCIAS_DIARIAS(ref dt, dtpDesde.Value, dtpHasta.Value,Convert.ToInt32(lblNumeroSemana.Text));
            // IMPORTANTE DEJAR LA TABLA DE DONDE ESTA EL REPORTE, DEJARLA EN PUBLICO, SOLO A LA TABLA PARA PDOER ACCEDER
            //EN LA PROPIEDAD DE MODIFIERS
            //le agregamos la ifnromacion al cerebro
            rpt.DataSource = dt;
            //agregamos los datos ya a la tabla del cerebro, a la neurona
            rpt.tblReporteAsistenciaPersonal.DataSource = dt;
            // mostramos el reporte
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            CalcularNumeroSemanas();
            ReporteAsistencia();
        }
        private void CalcularNumeroSemanas()
        {
            DateTime valorFechaHasta = dtpHasta.Value;
            //sacaremos el numero de semana, pasandole el valor obtenido de la fecha hasta, ya que nos pide un valor final
            //sacaeremos el numero de semanas por year
            lblNumeroSemana.Text = CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(valorFechaHasta, CalendarWeekRule.FirstDay, valorFechaHasta.DayOfWeek).ToString();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            CalcularNumeroSemanas();
            ReporteAsistencia();
        }
    }
}
