namespace SanurGenNHibernate
{
    partial class HojaTriage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.motivo = new System.Windows.Forms.TextBox();
            this.observaciones = new System.Windows.Forms.TextBox();
            this.destino = new System.Windows.Forms.ComboBox();
            this.prioridad = new System.Windows.Forms.ComboBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivo asist.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Observaciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prioridad:";
            // 
            // motivo
            // 
            this.motivo.Location = new System.Drawing.Point(168, 139);
            this.motivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.motivo.Multiline = true;
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(448, 100);
            this.motivo.TabIndex = 5;
            // 
            // observaciones
            // 
            this.observaciones.Location = new System.Drawing.Point(168, 270);
            this.observaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.observaciones.Multiline = true;
            this.observaciones.Name = "observaciones";
            this.observaciones.Size = new System.Drawing.Size(448, 157);
            this.observaciones.TabIndex = 6;
            // 
            // destino
            // 
            this.destino.FormattingEnabled = true;
            this.destino.Items.AddRange(new object[] {
            "Ginecología",
            "Traumatología",
            "Pediatría",
            "Psiquiatría",
            "Interna"});
            this.destino.Location = new System.Drawing.Point(168, 49);
            this.destino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(160, 24);
            this.destino.TabIndex = 7;
            // 
            // prioridad
            // 
            this.prioridad.FormattingEnabled = true;
            this.prioridad.Items.AddRange(new object[] {
            "Inmediata",
            "Preferente",
            "Urgente",
            "Normal",
            "No urgente"});
            this.prioridad.Location = new System.Drawing.Point(461, 49);
            this.prioridad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prioridad.Name = "prioridad";
            this.prioridad.Size = new System.Drawing.Size(160, 24);
            this.prioridad.TabIndex = 8;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(229, 465);
            this.aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 28);
            this.aceptar.TabIndex = 9;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(365, 465);
            this.cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 28);
            this.cancelar.TabIndex = 10;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // HojaTriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 535);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.prioridad);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.observaciones);
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HojaTriage";
            this.Text = "Hoja de triage";
            this.Load += new System.EventHandler(this.HojaTriage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox motivo;
        private System.Windows.Forms.TextBox observaciones;
        private System.Windows.Forms.ComboBox destino;
        private System.Windows.Forms.ComboBox prioridad;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
    }
}