namespace SistemaAtendimento.View
{
    partial class FrmCadastroEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEtapa));
            gbrListadeEtapas = new GroupBox();
            dgvSituacaoAtendimento = new DataGridView();
            btnPesquisar = new Button();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            grbDadosdaEtapas = new GroupBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblOrdem = new Label();
            txtOrdem = new TextBox();
            lblNome = new Label();
            lblCodigo = new Label();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            label1 = new Label();
            imlIcones = new ImageList(components);
            gbrListadeEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSituacaoAtendimento).BeginInit();
            grbDadosdaEtapas.SuspendLayout();
            pnlSituacao.SuspendLayout();
            SuspendLayout();
            // 
            // gbrListadeEtapas
            // 
            gbrListadeEtapas.Controls.Add(dgvSituacaoAtendimento);
            gbrListadeEtapas.Location = new Point(32, 288);
            gbrListadeEtapas.Name = "gbrListadeEtapas";
            gbrListadeEtapas.Size = new Size(840, 192);
            gbrListadeEtapas.TabIndex = 19;
            gbrListadeEtapas.TabStop = false;
            gbrListadeEtapas.Text = "Lista de Etapas";
            // 
            // dgvSituacaoAtendimento
            // 
            dgvSituacaoAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSituacaoAtendimento.Location = new Point(16, 24);
            dgvSituacaoAtendimento.Name = "dgvSituacaoAtendimento";
            dgvSituacaoAtendimento.Size = new Size(808, 150);
            dgvSituacaoAtendimento.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 5;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(768, 240);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(48, 23);
            btnPesquisar.TabIndex = 18;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(544, 224);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 17;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(544, 240);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(200, 23);
            txtPesquisar.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(392, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 32);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(304, 240);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 32);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 4;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(216, 240);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(128, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(32, 240);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 32);
            btnNovo.TabIndex = 11;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // grbDadosdaEtapas
            // 
            grbDadosdaEtapas.Controls.Add(pnlSituacao);
            grbDadosdaEtapas.Controls.Add(lblOrdem);
            grbDadosdaEtapas.Controls.Add(txtOrdem);
            grbDadosdaEtapas.Controls.Add(lblNome);
            grbDadosdaEtapas.Controls.Add(lblCodigo);
            grbDadosdaEtapas.Controls.Add(txtNome);
            grbDadosdaEtapas.Controls.Add(txtCodigo);
            grbDadosdaEtapas.Controls.Add(label1);
            grbDadosdaEtapas.Location = new Point(16, 16);
            grbDadosdaEtapas.Name = "grbDadosdaEtapas";
            grbDadosdaEtapas.Size = new Size(856, 200);
            grbDadosdaEtapas.TabIndex = 10;
            grbDadosdaEtapas.TabStop = false;
            grbDadosdaEtapas.Text = "Dados da Etapas";
            grbDadosdaEtapas.Enter += grbDadosdoSituacaoAtendimento_Enter;
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
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(32, 88);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(44, 15);
            lblOrdem.TabIndex = 5;
            lblOrdem.Text = "Ordem";
            // 
            // txtOrdem
            // 
            txtOrdem.Location = new Point(32, 112);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Size = new Size(160, 23);
            txtOrdem.TabIndex = 1;
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
            txtNome.Size = new Size(560, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(32, 40);
            txtCodigo.Name = "txtCodigo";
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
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 527);
            Controls.Add(gbrListadeEtapas);
            Controls.Add(btnPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosdaEtapas);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapas";
            gbrListadeEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSituacaoAtendimento).EndInit();
            grbDadosdaEtapas.ResumeLayout(false);
            grbDadosdaEtapas.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbrListadeEtapas;
        private DataGridView dgvSituacaoAtendimento;
        private Button btnPesquisar;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private GroupBox grbDadosdaEtapas;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblOrdem;
        private TextBox txtOrdem;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label1;
        private ImageList imlIcones;
    }
}