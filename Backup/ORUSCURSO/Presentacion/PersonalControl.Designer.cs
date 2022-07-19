namespace ORUSCURSO.Presentacion
{
    partial class PersonalControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvListadoPersonal = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlPaginado = new System.Windows.Forms.Panel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeraPagina = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimaPagina = new System.Windows.Forms.Button();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.dgvListadoCargos = new System.Windows.Forms.DataGridView();
            this.EditarC = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlCargos = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.btnGuardarCambiosC = new System.Windows.Forms.Button();
            this.btnRegresarCargo = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSueldoPorHoraC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCargoC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegresarPersonal = new System.Windows.Forms.Button();
            this.flpGuardarPersonal = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.btnGuardarCambiosPersonal = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSueldoHora = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPersonal)).BeginInit();
            this.pnlPaginado.SuspendLayout();
            this.pnlRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCargos)).BeginInit();
            this.pnlCargos.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flpGuardarPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlHead.Controls.Add(this.btnMostrarTodos);
            this.pnlHead.Controls.Add(this.btnAgregar);
            this.pnlHead.Controls.Add(this.pictureBox1);
            this.pnlHead.Controls.Add(this.panel1);
            this.pnlHead.Controls.Add(this.txtBuscar);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(992, 70);
            this.pnlHead.TabIndex = 0;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodos.Location = new System.Drawing.Point(326, 15);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(156, 34);
            this.btnMostrarTodos.TabIndex = 17;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnAgregar.BackgroundImage = global::ORUSCURSO.Properties.Resources.anadir;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(890, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 64);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ORUSCURSO.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(265, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(16, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 2);
            this.panel1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(16, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(233, 19);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvListadoPersonal
            // 
            this.dgvListadoPersonal.AllowUserToAddRows = false;
            this.dgvListadoPersonal.AllowUserToDeleteRows = false;
            this.dgvListadoPersonal.AllowUserToResizeRows = false;
            this.dgvListadoPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvListadoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.dgvListadoPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoPersonal.Location = new System.Drawing.Point(0, 70);
            this.dgvListadoPersonal.Name = "dgvListadoPersonal";
            this.dgvListadoPersonal.ReadOnly = true;
            this.dgvListadoPersonal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvListadoPersonal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListadoPersonal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListadoPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvListadoPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListadoPersonal.RowTemplate.Height = 40;
            this.dgvListadoPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPersonal.Size = new System.Drawing.Size(992, 367);
            this.dgvListadoPersonal.TabIndex = 1;
            this.dgvListadoPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoPersonal_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::ORUSCURSO.Properties.Resources.basura;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::ORUSCURSO.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // pnlPaginado
            // 
            this.pnlPaginado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnlPaginado.Controls.Add(this.btnAnterior);
            this.pnlPaginado.Controls.Add(this.btnPrimeraPagina);
            this.pnlPaginado.Controls.Add(this.btnSiguiente);
            this.pnlPaginado.Controls.Add(this.btnUltimaPagina);
            this.pnlPaginado.Controls.Add(this.lblTotalPaginas);
            this.pnlPaginado.Controls.Add(this.label9);
            this.pnlPaginado.Controls.Add(this.lblPagina);
            this.pnlPaginado.Controls.Add(this.label6);
            this.pnlPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPaginado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPaginado.Location = new System.Drawing.Point(0, 437);
            this.pnlPaginado.Name = "pnlPaginado";
            this.pnlPaginado.Size = new System.Drawing.Size(992, 77);
            this.pnlPaginado.TabIndex = 2;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(216)))), ((int)(((byte)(84)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Location = new System.Drawing.Point(254, 15);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(166, 45);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Página Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeraPagina
            // 
            this.btnPrimeraPagina.BackColor = System.Drawing.Color.Gray;
            this.btnPrimeraPagina.FlatAppearance.BorderSize = 0;
            this.btnPrimeraPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeraPagina.Location = new System.Drawing.Point(761, 15);
            this.btnPrimeraPagina.Name = "btnPrimeraPagina";
            this.btnPrimeraPagina.Size = new System.Drawing.Size(138, 45);
            this.btnPrimeraPagina.TabIndex = 7;
            this.btnPrimeraPagina.Text = "Primera Página";
            this.btnPrimeraPagina.UseVisualStyleBackColor = false;
            this.btnPrimeraPagina.Click += new System.EventHandler(this.btnPrimeraPagina_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(216)))), ((int)(((byte)(84)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(76, 15);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(157, 45);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Página Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimaPagina
            // 
            this.btnUltimaPagina.BackColor = System.Drawing.Color.Gray;
            this.btnUltimaPagina.FlatAppearance.BorderSize = 0;
            this.btnUltimaPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaPagina.Location = new System.Drawing.Point(619, 15);
            this.btnUltimaPagina.Name = "btnUltimaPagina";
            this.btnUltimaPagina.Size = new System.Drawing.Size(136, 45);
            this.btnUltimaPagina.TabIndex = 6;
            this.btnUltimaPagina.Text = "Última Página";
            this.btnUltimaPagina.UseVisualStyleBackColor = false;
            this.btnUltimaPagina.Click += new System.EventHandler(this.btnUltimaPagina_Click);
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.AutoSize = true;
            this.lblTotalPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaginas.ForeColor = System.Drawing.Color.Silver;
            this.lblTotalPaginas.Location = new System.Drawing.Point(571, 36);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(19, 20);
            this.lblTotalPaginas.TabIndex = 5;
            this.lblTotalPaginas.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(538, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "de";
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.ForeColor = System.Drawing.Color.Silver;
            this.lblPagina.Location = new System.Drawing.Point(513, 36);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(19, 20);
            this.lblPagina.TabIndex = 2;
            this.lblPagina.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(449, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Página";
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlRegistros.Controls.Add(this.dgvListadoCargos);
            this.pnlRegistros.Controls.Add(this.pnlCargos);
            this.pnlRegistros.Controls.Add(this.btnRegresarPersonal);
            this.pnlRegistros.Controls.Add(this.flpGuardarPersonal);
            this.pnlRegistros.Controls.Add(this.btnAgregarCargo);
            this.pnlRegistros.Controls.Add(this.cbxPais);
            this.pnlRegistros.Controls.Add(this.panel7);
            this.pnlRegistros.Controls.Add(this.txtSueldoHora);
            this.pnlRegistros.Controls.Add(this.panel6);
            this.pnlRegistros.Controls.Add(this.txtCargo);
            this.pnlRegistros.Controls.Add(this.panel4);
            this.pnlRegistros.Controls.Add(this.txtIdentificacion);
            this.pnlRegistros.Controls.Add(this.panel3);
            this.pnlRegistros.Controls.Add(this.txtNombre);
            this.pnlRegistros.Controls.Add(this.label5);
            this.pnlRegistros.Controls.Add(this.label4);
            this.pnlRegistros.Controls.Add(this.lblSueldo);
            this.pnlRegistros.Controls.Add(this.label2);
            this.pnlRegistros.Controls.Add(this.label1);
            this.pnlRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegistros.Location = new System.Drawing.Point(3, 91);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(966, 340);
            this.pnlRegistros.TabIndex = 3;
            this.pnlRegistros.Visible = false;
            this.pnlRegistros.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvListadoCargos
            // 
            this.dgvListadoCargos.AllowUserToAddRows = false;
            this.dgvListadoCargos.AllowUserToDeleteRows = false;
            this.dgvListadoCargos.AllowUserToResizeRows = false;
            this.dgvListadoCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCargos.ColumnHeadersVisible = false;
            this.dgvListadoCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarC});
            this.dgvListadoCargos.Location = new System.Drawing.Point(360, 223);
            this.dgvListadoCargos.Name = "dgvListadoCargos";
            this.dgvListadoCargos.ReadOnly = true;
            this.dgvListadoCargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvListadoCargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dgvListadoCargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListadoCargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvListadoCargos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListadoCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoCargos.Size = new System.Drawing.Size(266, 94);
            this.dgvListadoCargos.TabIndex = 19;
            this.dgvListadoCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoCargos_CellClick);
            // 
            // EditarC
            // 
            this.EditarC.HeaderText = "";
            this.EditarC.Image = global::ORUSCURSO.Properties.Resources.editar;
            this.EditarC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarC.Name = "EditarC";
            this.EditarC.ReadOnly = true;
            // 
            // pnlCargos
            // 
            this.pnlCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlCargos.Controls.Add(this.flowLayoutPanel2);
            this.pnlCargos.Controls.Add(this.panel9);
            this.pnlCargos.Controls.Add(this.txtSueldoPorHoraC);
            this.pnlCargos.Controls.Add(this.label11);
            this.pnlCargos.Controls.Add(this.panel8);
            this.pnlCargos.Controls.Add(this.txtCargoC);
            this.pnlCargos.Controls.Add(this.label10);
            this.pnlCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCargos.Location = new System.Drawing.Point(616, 111);
            this.pnlCargos.Name = "pnlCargos";
            this.pnlCargos.Size = new System.Drawing.Size(337, 193);
            this.pnlCargos.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnGuardarC);
            this.flowLayoutPanel2.Controls.Add(this.btnGuardarCambiosC);
            this.flowLayoutPanel2.Controls.Add(this.btnRegresarCargo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 126);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(308, 54);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(0)))));
            this.btnGuardarC.FlatAppearance.BorderSize = 0;
            this.btnGuardarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.ForeColor = System.Drawing.Color.White;
            this.btnGuardarC.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(120, 42);
            this.btnGuardarC.TabIndex = 0;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = false;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // btnGuardarCambiosC
            // 
            this.btnGuardarCambiosC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(0)))));
            this.btnGuardarCambiosC.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambiosC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambiosC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambiosC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosC.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambiosC.Location = new System.Drawing.Point(129, 3);
            this.btnGuardarCambiosC.Name = "btnGuardarCambiosC";
            this.btnGuardarCambiosC.Size = new System.Drawing.Size(115, 42);
            this.btnGuardarCambiosC.TabIndex = 1;
            this.btnGuardarCambiosC.Text = "Guardar *";
            this.btnGuardarCambiosC.UseVisualStyleBackColor = false;
            this.btnGuardarCambiosC.Click += new System.EventHandler(this.btnGuardarCambiosC_Click);
            // 
            // btnRegresarCargo
            // 
            this.btnRegresarCargo.BackgroundImage = global::ORUSCURSO.Properties.Resources.regreso;
            this.btnRegresarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresarCargo.FlatAppearance.BorderSize = 0;
            this.btnRegresarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarCargo.Location = new System.Drawing.Point(250, 3);
            this.btnRegresarCargo.Name = "btnRegresarCargo";
            this.btnRegresarCargo.Size = new System.Drawing.Size(50, 42);
            this.btnRegresarCargo.TabIndex = 19;
            this.btnRegresarCargo.UseVisualStyleBackColor = true;
            this.btnRegresarCargo.Click += new System.EventHandler(this.btnRegresarCargo_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(144, 87);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(122, 1);
            this.panel9.TabIndex = 18;
            // 
            // txtSueldoPorHoraC
            // 
            this.txtSueldoPorHoraC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtSueldoPorHoraC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoPorHoraC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoPorHoraC.ForeColor = System.Drawing.Color.White;
            this.txtSueldoPorHoraC.Location = new System.Drawing.Point(144, 62);
            this.txtSueldoPorHoraC.Name = "txtSueldoPorHoraC";
            this.txtSueldoPorHoraC.Size = new System.Drawing.Size(122, 19);
            this.txtSueldoPorHoraC.TabIndex = 17;
            this.txtSueldoPorHoraC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoPorHoraC_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Sueldo por Hora:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(144, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(177, 1);
            this.panel8.TabIndex = 15;
            // 
            // txtCargoC
            // 
            this.txtCargoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtCargoC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoC.ForeColor = System.Drawing.Color.White;
            this.txtCargoC.Location = new System.Drawing.Point(144, 13);
            this.txtCargoC.Name = "txtCargoC";
            this.txtCargoC.Size = new System.Drawing.Size(177, 19);
            this.txtCargoC.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(82, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Cargo:";
            // 
            // btnRegresarPersonal
            // 
            this.btnRegresarPersonal.BackgroundImage = global::ORUSCURSO.Properties.Resources.regreso;
            this.btnRegresarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresarPersonal.FlatAppearance.BorderSize = 0;
            this.btnRegresarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarPersonal.Location = new System.Drawing.Point(572, 21);
            this.btnRegresarPersonal.Name = "btnRegresarPersonal";
            this.btnRegresarPersonal.Size = new System.Drawing.Size(50, 42);
            this.btnRegresarPersonal.TabIndex = 18;
            this.btnRegresarPersonal.UseVisualStyleBackColor = true;
            this.btnRegresarPersonal.Click += new System.EventHandler(this.btnRegresarPersonal_Click);
            // 
            // flpGuardarPersonal
            // 
            this.flpGuardarPersonal.Controls.Add(this.btnGuardarPersonal);
            this.flpGuardarPersonal.Controls.Add(this.btnGuardarCambiosPersonal);
            this.flpGuardarPersonal.Location = new System.Drawing.Point(188, 268);
            this.flpGuardarPersonal.Name = "flpGuardarPersonal";
            this.flpGuardarPersonal.Size = new System.Drawing.Size(267, 49);
            this.flpGuardarPersonal.TabIndex = 17;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(0)))));
            this.btnGuardarPersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardarPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersonal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPersonal.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(127, 42);
            this.btnGuardarPersonal.TabIndex = 0;
            this.btnGuardarPersonal.Text = "Guardar";
            this.btnGuardarPersonal.UseVisualStyleBackColor = false;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // btnGuardarCambiosPersonal
            // 
            this.btnGuardarCambiosPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(0)))));
            this.btnGuardarCambiosPersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambiosPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambiosPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambiosPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosPersonal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambiosPersonal.Location = new System.Drawing.Point(136, 3);
            this.btnGuardarCambiosPersonal.Name = "btnGuardarCambiosPersonal";
            this.btnGuardarCambiosPersonal.Size = new System.Drawing.Size(127, 42);
            this.btnGuardarCambiosPersonal.TabIndex = 1;
            this.btnGuardarCambiosPersonal.Text = "Guardar *";
            this.btnGuardarCambiosPersonal.UseVisualStyleBackColor = false;
            this.btnGuardarCambiosPersonal.Click += new System.EventHandler(this.btnGuardarCambiosPersonal_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.FlatAppearance.BorderSize = 0;
            this.btnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCargo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCargo.Location = new System.Drawing.Point(426, 171);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(136, 34);
            this.btnAgregarCargo.TabIndex = 16;
            this.btnAgregarCargo.Text = "+ Agregar cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Items.AddRange(new object[] {
            "Argentina: español.",
            "Bolivia: español.",
            "Brasil: portugués.",
            "Chile: español.",
            "Colombia: español.",
            "Costa Rica: español.",
            "Cuba: español.",
            "Ecuador: español.",
            "El Salvador: español.",
            "Guatemala: español.",
            "Haití: francés.",
            "Honduras: español.",
            "México: español.",
            "Nicaragua: español.",
            "Panamá: español.",
            "Paraguay: español.",
            "Perú: español.",
            "República Dominicana: español.",
            "Uruguay: español.",
            "Venezuela: español."});
            this.cbxPais.Location = new System.Drawing.Point(189, 128);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(199, 28);
            this.cbxPais.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(191, 254);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(127, 1);
            this.panel7.TabIndex = 14;
            // 
            // txtSueldoHora
            // 
            this.txtSueldoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtSueldoHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoHora.ForeColor = System.Drawing.Color.White;
            this.txtSueldoHora.Location = new System.Drawing.Point(191, 229);
            this.txtSueldoHora.Name = "txtSueldoHora";
            this.txtSueldoHora.Size = new System.Drawing.Size(127, 19);
            this.txtSueldoHora.TabIndex = 5;
            this.txtSueldoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoHora_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(188, 201);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 1);
            this.panel6.TabIndex = 12;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.White;
            this.txtCargo.Location = new System.Drawing.Point(188, 176);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(198, 19);
            this.txtCargo.TabIndex = 4;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargo_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(188, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 1);
            this.panel4.TabIndex = 8;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(188, 70);
            this.txtIdentificacion.Multiline = true;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(198, 20);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(188, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 1);
            this.panel3.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(188, 20);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(377, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(139, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pais:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.ForeColor = System.Drawing.Color.White;
            this.lblSueldo.Location = new System.Drawing.Point(53, 229);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(129, 20);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo por Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacón:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres y Apellidos:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ORUSCURSO.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ORUSCURSO.Properties.Resources.editar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::ORUSCURSO.Properties.Resources.editar;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PersonalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegistros);
            this.Controls.Add(this.dgvListadoPersonal);
            this.Controls.Add(this.pnlPaginado);
            this.Controls.Add(this.pnlHead);
            this.Name = "PersonalControl";
            this.Size = new System.Drawing.Size(992, 514);
            this.Load += new System.EventHandler(this.PersonalControl_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPersonal)).EndInit();
            this.pnlPaginado.ResumeLayout(false);
            this.pnlPaginado.PerformLayout();
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCargos)).EndInit();
            this.pnlCargos.ResumeLayout(false);
            this.pnlCargos.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flpGuardarPersonal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.DataGridView dgvListadoPersonal;
        private System.Windows.Forms.Panel pnlPaginado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pnlRegistros;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtSueldoHora;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Button btnRegresarPersonal;
        private System.Windows.Forms.FlowLayoutPanel flpGuardarPersonal;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Button btnGuardarCambiosPersonal;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lblTotalPaginas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimeraPagina;
        private System.Windows.Forms.Button btnUltimaPagina;
        private System.Windows.Forms.Panel pnlCargos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnGuardarCambiosC;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSueldoPorHoraC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCargoC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvListadoCargos;
        private System.Windows.Forms.DataGridViewImageColumn EditarC;
        private System.Windows.Forms.Button btnRegresarCargo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Timer timer1;
    }
}
