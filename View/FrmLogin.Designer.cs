namespace SistemaAtendimento.View
{
    partial class FrmLogin
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
            btnBemVindo = new Button();
            lblEmail = new Label();
            lblSenha = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // btnBemVindo
            // 
            btnBemVindo.Font = new Font("Source Code Pro", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBemVindo.Location = new Point(104, 32);
            btnBemVindo.Name = "btnBemVindo";
            btnBemVindo.Size = new Size(152, 40);
            btnBemVindo.TabIndex = 0;
            btnBemVindo.Text = "Bem Vindo";
            btnBemVindo.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(48, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(48, 152);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(53, 21);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(104, 152);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(152, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(96, 224);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(160, 40);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(337, 298);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(btnBemVindo);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBemVindo;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnEntrar;
    }
}