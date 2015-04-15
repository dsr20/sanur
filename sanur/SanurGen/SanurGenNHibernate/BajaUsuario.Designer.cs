namespace SanurGenNHibernate
{
    partial class BajaUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailantiguo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.emailnuevo = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.emailantiguo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 59);
            this.panel1.TabIndex = 15;
            // 
            // emailantiguo
            // 
            this.emailantiguo.Location = new System.Drawing.Point(201, 16);
            this.emailantiguo.Name = "emailantiguo";
            this.emailantiguo.Size = new System.Drawing.Size(155, 20);
            this.emailantiguo.TabIndex = 6;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contrasena
            // 
            this.contrasena.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contrasena.Location = new System.Drawing.Point(265, 196);
            this.contrasena.Name = "contrasena";
            this.contrasena.ReadOnly = true;
            this.contrasena.Size = new System.Drawing.Size(155, 20);
            this.contrasena.TabIndex = 24;
            // 
            // emailnuevo
            // 
            this.emailnuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.emailnuevo.Location = new System.Drawing.Point(265, 163);
            this.emailnuevo.Name = "emailnuevo";
            this.emailnuevo.ReadOnly = true;
            this.emailnuevo.Size = new System.Drawing.Size(155, 20);
            this.emailnuevo.TabIndex = 23;
            // 
            // apellidos
            // 
            this.apellidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.apellidos.Location = new System.Drawing.Point(265, 128);
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Size = new System.Drawing.Size(155, 20);
            this.apellidos.TabIndex = 22;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nombre.Location = new System.Drawing.Point(265, 92);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(155, 20);
            this.nombre.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // BajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.emailnuevo);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BajaUsuario";
            this.Text = "Baja usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailantiguo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.TextBox emailnuevo;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}