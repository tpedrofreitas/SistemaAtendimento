using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;
using static System.Net.WebRequestMethods;

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

            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                _clientesController.Salvar(cliente);
            }
            else
            {
                cliente.Id = Convert.ToInt32(txtCodigo.Text);
                _clientesController.Atualizar(cliente);
            }


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

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show("Funcionou");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelicionada = dgvClientes.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelicionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelicionada.Cells["Nome"].Value.ToString();
                txtEmail.Text = linhaSelicionada.Cells["Email"].Value.ToString();
                txtCpfCnpj.Text = linhaSelicionada.Cells["Cpf_Cnpj"].Value.ToString();
                txtTelefone.Text = linhaSelicionada.Cells["Telefone"].Value.ToString();
                txtCelular.Text = linhaSelicionada.Cells["Celular"].Value.ToString();
                txtCep.Text = linhaSelicionada.Cells["Cep"].Value.ToString();
                txtEndereco.Text = linhaSelicionada.Cells["Endereco"].Value.ToString();
                txtNumero.Text = linhaSelicionada.Cells["Numero"].Value.ToString();
                txtComplemento.Text = linhaSelicionada.Cells["Complemento"].Value.ToString();
                txtBairro.Text = linhaSelicionada.Cells["Bairro"].Value.ToString();
                txtCidade.Text = linhaSelicionada.Cells["Cidade"].Value.ToString();
                cbxEstado.Text = linhaSelicionada.Cells["Estado"].Value.ToString();
                rdbJuridica.Checked = linhaSelicionada.Cells["TipoPessoa"].Value.ToString() == "J";
                rdbFisica.Checked = linhaSelicionada.Cells["TipoPessoa"].Value.ToString() == "F";
                rdbAtivo.Checked = Convert.ToBoolean(linhaSelicionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelicionada.Cells["Ativo"].Value);

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
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                ExibirMensagem("Selecione um cliente");
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja Excluir este Cliente", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _clientesController.Excluir(id);
            }
        }

        private async Task BuscarEnderecoPorCep(string cep)
        {
            try
            {
                cep = cep.Replace("-", "").Trim();


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";

                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)


                    {
                        string json = await response.Content.ReadAsStringAsync();

                        dynamic? dadosEndereco = JsonConvert.DeserializeObject(json);

                        if (dadosEndereco?["erro"] != null && (bool)dadosEndereco?["erro"])
                        {
                            ExibirMensagem("CEP não encontrado!");
                            return;
                        }

                        txtEndereco.Text = dadosEndereco?.logradouro;
                        txtBairro.Text = dadosEndereco?.bairro;
                        txtCidade.Text = dadosEndereco?.localidade;
                        cbxEstado.Text = dadosEndereco?.uf;

                    }

                }
            }
            catch (Exception ex)
            {
                ExibirMensagem($"Erro ao buscar o Endereço:{ex.Message}");
            }
        }

        private async void txtCep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCep.Text))
            {
                await BuscarEnderecoPorCep(txtCep.Text);


            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _clientesController.ListarClientes(termo);
        }
    }
}
