namespace Banco
{
    partial class Formuser
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
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(67, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(67, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(194, 151);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(127, 20);
            this.Usuario.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(195, 227);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(126, 20);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(110, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "INICIO DE SESIÓN";
            // 
            // IngresoButton
            // 
            this.IngresoButton.BackColor = System.Drawing.Color.Silver;
            this.IngresoButton.Location = new System.Drawing.Point(139, 304);
            this.IngresoButton.Name = "IngresoButton";
            this.IngresoButton.Size = new System.Drawing.Size(86, 30);
            this.IngresoButton.TabIndex = 5;
            this.IngresoButton.Text = "INGRESAR";
            this.IngresoButton.UseVisualStyleBackColor = false;
            this.IngresoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 410);
            this.Controls.Add(this.IngresoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formuser";
            this.Text = "HomeBanking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formuser_FormClosing);
            this.Load += new System.EventHandler(this.Formuser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IngresoButton;
    }
}