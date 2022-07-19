namespace ORUSCURSO.Presentacion
{
    partial class TomarAsistencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRegistroAsistencia = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlObservacion = new System.Windows.Forms.Panel();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.rtxObervacion = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.pnlHead.SuspendLayout();
            this.pnlRegistroAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlObservacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlHead.Controls.Add(this.btnIniciarSesion);
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1016, 60);
            this.pnlHead.TabIndex = 1;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnIniciarSesion.Location = new System.Drawing.Point(840, 0);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(176, 60);
            this.btnIniciarSesion.TabIndex = 19;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 60);
            this.label1.TabIndex = 18;
            this.label1.Text = "Index SDJT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRegistroAsistencia
            // 
            this.pnlRegistroAsistencia.Controls.Add(this.lblHora);
            this.pnlRegistroAsistencia.Controls.Add(this.lblFecha);
            this.pnlRegistroAsistencia.Controls.Add(this.pictureBox1);
            this.pnlRegistroAsistencia.Controls.Add(this.lblNombre);
            this.pnlRegistroAsistencia.Controls.Add(this.lblAviso);
            this.pnlRegistroAsistencia.Controls.Add(this.label5);
            this.pnlRegistroAsistencia.Controls.Add(this.label4);
            this.pnlRegistroAsistencia.Controls.Add(this.panel4);
            this.pnlRegistroAsistencia.Controls.Add(this.txtIdentificacion);
            this.pnlRegistroAsistencia.Controls.Add(this.label3);
            this.pnlRegistroAsistencia.Controls.Add(this.label2);
            this.pnlRegistroAsistencia.Location = new System.Drawing.Point(357, 66);
            this.pnlRegistroAsistencia.Name = "pnlRegistroAsistencia";
            this.pnlRegistroAsistencia.Size = new System.Drawing.Size(485, 469);
            this.pnlRegistroAsistencia.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Gray;
            this.lblHora.Location = new System.Drawing.Point(130, 317);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(39, 20);
            this.lblHora.TabIndex = 31;
            this.lblHora.Text = "Hoa";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(130, 276);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 30;
            this.lblFecha.Text = "Fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ORUSCURSO.Properties.Resources.logoSistema;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(3, 394);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(479, 30);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "***";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(0)))));
            this.lblAviso.Location = new System.Drawing.Point(3, 358);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(479, 36);
            this.lblAviso.TabIndex = 27;
            this.lblAviso.Text = "********";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(134, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 1);
            this.panel4.TabIndex = 22;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(134, 222);
            this.txtIdentificacion.Multiline = true;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(198, 20);
            this.txtIdentificacion.TabIndex = 21;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Identificacón:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "REGISTRO DE ASISTENCIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlObservacion
            // 
            this.pnlObservacion.Controls.Add(this.btnGuardarPersonal);
            this.pnlObservacion.Controls.Add(this.rtxObervacion);
            this.pnlObservacion.Controls.Add(this.label8);
            this.pnlObservacion.Location = new System.Drawing.Point(39, 112);
            this.pnlObservacion.Name = "pnlObservacion";
            this.pnlObservacion.Size = new System.Drawing.Size(280, 348);
            this.pnlObservacion.TabIndex = 3;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(177)))));
            this.btnGuardarPersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardarPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersonal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPersonal.Location = new System.Drawing.Point(0, 256);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(127, 42);
            this.btnGuardarPersonal.TabIndex = 22;
            this.btnGuardarPersonal.Text = "Guardar";
            this.btnGuardarPersonal.UseVisualStyleBackColor = false;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // rtxObervacion
            // 
            this.rtxObervacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.rtxObervacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxObervacion.Location = new System.Drawing.Point(0, 36);
            this.rtxObervacion.Name = "rtxObervacion";
            this.rtxObervacion.Size = new System.Drawing.Size(280, 214);
            this.rtxObervacion.TabIndex = 21;
            this.rtxObervacion.Text = "";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 36);
            this.label8.TabIndex = 20;
            this.label8.Text = "Observación";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // TomarAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1016, 547);
            this.Controls.Add(this.pnlObservacion);
            this.Controls.Add(this.pnlRegistroAsistencia);
            this.Controls.Add(this.pnlHead);
            this.Name = "TomarAsistencias";
            this.Text = "TomarAsistencias";
            this.Load += new System.EventHandler(this.TomarAsistencias_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlRegistroAsistencia.ResumeLayout(false);
            this.pnlRegistroAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlObservacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel pnlRegistroAsistencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel pnlObservacion;
        private System.Windows.Forms.RichTextBox rtxObervacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
    }
}