namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    partial class Instalacion_de_Base_de_Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instalacion_de_Base_de_Datos));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInstalarServidor = new System.Windows.Forms.Panel();
            this.pnlContadores = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlTemporizador = new System.Windows.Forms.Panel();
            this.lblMilisegundo = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensajeInstalacion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.pnlAsistenteInstalacion = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtxCrearUsuarioBD = new System.Windows.Forms.RichTextBox();
            this.rtxServidor = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxCrearProcedimiento = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxEliminarBD = new System.Windows.Forms.RichTextBox();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNameBD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPasswordBD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.TimerCRARINI = new System.Windows.Forms.Timer(this.components);
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlInstalarServidor.SuspendLayout();
            this.pnlContadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlTemporizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAsistenteInstalacion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1453, 78);
            this.pnlLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ORUSCURSO.Properties.Resources.logoSistema;
            this.pictureBox1.Location = new System.Drawing.Point(1353, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index SDJT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInstalarServidor
            // 
            this.pnlInstalarServidor.Controls.Add(this.pnlContadores);
            this.pnlInstalarServidor.Controls.Add(this.btnPrincipal);
            this.pnlInstalarServidor.Location = new System.Drawing.Point(95, 84);
            this.pnlInstalarServidor.Name = "pnlInstalarServidor";
            this.pnlInstalarServidor.Size = new System.Drawing.Size(587, 524);
            this.pnlInstalarServidor.TabIndex = 3;
            // 
            // pnlContadores
            // 
            this.pnlContadores.Controls.Add(this.pictureBox3);
            this.pnlContadores.Controls.Add(this.pnlTemporizador);
            this.pnlContadores.Controls.Add(this.lblMensajeInstalacion);
            this.pnlContadores.Controls.Add(this.pictureBox2);
            this.pnlContadores.Location = new System.Drawing.Point(4, 60);
            this.pnlContadores.Name = "pnlContadores";
            this.pnlContadores.Size = new System.Drawing.Size(580, 461);
            this.pnlContadores.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ORUSCURSO.Properties.Resources.Loading;
            this.pictureBox3.Location = new System.Drawing.Point(213, 337);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pnlTemporizador
            // 
            this.pnlTemporizador.Controls.Add(this.lblMilisegundo);
            this.pnlTemporizador.Controls.Add(this.lblSegundo);
            this.pnlTemporizador.Controls.Add(this.label5);
            this.pnlTemporizador.Controls.Add(this.label4);
            this.pnlTemporizador.Controls.Add(this.label3);
            this.pnlTemporizador.Location = new System.Drawing.Point(-2, 258);
            this.pnlTemporizador.Name = "pnlTemporizador";
            this.pnlTemporizador.Size = new System.Drawing.Size(579, 71);
            this.pnlTemporizador.TabIndex = 10;
            // 
            // lblMilisegundo
            // 
            this.lblMilisegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisegundo.ForeColor = System.Drawing.Color.Gray;
            this.lblMilisegundo.Location = new System.Drawing.Point(430, 35);
            this.lblMilisegundo.Name = "lblMilisegundo";
            this.lblMilisegundo.Size = new System.Drawing.Size(48, 35);
            this.lblMilisegundo.TabIndex = 4;
            this.lblMilisegundo.Text = "00";
            this.lblMilisegundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSegundo
            // 
            this.lblSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.Color.Gray;
            this.lblSegundo.Location = new System.Drawing.Point(345, 35);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(48, 35);
            this.lblSegundo.TabIndex = 3;
            this.lblSegundo.Text = "00";
            this.lblSegundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(430, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Seg";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(345, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Min";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 71);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiempo estimado: 6 minutos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensajeInstalacion
            // 
            this.lblMensajeInstalacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensajeInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeInstalacion.ForeColor = System.Drawing.Color.White;
            this.lblMensajeInstalacion.Location = new System.Drawing.Point(-2, 86);
            this.lblMensajeInstalacion.Name = "lblMensajeInstalacion";
            this.lblMensajeInstalacion.Size = new System.Drawing.Size(579, 169);
            this.lblMensajeInstalacion.TabIndex = 9;
            this.lblMensajeInstalacion.Text = "Instalando Servidor...\r\n\r\nNo cierre esta ventana, se cerrara Automaticamente cuan" +
    "do este todo Listo";
            this.lblMensajeInstalacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ORUSCURSO.Properties.Resources.advertencia;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(579, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrincipal.Location = new System.Drawing.Point(163, -2);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(308, 61);
            this.btnPrincipal.TabIndex = 3;
            this.btnPrincipal.Text = "Intalar Servidor";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            // 
            // pnlAsistenteInstalacion
            // 
            this.pnlAsistenteInstalacion.Controls.Add(this.groupBox3);
            this.pnlAsistenteInstalacion.Controls.Add(this.rtxServidor);
            this.pnlAsistenteInstalacion.Controls.Add(this.groupBox2);
            this.pnlAsistenteInstalacion.Controls.Add(this.groupBox1);
            this.pnlAsistenteInstalacion.Controls.Add(this.txtScript);
            this.pnlAsistenteInstalacion.Controls.Add(this.label12);
            this.pnlAsistenteInstalacion.Controls.Add(this.txtNameBD);
            this.pnlAsistenteInstalacion.Controls.Add(this.label11);
            this.pnlAsistenteInstalacion.Controls.Add(this.txtPasswordBD);
            this.pnlAsistenteInstalacion.Controls.Add(this.label10);
            this.pnlAsistenteInstalacion.Controls.Add(this.txtUsuario);
            this.pnlAsistenteInstalacion.Controls.Add(this.label9);
            this.pnlAsistenteInstalacion.Controls.Add(this.txtInstancia);
            this.pnlAsistenteInstalacion.Controls.Add(this.label8);
            this.pnlAsistenteInstalacion.Location = new System.Drawing.Point(702, 87);
            this.pnlAsistenteInstalacion.Name = "pnlAsistenteInstalacion";
            this.pnlAsistenteInstalacion.Size = new System.Drawing.Size(717, 521);
            this.pnlAsistenteInstalacion.TabIndex = 4;
            this.pnlAsistenteInstalacion.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxCrearUsuarioBD);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(436, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 312);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servira para Crear un Usuario para el Servidor - NO TOCAR";
            // 
            // rtxCrearUsuarioBD
            // 
            this.rtxCrearUsuarioBD.Location = new System.Drawing.Point(6, 28);
            this.rtxCrearUsuarioBD.Name = "rtxCrearUsuarioBD";
            this.rtxCrearUsuarioBD.Size = new System.Drawing.Size(245, 278);
            this.rtxCrearUsuarioBD.TabIndex = 0;
            this.rtxCrearUsuarioBD.Text = resources.GetString("rtxCrearUsuarioBD.Text");
            // 
            // rtxServidor
            // 
            this.rtxServidor.Location = new System.Drawing.Point(22, 365);
            this.rtxServidor.Name = "rtxServidor";
            this.rtxServidor.Size = new System.Drawing.Size(389, 139);
            this.rtxServidor.TabIndex = 12;
            this.rtxServidor.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxCrearProcedimiento);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(22, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 163);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pega tu Script para Crear las Tablas y Procedimientos";
            // 
            // rtxCrearProcedimiento
            // 
            this.rtxCrearProcedimiento.Location = new System.Drawing.Point(6, 19);
            this.rtxCrearProcedimiento.Name = "rtxCrearProcedimiento";
            this.rtxCrearProcedimiento.Size = new System.Drawing.Size(377, 138);
            this.rtxCrearProcedimiento.TabIndex = 0;
            this.rtxCrearProcedimiento.Text = resources.GetString("rtxCrearProcedimiento.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxEliminarBD);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(366, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script para Eliminar la Base de Datos";
            // 
            // rtxEliminarBD
            // 
            this.rtxEliminarBD.Location = new System.Drawing.Point(6, 19);
            this.rtxEliminarBD.Name = "rtxEliminarBD";
            this.rtxEliminarBD.Size = new System.Drawing.Size(278, 121);
            this.rtxEliminarBD.TabIndex = 0;
            this.rtxEliminarBD.Text = "ALTER DATABASE BASE_INDEX SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE B" +
    "ASE_INDEX";
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(133, 148);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(149, 20);
            this.txtScript.TabIndex = 9;
            this.txtScript.Text = "ScriptTest";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(32, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nombre de Script:";
            // 
            // txtNameBD
            // 
            this.txtNameBD.Location = new System.Drawing.Point(133, 119);
            this.txtNameBD.Name = "txtNameBD";
            this.txtNameBD.Size = new System.Drawing.Size(149, 20);
            this.txtNameBD.TabIndex = 7;
            this.txtNameBD.Text = "TestBD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(47, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Base de Datos:";
            // 
            // txtPasswordBD
            // 
            this.txtPasswordBD.Location = new System.Drawing.Point(133, 86);
            this.txtPasswordBD.Name = "txtPasswordBD";
            this.txtPasswordBD.Size = new System.Drawing.Size(149, 20);
            this.txtPasswordBD.TabIndex = 5;
            this.txtPasswordBD.Text = "David123";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(39, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Contraseña SQL:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(133, 54);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(149, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "David";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(81, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Usuario:";
            // 
            // txtInstancia
            // 
            this.txtInstancia.Location = new System.Drawing.Point(133, 23);
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(149, 20);
            this.txtInstancia.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(19, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre de Instancia:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // TimerCRARINI
            // 
            this.TimerCRARINI.Interval = 10;
            // 
            // Instalacion_de_Base_de_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1453, 620);
            this.Controls.Add(this.pnlAsistenteInstalacion);
            this.Controls.Add(this.pnlInstalarServidor);
            this.Controls.Add(this.pnlLogo);
            this.Name = "Instalacion_de_Base_de_Datos";
            this.Text = "Instalacion de Base de Datos";
            this.Load += new System.EventHandler(this.Instalacion_de_Base_de_Datos_Load);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlInstalarServidor.ResumeLayout(false);
            this.pnlContadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlTemporizador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAsistenteInstalacion.ResumeLayout(false);
            this.pnlAsistenteInstalacion.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInstalarServidor;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel pnlAsistenteInstalacion;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNameBD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPasswordBD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxCrearProcedimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxEliminarBD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxCrearUsuarioBD;
        private System.Windows.Forms.RichTextBox rtxServidor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer TimerCRARINI;
        private System.Windows.Forms.Panel pnlContadores;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlTemporizador;
        private System.Windows.Forms.Label lblMilisegundo;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMensajeInstalacion;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}