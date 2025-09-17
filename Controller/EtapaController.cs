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
    public class EtapaController
    {
        private FrmCadastroEtapa _frmCadastroEtapa;
        private EtapaRepository _etapaRepository;

        public EtapaController(FrmCadastroEtapa view)
        {
            _frmCadastroEtapa = view;
            _etapaRepository = new EtapaRepository();
        }

        public void ListarEtapas()
        {
            try
            {
                var listaEtapas = _etapaRepository.Listar();
                _frmCadastroEtapa.ExibirEtapas(listaEtapas);
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao Carregar etapas: {ex.Message}");
            }

        }

         
        public void Salvar(Etapas etapa)
        {


            try
            {
                _etapaRepository.Inserir(etapa);
                _frmCadastroEtapa.ExibirMensagem("Etapa cadastrado com Sucesso!");
                //Atualizar DataGrid
                ListarEtapas();

               // _frmCadastroEtapa.DesabilitarCampos();


            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao Cadastrar Etapa: {ex.Message}");
            }


        }
    }
}
