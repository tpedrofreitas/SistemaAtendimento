namespace SistemaAtendimento.View
{
    partial class FrmCadastroSituacaoAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroSituacaoAtendimento));
            label1 = new Label();
            grbDadosdoSituacaoAtendimento = new GroupBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblCor = new Label();
            txtCor = new TextBox();
            lblNome = new Label();
            lblCodigo = new Label();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            gbrListadeSituacaodeAtendimento = new GroupBox();
            dgvSituacaoAtendimento = new DataGridView();
            btnPesquisar = new Button();
            grbDadosdoSituacaoAtendimento.SuspendLayout();
            pnlSituacao.SuspendLayout();
            gbrListadeSituacaodeAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSituacaoAtendimento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // grbDadosdoSituacaoAtendimento
            // 
            grbDadosdoSituacaoAtendimento.Controls.Add(pnlSituacao);
            grbDadosdoSituacaoAtendimento.Controls.Add(lblCor);
            grbDadosdoSituacaoAtendimento.Controls.Add(txtCor);
            grbDadosdoSituacaoAtendimento.Controls.Add(lblNome);
            grbDadosdoSituacaoAtendimento.Controls.Add(lblCodigo);
            grbDadosdoSituacaoAtendimento.Controls.Add(txtNome);
            grbDadosdoSituacaoAtendimento.Controls.Add(txtCodigo);
            grbDadosdoSituacaoAtendimento.Controls.Add(label1);
            grbDadosdoSituacaoAtendimento.Location = new Point(0, 16);
            grbDadosdoSituacaoAtendimento.Name = "grbDadosdoSituacaoAtendimento";
            grbDadosdoSituacaoAtendimento.Size = new Size(856, 200);
            grbDadosdoSituacaoAtendimento.TabIndex = 0;
            grbDadosdoSituacaoAtendimento.TabStop = false;
            grbDadosdoSituacaoAtendimento.Text = "Dados da Situação do Atendimento";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(208, 112);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(152, 48);
            pnlSituacao.TabIndex = 1;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(88, 16);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 10;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(16, 16);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 9;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(32, 88);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 5;
            lblCor.Text = "Cor";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(32, 112);
            txtCor.Name = "txtCor";
            txtCor.ReadOnly = true;
            txtCor.Size = new Size(160, 23);
            txtCor.TabIndex = 1;
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
            txtNome.Location = new Point(224, 40);
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
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(16, 240);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 32);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-editar.png");
            imlIcones.Images.SetKeyName(2, "icone-excluir.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-salvar.png");
            imlIcones.Images.SetKeyName(5, "icones-pesquisar.png");
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(112, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 4;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(200, 240);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(288, 240);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 32);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(376, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(528, 240);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(200, 23);
            txtPesquisar.TabIndex = 6;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(528, 224);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 7;
            lblPesquisar.Text = "Pesquisar";
            // 
            // gbrListadeSituacaodeAtendimento
            // 
            gbrListadeSituacaodeAtendimento.Controls.Add(dgvSituacaoAtendimento);
            gbrListadeSituacaodeAtendimento.Location = new Point(16, 288);
            gbrListadeSituacaodeAtendimento.Name = "gbrListadeSituacaodeAtendimento";
            gbrListadeSituacaodeAtendimento.Size = new Size(840, 192);
            gbrListadeSituacaodeAtendimento.TabIndex = 9;
            gbrListadeSituacaodeAtendimento.TabStop = false;
            gbrListadeSituacaodeAtendimento.Text = "Lista de Situações de Atendimento";
            // 
            // dgvSituacaoAtendimento
            // 
            dgvSituacaoAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSituacaoAtendimento.Location = new Point(16, 24);
            dgvSituacaoAtendimento.Name = "dgvSituacaoAtendimento";
            dgvSituacaoAtendimento.Size = new Size(808, 150);
            dgvSituacaoAtendimento.TabIndex = 10;
            dgvSituacaoAtendimento.CellDoubleClick += dgvSituacaoAtendimento_CellDoubleClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 5;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(752, 240);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(48, 23);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // FrmCadastroSituacaoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 505);
            Controls.Add(gbrListadeSituacaodeAtendimento);
            Controls.Add(btnPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosdoSituacaoAtendimento);
            Name = "FrmCadastroSituacaoAtendimento";
            Text = "Cadastro da Situação do Atendimentos";
            Load += FrmCadastroSituacaoAtendimento_Load;
            grbDadosdoSituacaoAtendimento.ResumeLayout(false);
            grbDadosdoSituacaoAtendimento.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            gbrListadeSituacaodeAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSituacaoAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grbDadosdoSituacaoAtendimento;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblCor;
        private TextBox txtCor;
        private Panel pnlSituacao;
        private RadioButton rdbAtivo;
        private RadioButton rdbInativo;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private GroupBox gbrListadeSituacaodeAtendimento;
        private DataGridView dgvSituacaoAtendimento;
        private ImageList imlIcones;
        private Button btnPesquisar;
    }
}