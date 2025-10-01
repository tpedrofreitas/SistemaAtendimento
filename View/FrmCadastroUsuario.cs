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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroUsuario : Form
    {
        private UsuarioController _usuarioController;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);

        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            _usuarioController.ListarUsuarios();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirUsuarios(List<Usuarios> usuarios)
        {
            dgvUsuarios.DataSource = usuarios;
        }

        private bool ValidarDados(Usuarios usuarios)
        {
            if (string.IsNullOrWhiteSpace(usuarios.Nome))
            {
                ExibirMensagem("O campo 'Nome' é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(usuarios.Senha))
            {
                ExibirMensagem("O campo 'Senha' é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(usuarios.Perfil))
            {
                ExibirMensagem("O campo 'Perfil' é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(usuarios.Email))
            {
                ExibirMensagem("O campo 'Email' é obrigatório.");
                return false;
            }

            return true;
        }
        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtSenha.ReadOnly = false;
            cbxPerfil.Enabled = true;
            txtEmail.ReadOnly = false;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
       
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            cbxPerfil.Text = "";
            txtEmail.Clear();
        }
        public void DesabilitarCampos()
        {
            txtNome.ReadOnly = true;
            txtSenha.ReadOnly = true;
            cbxPerfil.Enabled = false;
            txtEmail.ReadOnly = true;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelicionada = dgvUsuarios.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelicionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelicionada.Cells["Nome"].Value.ToString();
                txtSenha.Text = linhaSelicionada.Cells["Senha"].Value.ToString();
                cbxPerfil.Text = linhaSelicionada.Cells["Perfil"].Value.ToString();
                txtEmail.Text = linhaSelicionada.Cells["Email"].Value.ToString();


                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios()
            {
                Nome = txtNome.Text,
                Senha = txtSenha.Text,
                Email = txtEmail.Text,
                Perfil = cbxPerfil.Text,
            };
            if (!ValidarDados(usuarios))
                return;

            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                _usuarioController.Salvar(usuarios);
            }
            else
            {
                usuarios.Id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Atualizar(usuarios);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                ExibirMensagem("Selecione um Usuário");
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja Excluir este Usuário", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Excluir(id);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }
    }
}
