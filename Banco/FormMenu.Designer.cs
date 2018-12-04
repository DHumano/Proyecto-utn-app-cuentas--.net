namespace Banco
{
    partial class FormMenu
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
            this.extraerButton = new System.Windows.Forms.Button();
            this.depositarButton = new System.Windows.Forms.Button();
            this.transferirButton = new System.Windows.Forms.Button();
            this.movimButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // extraerButton
            // 
            this.extraerButton.BackColor = System.Drawing.Color.Silver;
            this.extraerButton.Location = new System.Drawing.Point(215, 150);
            this.extraerButton.Name = "extraerButton";
            this.extraerButton.Size = new System.Drawing.Size(125, 44);
            this.extraerButton.TabIndex = 1;
            this.extraerButton.Text = "EXTRAER";
            this.extraerButton.UseVisualStyleBackColor = false;
            this.extraerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // depositarButton
            // 
            this.depositarButton.BackColor = System.Drawing.Color.Silver;
            this.depositarButton.Location = new System.Drawing.Point(37, 150);
            this.depositarButton.Name = "depositarButton";
            this.depositarButton.Size = new System.Drawing.Size(125, 44);
            this.depositarButton.TabIndex = 2;
            this.depositarButton.Text = "DEPOSITAR";
            this.depositarButton.UseVisualStyleBackColor = false;
            this.depositarButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // transferirButton
            // 
            this.transferirButton.BackColor = System.Drawing.Color.Silver;
            this.transferirButton.Location = new System.Drawing.Point(37, 231);
            this.transferirButton.Name = "transferirButton";
            this.transferirButton.Size = new System.Drawing.Size(125, 44);
            this.transferirButton.TabIndex = 3;
            this.transferirButton.Text = "TRANSFERIR";
            this.transferirButton.UseVisualStyleBackColor = false;
            this.transferirButton.Click += new System.EventHandler(this.transferirButton_Click);
            // 
            // movimButton
            // 
            this.movimButton.BackColor = System.Drawing.Color.Silver;
            this.movimButton.Location = new System.Drawing.Point(215, 231);
            this.movimButton.Name = "movimButton";
            this.movimButton.Size = new System.Drawing.Size(125, 44);
            this.movimButton.TabIndex = 4;
            this.movimButton.Text = "MOVIMIENTOS";
            this.movimButton.UseVisualStyleBackColor = false;
            this.movimButton.Click += new System.EventHandler(this.movimButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENÚ OPERACIONES";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.AliceBlue;
            this.logoutButton.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(290, 13);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(12, 12);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(58, 19);
            this.usuario.TabIndex = 7;
            this.usuario.Text = "label2";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 410);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movimButton);
            this.Controls.Add(this.transferirButton);
            this.Controls.Add(this.depositarButton);
            this.Controls.Add(this.extraerButton);
            this.Name = "FormMenu";
            this.Text = "HomeBanking";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button extraerButton;
        private System.Windows.Forms.Button depositarButton;
        private System.Windows.Forms.Button transferirButton;
        private System.Windows.Forms.Button movimButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label usuario;



    }
}