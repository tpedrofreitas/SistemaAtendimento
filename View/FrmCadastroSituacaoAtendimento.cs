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
    }
}
