namespace SanurGenNHibernate
{
    partial class Login
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
            this.bEnter = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passForgot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(290, 275);
            this.bEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(101, 37);
            this.bEnter.TabIndex = 0;
            this.bEnter.Text = "ENTRAR";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(246, 166);
            this.nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(208, 20);
            this.nombre.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(246, 221);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(208, 20);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // passForgot
            // 
            this.passForgot.Location = new System.Drawing.Point(265, 328);
            this.passForgot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passForgot.Name = "passForgot";
            this.passForgot.Size = new System.Drawing.Size(154, 37);
            this.passForgot.TabIndex = 4;
            this.passForgot.Text = "He olvidado mi contraseña";
            this.passForgot.UseVisualStyleBackColor = true;
            this.passForgot.Click += new System.EventHandler(this.passForgot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Crimson;
            this.labelError.Location = new System.Drawing.Point(269, 251);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(163, 13);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "Usuario o contraseña incorrectos";
            this.labelError.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(223, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 142);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passForgot);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.bEnter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software de gestion de urgencias";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button passForgot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}