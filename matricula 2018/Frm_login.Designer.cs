namespace matricula_2018
{
    partial class Frm_login
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
            this.Tbx_senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbx_senha
            // 
            this.Tbx_senha.Location = new System.Drawing.Point(225, 129);
            this.Tbx_senha.Name = "Tbx_senha";
            this.Tbx_senha.PasswordChar = '*';
            this.Tbx_senha.Size = new System.Drawing.Size(274, 20);
            this.Tbx_senha.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 64);
            this.label1.TabIndex = 47;
            this.label1.Text = "PREFEITURA DA CIDADE DE NOVA IGUAÇU\r\nSECRETARIA MUNICIPAL DE EDUCAÇÃO\r\nSUBSECRETA" +
    "RIA DE GESTÂO DE RECURSOS FINANCEIROS\r\nSETOR DE TECNOLOGIA DA INFORMAÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(223, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Pre-matricula para 2018";
            // 
            // btn_cancela
            // 
            this.btn_cancela.Location = new System.Drawing.Point(385, 159);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(75, 23);
            this.btn_cancela.TabIndex = 45;
            this.btn_cancela.Text = "Cancela";
            this.btn_cancela.UseVisualStyleBackColor = true;
            this.btn_cancela.Click += new System.EventHandler(this.btn_cancela_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Entra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadastro_de_Aluno.Properties.Resources.Brasão_de_Nova_Iguaçu_svg;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 194);
            this.Controls.Add(this.Tbx_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Tbx_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}