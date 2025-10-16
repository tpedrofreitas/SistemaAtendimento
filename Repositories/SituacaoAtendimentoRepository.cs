using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class SituacaoAtendimentoRepository
    {
        public List<SituacaoAtendimentos> Listar(string termo = "")
        {
            var SituacaoAtendimento = new List<SituacaoAtendimentos>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM situacao_atendimentos";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql = "SELECT * FROM Situacao_atendimentos WHERE nome LIKE @termo";
                }
                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                    }
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            SituacaoAtendimento.Add(new SituacaoAtendimentos()
                            {

                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Cor = linhas["cor"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])

                            });


                        }
                    }
                }
            }
            return SituacaoAtendimento;
        }
        public void Inserir(SituacaoAtendimentos situacaoatendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO situacao_atendimentos (nome,cor,ativo) VALUES (@nome,@cor,@ativo)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", situacaoatendimentos.Nome);
                    comando.Parameters.AddWithValue("@cor", situacaoatendimentos.Cor);
                    comando.Parameters.AddWithValue("@ativo", situacaoatendimentos.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                }


            }
        }
        public void Atualizar(SituacaoAtendimentos situacaoAtendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE situacao_atendimentos SET nome=@nome, cor=@cor, ativo=@ativo, Where id=@id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", situacaoAtendimentos.Id);
                    comando.Parameters.AddWithValue("@nome", situacaoAtendimentos.Nome);
                    comando.Parameters.AddWithValue("@cor", situacaoAtendimentos.Cor);
                    comando.Parameters.AddWithValue("@ativo", situacaoAtendimentos.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }

            }
        }
        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())

            {
                string sql = "DELETE FROM situacao_atendimentos  WHERE id=@id";

                using (var comando = new SqlCommand(sql, conexao))
                {

                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
