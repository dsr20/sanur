namespace SanurGenNHibernate
{
    partial class ConfirmarTriage
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
            this.si = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Quiere ústed confirmar la operación?";
            // 
            // si
            // 
            this.si.Location = new System.Drawing.Point(54, 51);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(42, 25);
            this.si.TabIndex = 1;
            this.si.Text = "Sí";
            this.si.UseVisualStyleBackColor = true;
            this.si.Click += new System.EventHandler(this.si_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(128, 51);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(42, 25);
            this.no.TabIndex = 2;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // ConfirmarTriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 88);
            this.Controls.Add(this.no);
            this.Controls.Add(this.si);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmarTriage";
            this.Text = "Confirmar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button si;
        private System.Windows.Forms.Button no;
    }
}