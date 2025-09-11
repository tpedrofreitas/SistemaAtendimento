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

            if(!ValidarDados(cliente))
                return;

            _clientesController.Salvar(cliente);
        }
        public bool ValidarDados(Clientes cliente)
        {
             if(string.IsNullOrWhiteSpace(txtNome.Text))
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
        
        

        
    }
}
