using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class SituacaoAtendimentoController
    {
        private FrmCadastroSituacaoAtendimento _frmCadastroSituacaoAtendimento;
        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;

        public SituacaoAtendimentoController(FrmCadastroSituacaoAtendimento view)
        {
            _frmCadastroSituacaoAtendimento = view;
            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();
        }

        public void ListarSituacaoAtendimento(string termo = "")
        {
            try
            {
                var listaSituacaoAtendimento = _situacaoAtendimentoRepository.Listar(termo);
                _frmCadastroSituacaoAtendimento.ExibirSituacaoAtendimento(listaSituacaoAtendimento);
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao Carregar situação do atendimento: {ex.Message}");
            }
        }

        public void Salvar(SituacaoAtendimentos situacaoAtendimento)
        {


            try
            {
                _situacaoAtendimentoRepository.Inserir(situacaoAtendimento);
                _frmCadastroSituacaoAtendimento.ExibirMensagem("Situação_atendimento cadastrado com Sucesso!");
                //Atualizar DataGrid
                ListarSituacaoAtendimento();

               // _frmCadastroSituacaoAtendimento.DesabilitarCampos();


            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao Cadastrar o situação_atendimento: {ex.Message}");
            }
            
        }
        public void Atualizar(SituacaoAtendimentos situacaoAtendimento)
        {

            
            try
            {
                _situacaoAtendimentoRepository.Atualizar(situacaoAtendimento);
                _frmCadastroSituacaoAtendimento.ExibirMensagem("Situação_atendimeto Atualizado com Sucesso!");
                //Atualizar DataGrid
                ListarSituacaoAtendimento();

               // _frmCadastroSituacaoAtendimento.DesabilitarCampos();


            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao Atualizar o Situação_atendimento: {ex.Message}");
            }


        }

        public void Excluir(int id)
        {
            try
            {
                _situacaoAtendimentoRepository.Excluir(id);
                _frmCadastroSituacaoAtendimento.ExibirMensagem("Situação_Atendimento Excluido com Sucesso!");
                ListarSituacaoAtendimento();

               // _frmCadastroSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao Excluir o Situação_Atendimento: {ex.Message}");
            }
        }


    }
    
}
