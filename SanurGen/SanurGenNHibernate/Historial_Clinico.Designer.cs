namespace SanurGenNHibernate
{
    partial class Historial_Clinico
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
            this.label1 = new System.Windows.Forms.Label();
            this.paciente_nombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEpisodio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrando Historial Clínico de :";
            // 
            // paciente_nombre
            // 
            this.paciente_nombre.AutoSize = true;
            this.paciente_nombre.Location = new System.Drawing.Point(174, 13);
            this.paciente_nombre.Name = "paciente_nombre";
            this.paciente_nombre.Size = new System.Drawing.Size(0, 13);
            this.paciente_nombre.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEpisodio,
            this.fechaInicio,
            this.fechaFin,
            this.Observaciones,
            this.emergencia,
            this.importante});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 535);
            this.dataGridView1.TabIndex = 2;
            // 
            // idEpisodio
            // 
            this.idEpisodio.HeaderText = "Id Episodio";
            this.idEpisodio.Name = "idEpisodio";
            this.idEpisodio.ReadOnly = true;
            this.idEpisodio.Visible = false;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Width = 150;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            this.fechaFin.Width = 150;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 400;
            // 
            // emergencia
            // 
            this.emergencia.HeaderText = "Emergencia";
            this.emergencia.Name = "emergencia";
            this.emergencia.ReadOnly = true;
            // 
            // importante
            // 
            this.importante.HeaderText = "Importante";
            this.importante.Name = "importante";
            this.importante.ReadOnly = true;
            // 
            // Historial_Clinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paciente_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Historial_Clinico";
            this.Text = "Historial_Clinico";
            this.Load += new System.EventHandler(this.Historial_Clinico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label paciente_nombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEpisodio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn importante;
    }
}