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
    public class EtapaRepository
    {
        public List<Etapas> Listar(string termo = "")
        {
            var Etapas = new List<Etapas>();
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM etapas";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql = "SELECT * FROM clientes where nome LIKE @termo OR email LIKE @termo";
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
                            Etapas.Add(new Etapas()
                            {

                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Ordem = Convert.ToInt32(linhas["ordem"]),
                                Ativo = Convert.ToBoolean(linhas["ativo"])

                            });


                         }  
                    }
                }
            }
            return Etapas;
        }
        public void Inserir (Etapas etapas)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO etapas (nome,ordem,ativo) VALUES (@nome,@ordem,@ativo)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", etapas.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapas.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapas.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                }
                   

            }
        }

        public void Atualizar(Etapas etapas)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE etapas SET nome=@nome,ordem=@ordem,ativo=@ordem Where id=@id ";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", etapas.Id);
                    comando.Parameters.AddWithValue("@nome", etapas.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapas.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapas.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                }


            }
        }
        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())

            {
                string sql = "DELETE FROM clientes WHERE id=@id";

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
