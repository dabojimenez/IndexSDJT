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
    public partial class PersonalControl : UserControl
    {
        public object PerzonalizarDataGridView { get; private set; }

        public PersonalControl()
        {
            InitializeComponent();
        }

        int IdCargo = 0;
        int desde = 1;
        int hasta = 10;
        int contador;
        int IdPersonal;
        private int ItemsPorPagina = 10;
        string EstadoPersonal;
        int totalPaginas;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlCargos.Visible = false;
            pnlPaginado.Visible = false;
            pnlRegistros.Visible = true;
            pnlRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            Limpiar();
            localizarDGVCargos();
        }

        private void localizarDGVCargos()
        {
            //localizamos el datagridvie, le pasamos como referencia al panel6
            dgvListadoCargos.Location = new Point(txtSueldoHora.Location.X, txtSueldoHora.Location.Y);
            //cambiamos el tamano
            dgvListadoCargos.Size = new Size(469, 141);
            dgvListadoCargos.Visible = true;
            //ocultamos el label de sueldo
            lblSueldo.Visible = false;
            //que no se vean los botonos, el flot layout panel
            flpGuardarPersonal.Visible = false;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtCargo.Clear();
            txtSueldoHora.Clear();
            MostrarCargos();
        }

        private void Agregar()
        {
            

        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (!string.IsNullOrEmpty(txtIdentificacion.Text))
                {
                    if (!string.IsNullOrEmpty(cbxPais.Text))
                    {
                        if (IdCargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldoHora.Text))
                            {
                                InsertarPersonal();
                            }
                        }
                    }
                }
            }
        }

        private void InsertarPersonal()
        {
            LPersonal lPersonal = new LPersonal();
            DPersonal dPersonal = new DPersonal();
            lPersonal.Nombres = txtNombre.Text;
            lPersonal.Identificacion = txtIdentificacion.Text;
            lPersonal.Pais = cbxPais.Text;
            lPersonal.Id_Cargo = IdCargo;
            lPersonal.SueldoPorHora = double.Parse(txtSueldoHora.Text);
            if (dPersonal.INSERTAR_PERSONAL(lPersonal))
            {
                ReiniciarPaginado();
                MostrarPersonal();
                pnlRegistros.Visible = false;
            }
        }

        private void MostrarPersonal()
        {
            DataTable dataTable = new DataTable();
            DPersonal dpersonal = new DPersonal();
            dpersonal.MOSTRAR_PERSONAL_PAGINADO(ref dataTable,desde, hasta);
            dgvListadoPersonal.DataSource = dataTable;
            PerzonalizarDGVPersonal();
            
        }

        private void PerzonalizarDGVPersonal()
        {
            Bases.PerzonalizarDataGridView(ref dgvListadoPersonal);
            pnlPaginado.Visible = true;
            Bases.PerzonalizarDataGridViewEliminado(ref dgvListadoPersonal);
            dgvListadoPersonal.Columns[2].Visible = false;
            dgvListadoPersonal.Columns[8].Visible = false;
            //dgvListadoPersonal.Columns[9].Visible = false;
        }

        private void InsertarCargo()
        {
            if (!string.IsNullOrEmpty(txtCargoC.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldoPorHoraC.Text))
                {
                    LCargo lCargo = new LCargo();
                    DCargo dCargo = new DCargo();
                    lCargo.Cargo = txtCargoC.Text;
                    lCargo.SueldoPorHora = Convert.ToDouble(txtSueldoPorHoraC.Text);
                    if (dCargo.INSERTAR_CARGO(lCargo))
                    {
                        txtCargo.Clear();
                        MostrarCargos();
                        pnlCargos.Visible = false;
                    }  
                }
                else
                {
                    MessageBox.Show("Agrege el Sueldo", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agrege el Cargo", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void MostrarCargos()
        {
            DataTable dataTable = new DataTable();
            DCargo dCargo = new DCargo();
            dCargo.BUSCAR_CARGO(ref dataTable, txtCargo.Text);
            dgvListadoCargos.DataSource = dataTable;
            Bases.PerzonalizarDataGridView(ref dgvListadoCargos);
            //vamos a ocultar columnas, que seria el id, y el sueldo, se mostrara solo el cargo
            dgvListadoCargos.Columns[1].Visible = false;
            dgvListadoCargos.Columns[3].Visible = false;
            lblSueldo.Visible = false;
            dgvListadoCargos.Visible = true;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            MostrarCargos();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            pnlCargos.Visible = true;
            pnlCargos.Dock = DockStyle.Fill;
            //traemos alfrente un control
            pnlCargos.BringToFront();
            //enviar al fondo el control
            //pnlCargos.SendToBack();
            btnGuardarC.Visible = true;
            btnGuardarCambiosC.Visible = false;
            txtCargoC.Clear();
            txtSueldoPorHoraC.Clear();
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            InsertarCargo();
        }

        private void txtSueldoPorHoraC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoPorHoraC, e);
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSueldoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoHora, e);
        }

        private void dgvListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoCargos.Columns["EditarC"].Index)
            {
                ObtenerDatosCargoEditar();
            }

            if (e.ColumnIndex == dgvListadoCargos.Columns["Cargo"].Index)
            {
                ObtenerDatosCargos();
            }
        }

        private void ObtenerDatosCargos()
        {
            IdCargo = int.Parse(dgvListadoCargos.SelectedCells[1].Value.ToString());
            txtCargo.Text = dgvListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoHora.Text = dgvListadoCargos.SelectedCells[3].Value.ToString();
            dgvListadoCargos.Visible = false;
            flpGuardarPersonal.Visible = true;
            lblSueldo.Visible = true;
        }

        private void ObtenerDatosCargoEditar()
        {
            IdCargo = int.Parse(dgvListadoCargos.SelectedCells[1].Value.ToString());
            txtCargoC.Text = dgvListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoPorHoraC.Text = dgvListadoCargos.SelectedCells[3].Value.ToString();
            btnGuardarC.Visible = false;
            btnGuardarCambiosC.Visible = false;
            //que la barrita titilante, se posicione en el txtCargoC
            txtCargoC.Focus();
            //que se seleccione todo lo que esta en el txtCargoC
            txtCargoC.SelectAll();
            //hacemos visible el panel de cargos
            pnlCargos.Visible = true;
            pnlCargos.Dock = DockStyle.Fill;
            //traemos alfrente el panel
            pnlCargos.BringToFront();
        }

        private void btnRegresarCargo_Click(object sender, EventArgs e)
        {
            pnlCargos.Visible = false;
        }

        private void btnRegresarPersonal_Click(object sender, EventArgs e)
        {
            pnlRegistros.Visible = false;
            pnlPaginado.Visible = true;
        }

        private void btnGuardarCambiosC_Click(object sender, EventArgs e)
        {
            EditarCargo();
        }

        private void EditarCargo()
        {
            LCargo lcargo = new LCargo();
            DCargo dcargo = new DCargo();
            lcargo.Id_Cargo = IdCargo;
            lcargo.Cargo = txtCargoC.Text;
            lcargo.SueldoPorHora = double.Parse(txtSueldoPorHoraC.Text.ToString());
            if (dcargo.EDITAR_CARGO(lcargo))
            {
                txtCargo.Clear();
                MostrarCargos();
                pnlCargos.Visible = false;
            }
        }

        private void PersonalControl_Load(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }

        private void ReiniciarPaginado()
        {
            desde = 1;
            hasta = 10;
            Contar();
            if( contador > hasta)
            {
                btnSiguiente.Visible = true;
                btnAnterior.Visible = false;
                btnUltimaPagina.Visible = true;
                btnPrimeraPagina.Visible=false;
            }
            else
            {
                btnSiguiente.Visible = false;
                btnAnterior.Visible = false;
                btnUltimaPagina.Visible = false;
                btnPrimeraPagina.Visible = false;
            }
            Paginar();
        }

        private void dgvListadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Eliminar al personal?", "Eliminar Personal", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    EliminarPersonal();
                }
            }
            if (e.ColumnIndex == dgvListadoPersonal.Columns["Editar"].Index)
            {
                ObtenerDatosEditarPersonal();
            }
        }

        private void ObtenerDatosEditarPersonal()
        {
            IdPersonal = int.Parse(dgvListadoPersonal.SelectedCells[2].Value.ToString());
            EstadoPersonal = dgvListadoPersonal.SelectedCells[9].Value.ToString();
            if (EstadoPersonal == "ELIMINADO")
            {
                RestaurarPersonal();
            }
            else
            {
                localizarDGVCargos();
                txtNombre.Text = dgvListadoPersonal.SelectedCells[3].Value.ToString();
                txtIdentificacion.Text = dgvListadoPersonal.SelectedCells[4].Value.ToString();
                cbxPais.Text = dgvListadoPersonal.SelectedCells[5].Value.ToString();
                txtSueldoHora.Text = dgvListadoPersonal.SelectedCells[6].Value.ToString();
                txtCargo.Text = dgvListadoPersonal.SelectedCells[7].Value.ToString();
                IdCargo = int.Parse(dgvListadoPersonal.SelectedCells[8].Value.ToString());
                //txtNombre.Text = dgvListadoPersonal.SelectedCells[3].Value.ToString();
                //txtNombre.Text = dgvListadoPersonal.SelectedCells[3].Value.ToString();
                //Id_personal 2, Nombres 3, Identificacion 4, Pais 5, SueldoPorHora 6, Cargo 7, Id_Cargo 8, Estado 9, Codigo 10
                pnlPaginado.Visible = false;
                pnlRegistros.Visible = true;
                pnlRegistros.Dock = DockStyle.Fill;
                dgvListadoCargos.Visible = false;
                lblSueldo.Visible = true;
                flpGuardarPersonal.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnGuardarCambiosPersonal.Visible = true;
                pnlCargos.Visible = false;
            }
        }

        private void RestaurarPersonal()
        {
            DialogResult result = MessageBox.Show("Este personal se elimino, Desea Habilitarlo?", "Habilitar Personal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HabilitarPersonal();
            }
        }

        private void HabilitarPersonal()
        {
            LPersonal lpersonal = new LPersonal();
            DPersonal dpersonal = new DPersonal();
            lpersonal.Id_personal = IdPersonal;
            if (dpersonal.RESTAURAR_PERSONAL(lpersonal))
            {
                MostrarPersonal();
            }
        }

        private void EliminarPersonal()
        {
            IdPersonal = int.Parse(dgvListadoPersonal.SelectedCells[2].Value.ToString());
            LPersonal lpersonal = new LPersonal();
            DPersonal dpersonal = new DPersonal();
            lpersonal.Id_personal = IdPersonal;
            if (dpersonal.ELIMINAR_PERSONAL(lpersonal))
            {
                MostrarPersonal();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PerzonalizarDGVPersonal();
            //forma de apagar
            //timer1.Stop();
            timer1.Enabled = false;
        }

        private void btnGuardarCambiosPersonal_Click(object sender, EventArgs e)
        {
            EditarPerosnal();
        }

        private void EditarPerosnal()
        {
            LPersonal lpersonal = new LPersonal();
            DPersonal dpersonal = new DPersonal();
            lpersonal.Id_personal = IdPersonal;
            lpersonal.Nombres = txtNombre.Text;
            lpersonal.Identificacion = txtIdentificacion.Text;
            lpersonal.Pais = cbxPais.Text;
            lpersonal.Id_Cargo = IdCargo;
            lpersonal.SueldoPorHora = double.Parse(txtSueldoHora.Text);
            if (dpersonal.EDITAR_PERSONAL(lpersonal))
            {
                MostrarPersonal();
                pnlRegistros.Visible = false;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            desde += 10;
            hasta += 10;
            MostrarPersonal();
            Contar();
            if(contador > hasta)
            {
                btnSiguiente.Visible = true;
                btnAnterior.Visible = true;
            }
            else
            {
                btnSiguiente.Visible = false;
                btnAnterior.Visible = true;
            }
            Paginar();
        }

        private void Contar()
        {
            DPersonal dPersonal = new DPersonal();
            dPersonal.CONTARPERSONAL(ref contador);
        }

        private void Paginar()
        {
            try
            {
                lblPagina.Text = (hasta / ItemsPorPagina).ToString();
                //( Ceiling ), trae la parte entera
                lblTotalPaginas.Text = Math.Ceiling(Convert.ToSingle((contador / ItemsPorPagina) + 1)).ToString();
                totalPaginas = Convert.ToInt32(lblTotalPaginas.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta -= 10;
            MostrarPersonal();
            Contar();
            if(contador > hasta)
            {
                btnSiguiente.Visible = true;
                btnAnterior.Visible = true;
            }
            else
            {
                btnSiguiente.Visible = false;
                btnAnterior.Visible = true;
            }
            if (desde == 1)
            {
                ReiniciarPaginado();
            }
            Paginar();
        }

        private void btnUltimaPagina_Click(object sender, EventArgs e)
        {
            hasta = totalPaginas * ItemsPorPagina;
            desde = hasta - 9;
            MostrarPersonal();
            Contar();
            if (contador > hasta)
            {
                btnSiguiente.Visible = true;
                btnAnterior.Visible = true;
            }
            else
            {
                btnSiguiente.Visible = false;
                btnAnterior.Visible = true;
            }
            Paginar();
        }

        private void btnPrimeraPagina_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonal();
        }

        private void BuscarPersonal()
        {
            DataTable dataTable = new DataTable();
            DPersonal dPersonal = new DPersonal();
            dPersonal.BUSCAR_PERSONAL(ref dataTable, desde, hasta, txtBuscar.Text);
            dgvListadoPersonal.DataSource = dataTable;
            PerzonalizarDGVPersonal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }
    }
}
