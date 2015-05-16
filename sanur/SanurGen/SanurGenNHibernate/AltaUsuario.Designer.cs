namespace SanurGenNHibernate
{
    partial class altaUsuario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.especialidad = new System.Windows.Forms.ComboBox();
            this.crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(432, 79);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(215, 22);
            this.nombre.TabIndex = 4;
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(432, 117);
            this.apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(215, 22);
            this.apellidos.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(432, 155);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(215, 22);
            this.email.TabIndex = 6;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(432, 190);
            this.contrasena.Margin = new System.Windows.Forms.Padding(4);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(215, 22);
            this.contrasena.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo usuario";
            // 
            // tipo
            // 
            this.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Administrativo",
            "Administrador",
            "Medico"});
            this.tipo.Location = new System.Drawing.Point(432, 26);
            this.tipo.Margin = new System.Windows.Forms.Padding(4);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(215, 24);
            this.tipo.TabIndex = 9;
            this.tipo.SelectedIndexChanged += new System.EventHandler(this.tipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especialidad";
            this.label6.Visible = false;
            // 
            // especialidad
            // 
            this.especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidad.FormattingEnabled = true;
            this.especialidad.Items.AddRange(new object[] {
            "Ginecología",
            "Traumatología",
            "Pediatría",
            "Psiquiatría",
            "Interna",
            "Triage"});
            this.especialidad.Location = new System.Drawing.Point(432, 249);
            this.especialidad.Margin = new System.Windows.Forms.Padding(4);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(215, 24);
            this.especialidad.TabIndex = 11;
            this.especialidad.Visible = false;
            this.especialidad.SelectedIndexChanged += new System.EventHandler(this.especialidad_SelectedIndexChanged);
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(391, 347);
            this.crear.Margin = new System.Windows.Forms.Padding(4);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(164, 28);
            this.crear.TabIndex = 12;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // altaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 422);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.email);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "altaUsuario";
            this.Text = "Alta nuevo usuario";
            this.Load += new System.EventHandler(this.altaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox especialidad;
        private System.Windows.Forms.Button crear;
    }
}