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
    public class EtapasAtendimentoRepository
    {
        public List<EtapasAtendimentos> Listar(int atendimentoId)
        {
            var  etapasAtendimento = new List<EtapasAtendimentos>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT * FROM etapas_atendimento WHERE atendimento_id = @atendimentoID";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@atendimentoID",atendimentoId);

                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            etapasAtendimento.Add(new EtapasAtendimentos
                            {
                                Id = Convert.ToInt32( linhas["id"]),
                                AtendimentoId = Convert.ToInt32(linhas["atendimento_id"]),
                                EtapaId = Convert.ToInt32(linhas["etapa_id"]),
                                UsuarioId = Convert.ToInt32(linhas["usuario_id"]),
                                DataCadastro = linhas["data_cadastro"] as DateTime?,
                                Observacao = linhas["observacao"].ToString(),
                            });
                        }
                    }
                }
            }

            return etapasAtendimento;
        }
        public void Inserir(EtapasAtendimentos etapasAtendimento)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO etapas_atendimentos( atendimento_id, etapa_id, usuario_id, data_cadastro,  observacao) VALUES (@atendimentoId, @etapaId, @usuarioId, @dataCadastro, @observacao)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@atendimentoId", etapasAtendimento.AtendimentoId);
                    comando.Parameters.AddWithValue("@etapaId", etapasAtendimento.EtapaId);
                    comando.Parameters.AddWithValue("@usuarioId", etapasAtendimento.UsuarioId);
                    comando.Parameters.AddWithValue("@dataCadastro", etapasAtendimento.DataCadastro);
                    comando.Parameters.AddWithValue("@observacao", etapasAtendimento.Observacao);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }

        }
        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"DELETE FROM etapas_atendimentos WHERE id = @id";

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
