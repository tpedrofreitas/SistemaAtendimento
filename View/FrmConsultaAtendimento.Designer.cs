namespace SistemaAtendimento.View
{
    partial class FrmConsultaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAtendimento));
            dgvConsultaAtendimento = new DataGridView();
            imageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            label2 = new Label();
            cbxFiltro = new ComboBox();
            btnPesquisar = new Button();
            txtFiltro = new TextBox();
            imageList2 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaAtendimento.Location = new Point(16, 80);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.ReadOnly = true;
            dgvConsultaAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaAtendimento.Size = new Size(632, 288);
            dgvConsultaAtendimento.TabIndex = 0;
            dgvConsultaAtendimento.CellDoubleClick += dgvConsultaAtendimento_CellDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icones-pesquisar.png");
            imageList1.Images.SetKeyName(1, "icones-pesquisar.png");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbxFiltro);
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 56);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Filtrar por:";
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Código do Atendimento", "Nome do Cliente", "CPF", "CNPJ" });
            cbxFiltro.Location = new Point(8, 24);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(184, 23);
            cbxFiltro.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.BottomLeft;
            btnPesquisar.ImageIndex = 1;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(512, 24);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 24);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(224, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(272, 23);
            txtFiltro.TabIndex = 6;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 384);
            Controls.Add(groupBox1);
            Controls.Add(dgvConsultaAtendimento);
            Name = "FrmConsultaAtendimento";
            Text = "Consulta de Atendimentos";
            Load += FrmConsultaAtendimento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultaAtendimento;
        private ImageList imageList1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cbxFiltro;
        private Button btnPesquisar;
        private TextBox txtFiltro;
        private ImageList imageList2;
    }
}