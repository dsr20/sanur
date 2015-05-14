namespace SanurGenNHibernate
{
    partial class buscarUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Idgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombregrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidosgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 113);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(154, 62);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(219, 20);
            this.Nombre.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(154, 21);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(219, 20);
            this.Email.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idgrid,
            this.Nombregrid,
            this.Apellidosgrid,
            this.Emailgrid});
            this.dataGridView1.Location = new System.Drawing.Point(49, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // Idgrid
            // 
            this.Idgrid.HeaderText = "Id Usuario";
            this.Idgrid.Name = "Idgrid";
            // 
            // Nombregrid
            // 
            this.Nombregrid.HeaderText = "Nombre";
            this.Nombregrid.Name = "Nombregrid";
            // 
            // Apellidosgrid
            // 
            this.Apellidosgrid.HeaderText = "Apellidos";
            this.Apellidosgrid.Name = "Apellidosgrid";
            // 
            // Emailgrid
            // 
            this.Emailgrid.HeaderText = "Email";
            this.Emailgrid.Name = "Emailgrid";
            // 
            // buscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "buscarUsuario";
            this.Text = "buscarPaciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombregrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidosgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailgrid;
    }
}