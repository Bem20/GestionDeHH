namespace MaquetaHH
{
    partial class HHCargaManual
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teletrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaMasivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudesToolStripMenuItem,
            this.autorizacionesToolStripMenuItem,
            this.hHToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hHToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.teletrabajoToolStripMenuItem,
            this.vacacionesToolStripMenuItem});
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            this.solicitudesToolStripMenuItem.Click += new System.EventHandler(this.solicitudesToolStripMenuItem_Click);
            // 
            // hHToolStripMenuItem
            // 
            this.hHToolStripMenuItem.Name = "hHToolStripMenuItem";
            this.hHToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hHToolStripMenuItem.Text = "HH";
            this.hHToolStripMenuItem.Click += new System.EventHandler(this.hHToolStripMenuItem_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // teletrabajoToolStripMenuItem
            // 
            this.teletrabajoToolStripMenuItem.Name = "teletrabajoToolStripMenuItem";
            this.teletrabajoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.teletrabajoToolStripMenuItem.Text = "Teletrabajo";
            // 
            // vacacionesToolStripMenuItem
            // 
            this.vacacionesToolStripMenuItem.Name = "vacacionesToolStripMenuItem";
            this.vacacionesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.vacacionesToolStripMenuItem.Text = "Vacaciones";
            // 
            // autorizacionesToolStripMenuItem
            // 
            this.autorizacionesToolStripMenuItem.Name = "autorizacionesToolStripMenuItem";
            this.autorizacionesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.autorizacionesToolStripMenuItem.Text = "Autorizaciones";
            // 
            // hHToolStripMenuItem1
            // 
            this.hHToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaMasivaToolStripMenuItem,
            this.cargaManualToolStripMenuItem});
            this.hHToolStripMenuItem1.Name = "hHToolStripMenuItem1";
            this.hHToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.hHToolStripMenuItem1.Text = "HH";
            // 
            // cargaMasivaToolStripMenuItem
            // 
            this.cargaMasivaToolStripMenuItem.Name = "cargaMasivaToolStripMenuItem";
            this.cargaMasivaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargaMasivaToolStripMenuItem.Text = "Carga masiva";
            this.cargaMasivaToolStripMenuItem.Click += new System.EventHandler(this.cargaMasivaToolStripMenuItem_Click);
            // 
            // cargaManualToolStripMenuItem
            // 
            this.cargaManualToolStripMenuItem.Name = "cargaManualToolStripMenuItem";
            this.cargaManualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargaManualToolStripMenuItem.Text = "Carga manual";
            this.cargaManualToolStripMenuItem.Click += new System.EventHandler(this.cargaManualToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(123, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 220);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Asunto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de Solicitud";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            // 
            // button_Volver
            // 
            this.button_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Volver.Location = new System.Drawing.Point(123, 305);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(210, 37);
            this.button_Volver.TabIndex = 12;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Buscar.Location = new System.Drawing.Point(356, 305);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(210, 37);
            this.button_Buscar.TabIndex = 11;
            this.button_Buscar.Text = "Aceptar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // HHCargaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HHCargaManual";
            this.Text = "HHCargaManual";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teletrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargaMasivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaManualToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Buscar;
    }
}