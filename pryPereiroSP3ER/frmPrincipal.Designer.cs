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
            this.tabTodoPlast = new System.Windows.Forms.TabControl();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.tabListar = new System.Windows.Forms.TabPage();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.tabTodoPlast.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 32);
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
            // tabTodoPlast
            // 
            this.tabTodoPlast.Controls.Add(this.tabAgregar);
            this.tabTodoPlast.Controls.Add(this.tabListar);
            this.tabTodoPlast.Controls.Add(this.tabEliminar);
            this.tabTodoPlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTodoPlast.Location = new System.Drawing.Point(0, 2);
            this.tabTodoPlast.Name = "tabTodoPlast";
            this.tabTodoPlast.SelectedIndex = 0;
            this.tabTodoPlast.Size = new System.Drawing.Size(1100, 518);
            this.tabTodoPlast.TabIndex = 1;
            this.tabTodoPlast.Tag = "";
            // 
            // tabAgregar
            // 
            this.tabAgregar.Location = new System.Drawing.Point(4, 38);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregar.Size = new System.Drawing.Size(1092, 476);
            this.tabAgregar.TabIndex = 0;
            this.tabAgregar.Text = "Registrar";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // tabListar
            // 
            this.tabListar.Location = new System.Drawing.Point(4, 38);
            this.tabListar.Name = "tabListar";
            this.tabListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabListar.Size = new System.Drawing.Size(809, 442);
            this.tabListar.TabIndex = 1;
            this.tabListar.Text = "Listar";
            this.tabListar.UseVisualStyleBackColor = true;
            // 
            // tabEliminar
            // 
            this.tabEliminar.Location = new System.Drawing.Point(4, 38);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(809, 442);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "Eliminar";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1100, 555);
            this.Controls.Add(this.tabTodoPlast);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodoPlast ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabTodoPlast.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabTodoPlast;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.TabPage tabListar;
        private System.Windows.Forms.TabPage tabEliminar;
    }
}

