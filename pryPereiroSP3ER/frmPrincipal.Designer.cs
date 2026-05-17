namespace pryPereiroSP3ER
{
    partial class frmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpbMaquinas = new System.Windows.Forms.GroupBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdMaquina = new System.Windows.Forms.TextBox();
            this.lblIdMaquina = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHoraTrabajo = new System.Windows.Forms.TextBox();
            this.lblHorasTrabajo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtIdMaquinaOP = new System.Windows.Forms.TextBox();
            this.lblIdMaquinaOP = new System.Windows.Forms.Label();
            this.txtIdOrden = new System.Windows.Forms.TextBox();
            this.lblIdOrden = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.gpbMaquinas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(141, 25);
            this.toolStripStatusLabel1.Text = "● Desconectado";
            // 
            // gpbMaquinas
            // 
            this.gpbMaquinas.Controls.Add(this.txtCapacidad);
            this.gpbMaquinas.Controls.Add(this.lblCapacidad);
            this.gpbMaquinas.Controls.Add(this.txtNombre);
            this.gpbMaquinas.Controls.Add(this.lblNombre);
            this.gpbMaquinas.Controls.Add(this.txtIdMaquina);
            this.gpbMaquinas.Controls.Add(this.lblIdMaquina);
            this.gpbMaquinas.Location = new System.Drawing.Point(6, 6);
            this.gpbMaquinas.Name = "gpbMaquinas";
            this.gpbMaquinas.Size = new System.Drawing.Size(834, 124);
            this.gpbMaquinas.TabIndex = 1;
            this.gpbMaquinas.TabStop = false;
            this.gpbMaquinas.Text = "Maquinas";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(649, 51);
            this.txtCapacidad.MaxLength = 10;
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(163, 26);
            this.txtCapacidad.TabIndex = 6;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(554, 54);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(89, 20);
            this.lblCapacidad.TabIndex = 5;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(331, 51);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(252, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtIdMaquina
            // 
            this.txtIdMaquina.Location = new System.Drawing.Point(118, 51);
            this.txtIdMaquina.MaxLength = 3;
            this.txtIdMaquina.Name = "txtIdMaquina";
            this.txtIdMaquina.Size = new System.Drawing.Size(84, 26);
            this.txtIdMaquina.TabIndex = 2;
            // 
            // lblIdMaquina
            // 
            this.lblIdMaquina.AutoSize = true;
            this.lblIdMaquina.Location = new System.Drawing.Point(16, 54);
            this.lblIdMaquina.Name = "lblIdMaquina";
            this.lblIdMaquina.Size = new System.Drawing.Size(96, 20);
            this.lblIdMaquina.TabIndex = 0;
            this.lblIdMaquina.Text = "Id Máquina: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHoraTrabajo);
            this.groupBox2.Controls.Add(this.lblHorasTrabajo);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.txtIdMaquinaOP);
            this.groupBox2.Controls.Add(this.lblIdMaquinaOP);
            this.groupBox2.Controls.Add(this.txtIdOrden);
            this.groupBox2.Controls.Add(this.lblIdOrden);
            this.groupBox2.Location = new System.Drawing.Point(6, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 292);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordeners de Producción";
            // 
            // txtHoraTrabajo
            // 
            this.txtHoraTrabajo.Location = new System.Drawing.Point(695, 65);
            this.txtHoraTrabajo.MaxLength = 10;
            this.txtHoraTrabajo.Name = "txtHoraTrabajo";
            this.txtHoraTrabajo.Size = new System.Drawing.Size(117, 26);
            this.txtHoraTrabajo.TabIndex = 14;
            // 
            // lblHorasTrabajo
            // 
            this.lblHorasTrabajo.AutoSize = true;
            this.lblHorasTrabajo.Location = new System.Drawing.Point(554, 65);
            this.lblHorasTrabajo.Name = "lblHorasTrabajo";
            this.lblHorasTrabajo.Size = new System.Drawing.Size(135, 20);
            this.lblHorasTrabajo.TabIndex = 13;
            this.lblHorasTrabajo.Text = "Horas de Tranajo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(20, 153);
            this.txtDescripcion.MaxLength = 10;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(792, 133);
            this.txtDescripcion.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 119);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtIdMaquinaOP
            // 
            this.txtIdMaquinaOP.Location = new System.Drawing.Point(350, 62);
            this.txtIdMaquinaOP.MaxLength = 10;
            this.txtIdMaquinaOP.Name = "txtIdMaquinaOP";
            this.txtIdMaquinaOP.Size = new System.Drawing.Size(167, 26);
            this.txtIdMaquinaOP.TabIndex = 10;
            // 
            // lblIdMaquinaOP
            // 
            this.lblIdMaquinaOP.AutoSize = true;
            this.lblIdMaquinaOP.Location = new System.Drawing.Point(252, 62);
            this.lblIdMaquinaOP.Name = "lblIdMaquinaOP";
            this.lblIdMaquinaOP.Size = new System.Drawing.Size(92, 20);
            this.lblIdMaquinaOP.TabIndex = 9;
            this.lblIdMaquinaOP.Text = "Id Maquina:";
            // 
            // txtIdOrden
            // 
            this.txtIdOrden.Location = new System.Drawing.Point(97, 62);
            this.txtIdOrden.MaxLength = 3;
            this.txtIdOrden.Name = "txtIdOrden";
            this.txtIdOrden.Size = new System.Drawing.Size(84, 26);
            this.txtIdOrden.TabIndex = 8;
            // 
            // lblIdOrden
            // 
            this.lblIdOrden.AutoSize = true;
            this.lblIdOrden.Location = new System.Drawing.Point(16, 62);
            this.lblIdOrden.Name = "lblIdOrden";
            this.lblIdOrden.Size = new System.Drawing.Size(75, 20);
            this.lblIdOrden.TabIndex = 7;
            this.lblIdOrden.Text = "Id Orden:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Location = new System.Drawing.Point(872, 41);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 38);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Lime;
            this.btnListar.Location = new System.Drawing.Point(875, 161);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(122, 38);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.Eliminar.Location = new System.Drawing.Point(875, 101);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(122, 38);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gpbMaquinas);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar/Eliminar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbTabla);
            this.tabPage2.Controls.Add(this.lblTabla);
            this.tabPage2.Controls.Add(this.dgvListar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbTabla
            // 
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(64, 18);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(175, 28);
            this.cmbTabla.TabIndex = 2;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(6, 18);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(52, 20);
            this.lblTabla.TabIndex = 1;
            this.lblTabla.Text = "Tabla:";
            // 
            // dgvListar
            // 
            this.dgvListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(6, 60);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.RowHeadersVisible = false;
            this.dgvListar.RowHeadersWidth = 62;
            this.dgvListar.RowTemplate.Height = 28;
            this.dgvListar.Size = new System.Drawing.Size(834, 368);
            this.dgvListar.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1009, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodoPlast ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gpbMaquinas.ResumeLayout(false);
            this.gpbMaquinas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gpbMaquinas;
        private System.Windows.Forms.TextBox txtIdMaquina;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblIdMaquina;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtIdMaquinaOP;
        private System.Windows.Forms.Label lblIdMaquinaOP;
        private System.Windows.Forms.TextBox txtIdOrden;
        private System.Windows.Forms.Label lblIdOrden;
        private System.Windows.Forms.TextBox txtHoraTrabajo;
        private System.Windows.Forms.Label lblHorasTrabajo;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label lblTabla;
    }
}

