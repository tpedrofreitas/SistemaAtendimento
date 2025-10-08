using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.View;

namespace SistemaAtendimento
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = ConexaoDB.GetConexao())
                {
                    conexao.Open();
                    MessageBox.Show("Conex�o Realizada com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar:" + ex.Message);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usu�riosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }

        private void etapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroEtapa frmCadastroEtapa = new FrmCadastroEtapa();
            frmCadastroEtapa.ShowDialog();
        }

        private void statusAtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroSituacaoAtendimento frmCadastroSitucaoAtendimento = new FrmCadastroSituacaoAtendimento();
            frmCadastroSitucaoAtendimento.ShowDialog();
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void novoAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAtendimento frmAtendimento = new FrmAtendimento();
            frmAtendimento.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();
        }
    }
}

