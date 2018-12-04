namespace Banco
{
    partial class FormTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferencia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MontoT = new System.Windows.Forms.TextBox();
            this.usuarioaenviar = new System.Windows.Forms.ComboBox();
            this.cuentaconectada = new System.Windows.Forms.ComboBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cuentadeuseraenviar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "De cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "A cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // MontoT
            // 
            this.MontoT.Location = new System.Drawing.Point(204, 281);
            this.MontoT.Name = "MontoT";
            this.MontoT.Size = new System.Drawing.Size(121, 20);
            this.MontoT.TabIndex = 5;
            // 
            // usuarioaenviar
            // 
            this.usuarioaenviar.FormattingEnabled = true;
            this.usuarioaenviar.Items.AddRange(new object[] {
            "Cuenta corriente",
            "Cuenta de ahorro"});
            this.usuarioaenviar.Location = new System.Drawing.Point(204, 188);
            this.usuarioaenviar.Name = "usuarioaenviar";
            this.usuarioaenviar.Size = new System.Drawing.Size(121, 21);
            this.usuarioaenviar.TabIndex = 6;
            this.usuarioaenviar.SelectedIndexChanged += new System.EventHandler(this.usuarioaenviar_SelectedIndexChanged);
            // 
            // cuentaconectada
            // 
            this.cuentaconectada.FormattingEnabled = true;
            this.cuentaconectada.Location = new System.Drawing.Point(204, 150);
            this.cuentaconectada.Name = "cuentaconectada";
            this.cuentaconectada.Size = new System.Drawing.Size(121, 21);
            this.cuentaconectada.TabIndex = 7;
            // 
            // aceptarButton
            // 
            this.aceptarButton.BackColor = System.Drawing.Color.Silver;
            this.aceptarButton.Location = new System.Drawing.Point(145, 332);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(86, 30);
            this.aceptarButton.TabIndex = 8;
            this.aceptarButton.Text = "ACEPTAR";
            this.aceptarButton.UseVisualStyleBackColor = false;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(53, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "TRANSFERENCIA ENTRE CUENTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cuentadeuseraenviar
            // 
            this.cuentadeuseraenviar.FormattingEnabled = true;
            this.cuentadeuseraenviar.Location = new System.Drawing.Point(204, 232);
            this.cuentadeuseraenviar.Name = "cuentadeuseraenviar";
            this.cuentadeuseraenviar.Size = new System.Drawing.Size(121, 21);
            this.cuentadeuseraenviar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(74, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "A usuario";
            // 
            // FormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 410);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cuentadeuseraenviar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cuentaconectada);
            this.Controls.Add(this.usuarioaenviar);
            this.Controls.Add(this.MontoT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTransferencia";
            this.Text = "HomeBanking";
            this.Load += new System.EventHandler(this.FormTransferencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MontoT;
        private System.Windows.Forms.ComboBox usuarioaenviar;
        private System.Windows.Forms.ComboBox cuentaconectada;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cuentadeuseraenviar;
        private System.Windows.Forms.Label label5;
    }
}