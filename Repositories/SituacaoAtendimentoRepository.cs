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
        public List<SituacaoAtendimentos> Listar()
        {
            var SituacaoAtendimento = new List<SituacaoAtendimentos>();
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM situacao_atendimentos";
                using (var comando = new SqlCommand(sql, conexao))
                {
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
    }
}
