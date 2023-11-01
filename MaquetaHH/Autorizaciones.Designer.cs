namespace MaquetaHH
{
    partial class Autorizaciones
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
            this.button_Rechazar = new System.Windows.Forms.Button();
            this.button_Aprobar = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_Buscador = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Rechazar
            // 
            this.button_Rechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rechazar.Location = new System.Drawing.Point(242, 373);
            this.button_Rechazar.Name = "button_Rechazar";
            this.button_Rechazar.Size = new System.Drawing.Size(102, 37);
            this.button_Rechazar.TabIndex = 8;
            this.button_Rechazar.Text = "Rechazar";
            this.button_Rechazar.UseVisualStyleBackColor = true;
            this.button_Rechazar.Click += new System.EventHandler(this.button_Rechazar_Click);
            // 
            // button_Aprobar
            // 
            this.button_Aprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Aprobar.Location = new System.Drawing.Point(134, 373);
            this.button_Aprobar.Name = "button_Aprobar";
            this.button_Aprobar.Size = new System.Drawing.Size(102, 37);
            this.button_Aprobar.TabIndex = 7;
            this.button_Aprobar.Text = "Aprobar";
            this.button_Aprobar.UseVisualStyleBackColor = true;
            this.button_Aprobar.Click += new System.EventHandler(this.button_Aprobar_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Buscar.Location = new System.Drawing.Point(134, 92);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(210, 37);
            this.button_Buscar.TabIndex = 6;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // textBox_Buscador
            // 
            this.textBox_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Buscador.Location = new System.Drawing.Point(134, 44);
            this.textBox_Buscador.Name = "textBox_Buscador";
            this.textBox_Buscador.Size = new System.Drawing.Size(426, 29);
            this.textBox_Buscador.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(134, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 220);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.button_Volver.Location = new System.Drawing.Point(350, 92);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(210, 37);
            this.button_Volver.TabIndex = 10;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // Autorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Volver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Rechazar);
            this.Controls.Add(this.button_Aprobar);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.textBox_Buscador);
            this.Name = "Autorizaciones";
            this.Text = "Autorizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Rechazar;
        private System.Windows.Forms.Button button_Aprobar;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_Buscador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button_Volver;
    }
}