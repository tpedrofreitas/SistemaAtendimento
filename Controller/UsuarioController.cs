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
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private UsuarioRepository _usuarioRepository;

        public UsuarioController(FrmCadastroUsuario view)
        {
            _frmCadastroUsuario = view;
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios()
        {
            try
            {
                var listaUsuarios = _usuarioRepository.Listar();
                _frmCadastroUsuario.ExibirUsuarios(listaUsuarios);
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao Carregar usuarios: {ex.Message}");
            }
        }
        public void Salvar(Usuarios usuario)
        {


            try
            {
                _usuarioRepository.Inserir(usuario);
                _frmCadastroUsuario.ExibirMensagem("Usuário cadastrado com Sucesso!");
                //Atualizar DataGrid
                ListarUsuarios();

                _frmCadastroUsuario.DesabilitarCampos();


            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao Cadastrar o usuário: {ex.Message}");
            }


        }
        public void Atualizar(Usuarios usuario)
        {


            try
            {
                _usuarioRepository.Atualizar(usuario);
                _frmCadastroUsuario.ExibirMensagem("Usuário Atualizado com Sucesso!");
                //Atualizar DataGrid
                ListarUsuarios();

                _frmCadastroUsuario.DesabilitarCampos();


            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao Atualizar o Usuário: {ex.Message}");
            }


        }
        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                _frmCadastroUsuario.ExibirMensagem("Usuário Excluido com Sucesso!");
                ListarUsuarios();

                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao Excluir o Usuário: {ex.Message}");
            }
        }

    }
}
