using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroSituacaoAtendimento : Form
    {
        private SituacaoAtendimentoController _situacaoatendimentoController;
        public FrmCadastroSituacaoAtendimento()
        {
            InitializeComponent();
            _situacaoatendimentoController = new SituacaoAtendimentoController(this);

            DesabilitarCampos();
        }


        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void FrmCadastroSituacaoAtendimento_Load(object sender, EventArgs e)
        {
            _situacaoatendimentoController.ListarSituacaoAtendimento();
        }
        public void ExibirSituacaoAtendimento(List<SituacaoAtendimentos> situacaoatendimentos)
        {
            dgvSituacaoAtendimento.DataSource = situacaoatendimentos;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SituacaoAtendimentos situacaoAtendimentos = new SituacaoAtendimentos()
            {
                Nome = txtNome.Text,
                Cor = txtCor.Text,
                Ativo = rdbAtivo.Checked,
            }
            ;
            if (!ValidarDados(situacaoAtendimentos))
                return;

            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                _situacaoatendimentoController.Salvar(situacaoAtendimentos);
            }
            else
            {
                situacaoAtendimentos.Id = Convert.ToInt32(txtCodigo.Text);
                _situacaoatendimentoController.Atualizar(situacaoAtendimentos);
            }

        }
        public bool ValidarDados(SituacaoAtendimentos situacaoAtendimentos)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O Campo nome é Obrigatório");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCor.Text))
            {
                ExibirMensagem("O Campo cor é Obrigatório");
                txtCor.Focus();
                return false;
            }
            return true;
        }
        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtCor.ReadOnly = false;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCor.Clear();
            rdbAtivo.Checked = true;

        }
        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtCor.ReadOnly = true;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvSituacaoAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show("Funcionou");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvSituacaoAtendimento.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtCor.Text = linhaSelecionada.Cells["Cor"].Value.ToString();
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);


                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Excluir esta situacao_atendimento", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _situacaoatendimentoController.Excluir(id);
            }
        }

        
    }
}
