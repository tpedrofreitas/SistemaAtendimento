﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;

namespace SistemaAtendimento.Controller
{
    public class ClienteController
    {
        private FrmCadastroCliente _frmCadastroCliente;
        private ClienteRepository _clienteRepository;
        public ClienteController(FrmCadastroCliente view) 
        {
            _frmCadastroCliente = view;
            _clienteRepository = new ClienteRepository();
        }

        public void ListarClientes()
        {
            try
            {

                var listaClientes = _clienteRepository.Listar();

                _frmCadastroCliente.ExibirClientes(listaClientes);
               
            }
            
            catch (Exception ex)
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao carregar os clientes: { ex.Message}");
            }

                           
            
        }
        public void Salvar(Clientes cliente)
        {
            

            try
            {
                _clienteRepository.Inserir(cliente);
                _frmCadastroCliente.ExibirMensagem("Cliente cadastrado com Sucesso!");
                //Atualizar DataGrid
                ListarClientes();


            }
            catch (Exception ex)
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao Cadastrar o cliente: {ex.Message}");
            }


        }


    }
}
