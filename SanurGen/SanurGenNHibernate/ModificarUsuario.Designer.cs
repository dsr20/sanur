namespace SanurGenNHibernate
{
    partial class ModificarUsuario
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailantiguo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.emailnuevo = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.especialidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Especialidad";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email del usuario a modificar";
            // 
            // emailantiguo
            // 
            this.emailantiguo.Location = new System.Drawing.Point(201, 16);
            this.emailantiguo.Name = "emailantiguo";
            this.emailantiguo.Size = new System.Drawing.Size(155, 20);
            this.emailantiguo.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(267, 96);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(155, 20);
            this.nombre.TabIndex = 7;
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(267, 132);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(155, 20);
            this.apellidos.TabIndex = 8;
            // 
            // emailnuevo
            // 
            this.emailnuevo.Location = new System.Drawing.Point(267, 167);
            this.emailnuevo.Name = "emailnuevo";
            this.emailnuevo.Size = new System.Drawing.Size(155, 20);
            this.emailnuevo.TabIndex = 9;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(267, 200);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(155, 20);
            this.contrasena.TabIndex = 10;
            this.contrasena.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contrasena_MouseClick);
            this.contrasena.TextChanged += new System.EventHandler(this.contrasena_TextChanged);
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
            "Interna"});
            this.especialidad.Location = new System.Drawing.Point(267, 238);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(155, 21);
            this.especialidad.TabIndex = 11;
            this.especialidad.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.emailantiguo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(37, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 59);
            this.panel1.TabIndex = 14;
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.emailnuevo);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarUsuario";
            this.Text = "Modificar datos de usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailantiguo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox emailnuevo;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.ComboBox especialidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}