using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class AtendimentoRepository
    {
        public List<Atendimentos> Listar(string termo = "", string condicao = "")
        {
            var lista = new List<Atendimentos>();
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT  a.*,c.nome AS cliente_nome,  u.nome AS usuario_nome,  s.nome AS situacao_nome,c.cpf_cnpj FROM atendimentos INNER JOIN clientes c ON c.id = a.cliente_id INNER JOIN usuarios u ON u.id = a.usuario_id,INNER JOIN situacao_atendimentos s ON s.id = a.situacao_atendimento_id";

                if (string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                {

                }
            }
            return lista;
        }
        public void Inserir(Atendimentos atendimento)
        {

        }
        public void Atualizar(Atendimentos atendimento)
        {

        }
        public void Excluir(int id)
        {

        }
    }
}
