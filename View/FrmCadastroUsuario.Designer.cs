namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            gbrListadeUsuario = new GroupBox();
            dgvUsuarios = new DataGridView();
            btnPesquisar = new Button();
            imlIcone = new ImageList(components);
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            grbDadosdoUsuario = new GroupBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            cbxPerfil = new ComboBox();
            lblPerfil = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblNome = new Label();
            lblCodigo = new Label();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            label1 = new Label();
            gbrListadeUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            grbDadosdoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // gbrListadeUsuario
            // 
            gbrListadeUsuario.Controls.Add(dgvUsuarios);
            gbrListadeUsuario.Location = new Point(32, 296);
            gbrListadeUsuario.Name = "gbrListadeUsuario";
            gbrListadeUsuario.Size = new Size(840, 192);
            gbrListadeUsuario.TabIndex = 29;
            gbrListadeUsuario.TabStop = false;
            gbrListadeUsuario.Text = "Lista de Usuário";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(16, 24);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(808, 150);
            dgvUsuarios.TabIndex = 10;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 5;
            btnPesquisar.ImageList = imlIcone;
            btnPesquisar.Location = new Point(768, 248);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(48, 23);
            btnPesquisar.TabIndex = 28;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // imlIcone
            // 
            imlIcone.ColorDepth = ColorDepth.Depth32Bit;
            imlIcone.ImageStream = (ImageListStreamer)resources.GetObject("imlIcone.ImageStream");
            imlIcone.TransparentColor = Color.Transparent;
            imlIcone.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcone.Images.SetKeyName(1, "icone-editar.png");
            imlIcone.Images.SetKeyName(2, "icone-excluir.png");
            imlIcone.Images.SetKeyName(3, "icone-novo.png");
            imlIcone.Images.SetKeyName(4, "icone-salvar.png");
            imlIcone.Images.SetKeyName(5, "icones-pesquisar.png");
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(544, 232);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 27;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(544, 248);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(200, 23);
            txtPesquisar.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcone;
            btnCancelar.Location = new Point(392, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 32);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcone;
            btnExcluir.Location = new Point(304, 248);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 32);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 4;
            btnSalvar.ImageList = imlIcone;
            btnSalvar.Location = new Point(216, 248);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcone;
            btnEditar.Location = new Point(128, 248);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcone;
            btnNovo.Location = new Point(32, 248);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 32);
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // grbDadosdoUsuario
            // 
            grbDadosdoUsuario.Controls.Add(txtEmail);
            grbDadosdoUsuario.Controls.Add(lblEmail);
            grbDadosdoUsuario.Controls.Add(cbxPerfil);
            grbDadosdoUsuario.Controls.Add(lblPerfil);
            grbDadosdoUsuario.Controls.Add(lblSenha);
            grbDadosdoUsuario.Controls.Add(txtSenha);
            grbDadosdoUsuario.Controls.Add(lblNome);
            grbDadosdoUsuario.Controls.Add(lblCodigo);
            grbDadosdoUsuario.Controls.Add(txtNome);
            grbDadosdoUsuario.Controls.Add(txtCodigo);
            grbDadosdoUsuario.Controls.Add(label1);
            grbDadosdoUsuario.Location = new Point(16, 24);
            grbDadosdoUsuario.Name = "grbDadosdoUsuario";
            grbDadosdoUsuario.Size = new Size(856, 200);
            grbDadosdoUsuario.TabIndex = 20;
            grbDadosdoUsuario.TabStop = false;
            grbDadosdoUsuario.Text = "Dados do Usuário";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(488, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(352, 23);
            txtEmail.TabIndex = 31;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(488, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "E-mail";
            // 
            // cbxPerfil
            // 
            cbxPerfil.Enabled = false;
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Items.AddRange(new object[] { "Usuário", "Administrador" });
            cbxPerfil.Location = new Point(264, 112);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(168, 23);
            cbxPerfil.TabIndex = 8;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(264, 88);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 7;
            lblPerfil.Text = "Perfil";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(32, 88);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(32, 112);
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = true;
            txtSenha.Size = new Size(160, 23);
            txtSenha.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(224, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(32, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(232, 40);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(560, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(32, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(152, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 525);
            Controls.Add(gbrListadeUsuario);
            Controls.Add(btnPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosdoUsuario);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usuários";
            Load += FrmCadastroUsuario_Load;
            gbrListadeUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            grbDadosdoUsuario.ResumeLayout(false);
            grbDadosdoUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbrListadeUsuario;
        private DataGridView dgvUsuarios;
        private Button btnPesquisar;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private GroupBox grbDadosdoUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label1;
        private ComboBox cbxPerfil;
        private Label lblPerfil;
        private ImageList imlIcone;
        private Label lblEmail;
        private TextBox txtEmail;
    }
}