using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroEtapa : Form
    {
        private EtapaController _etapaController;
        public FrmCadastroEtapa()
        {
            InitializeComponent();
            _etapaController = new EtapaController(this);
        }


        private void FrmCadastroEtapa_Load(object sender, EventArgs e)

        {
            _etapaController.ListarEtapas();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirEtapas(List<Etapas> etapas)
        {
            dgvEtapas.DataSource = etapas;
        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Etapas etapas = new Etapas()
            {
                Nome = txtNome.Text,
                Ordem = Convert.ToInt32(txtOrdem.Text),
                Ativo = rdbAtivo.Checked,
            };

            if (!ValidarDados(etapas))
                return;

            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                _etapaController.Salvar(etapas);
            }
            else
            {
                etapas.Id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Atualizar(etapas);
            }
        }
        private bool ValidarDados(Etapas etapas)
        {
            if (string.IsNullOrWhiteSpace(etapas.Nome))
            {
                ExibirMensagem("O campo 'Nome' é obrigatório.");
                return false;
            }

            if (etapas.Ordem <= 0)
            {
                ExibirMensagem("O campo 'Ordem' deve ser maior que zero.");
                return false;
            }

            return true;
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtOrdem.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtOrdem.Clear();
            rdbAtivo.Checked = true;
        }
        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtOrdem.ReadOnly = true;
            pnlSituacao.Enabled = false;

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

        private void dgvEtapas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Funcionou");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelicionada = dgvEtapas.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelicionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelicionada.Cells["Nome"].Value.ToString();
                txtOrdem.Text = linhaSelicionada.Cells["Ordem"].Value.ToString();
                rdbAtivo.Checked = Convert.ToBoolean(linhaSelicionada.Cells["Ativo"].Value);

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
            }


        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }
    }
    
}
        
    

