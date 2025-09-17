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

namespace SistemaAtendimento
{
    public partial class FrmCadastroCliente : Form
    {
        private ClienteController _clientesController;
        public FrmCadastroCliente()
        {
            InitializeComponent();
            _clientesController = new ClienteController(this);
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            _clientesController.ListarClientes();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = clientes;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Cpf_Cnpj = txtCpfCnpj.Text,
                TipoPessoa = rdbFisica.Checked ? "F" : "J",
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
                Ativo = rdbAtivo.Checked,
            };

            if (!ValidarDados(cliente))
                return;

            _clientesController.Salvar(cliente);

        }
        public bool ValidarDados(Clientes cliente)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O Campo nome é Obrigatório");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O Campo email é Obrigatório");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
            {
                if (rdbFisica.Checked)
                {
                    ExibirMensagem("O campo CPF é obrigatório");
                }
                else
                {
                    ExibirMensagem("O campo CNPJ é obrigatório");
                }

                txtCpfCnpj.Focus();
                return false;
            }
            //else
            //{
            //    if (rdbFisica.Checked)
            //    {
            //        if (!ValidarCpf(txtCpfCnpj.Text))
            //        {
            //            ExibirMensagem("CPF inválido");
            //            txtCpfCnpj.Focus();
            //            return false;
            //        }
            //        else
            //        {

            //        }

            //    }

            //}

            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                ExibirMensagem("O Campo cep é Obrigatório");
                txtCep.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ExibirMensagem("O Campo endereco é Obrigatório");
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O Campo numero é Obrigatório");
                txtNumero.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O Campo bairro é Obrigatório");
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O Campo cidade é Obrigatório");
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O Campo estado é Obrigatório");
                cbxEstado.Focus();
                return false;
            }


            return true;

        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CNPJ";
        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CPF";
        }

        private void grbDadosCliente_Enter(object sender, EventArgs e)
        {

        }



        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            pnlTipoPessoa.Enabled = true;
            txtCpfCnpj.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtBairro.ReadOnly = false;
            cbxEstado.Enabled = true;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtCpfCnpj.Clear();
            rdbFisica.Checked = true;
            rdbAtivo.Checked = true;
            cbxEstado.Text = "";

        }

        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            pnlTipoPessoa.Enabled = false;
            txtCpfCnpj.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtBairro.ReadOnly = true;
            cbxEstado.Enabled = false;
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
    }
}
