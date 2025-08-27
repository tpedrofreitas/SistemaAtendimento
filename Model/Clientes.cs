﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimento.Model
{
    public class Clientes
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf_Cnpj { get; set; }
        public string? TipoPessoa { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? Cep {  get; set; }
        public string? Endereco { get; set; }
        public string? Numero    { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade {  get; set; }
        public string? Estado { get; set; }
        public int Ativo { get; set; }


        
    }
}
