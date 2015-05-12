namespace SanurGenNHibernate
{
    partial class ActualizaEpisodio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo_asist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpaciente,
            this.nombre_paciente,
            this.prioridad,
            this.motivo_asist,
            this.observaciones,
            this.fecha});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 325);
            this.dataGridView1.TabIndex = 7;
            // 
            // idpaciente
            // 
            this.idpaciente.HeaderText = "Id paciente";
            this.idpaciente.Name = "idpaciente";
            this.idpaciente.ReadOnly = true;
            // 
            // nombre_paciente
            // 
            this.nombre_paciente.HeaderText = "Nombre paciente";
            this.nombre_paciente.Name = "nombre_paciente";
            this.nombre_paciente.ReadOnly = true;
            // 
            // prioridad
            // 
            this.prioridad.HeaderText = "Prioridad";
            this.prioridad.Name = "prioridad";
            this.prioridad.ReadOnly = true;
            // 
            // motivo_asist
            // 
            this.motivo_asist.HeaderText = "Motivo asistencia";
            this.motivo_asist.Name = "motivo_asist";
            this.motivo_asist.ReadOnly = true;
            // 
            // observaciones
            // 
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // ActualizaEpisodio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 325);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ActualizaEpisodio";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo_asist;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;




    }
}