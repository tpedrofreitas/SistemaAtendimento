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
    public class UsuarioRepository
    {
        public List<Usuarios> Listar(string termo = "")
        {
            var Usuarios = new List<Usuarios>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM usuarios ";
                if (!string.IsNullOrEmpty(termo))
                {
                    sql = "SELECT * FROM usuarios where nome LIKE @termo OR email LIKE @termo";
                }
                using (var comando = new SqlCommand (sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                    }
                    conexao.Open ();
                    using (var linhas = comando.ExecuteReader ())
                    {
                        while (linhas.Read())
                        {
                            Usuarios.Add(new Model.Usuarios() {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Senha = linhas["senha"].ToString(),
                                Perfil = linhas["perfil"].ToString(),
                            });
                        }       
                    }
                }
            }
            return Usuarios;
        }
        public void Inserir(Usuarios usuarios)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO usuarios (nome,email,senha,perfil) VALUES (@nome,@email,@senha,@perfil)";

                using(var comando = new SqlCommand ( sql, conexao))
                {
                    comando.Parameters.AddWithValue("nome", usuarios.Nome);
                    comando.Parameters.AddWithValue("email", usuarios.Email);
                    comando.Parameters.AddWithValue("senha", usuarios.Senha);
                    comando.Parameters.AddWithValue("perfil", usuarios.Perfil);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                }
            }
        }
        public void Atualizar(Usuarios usuarios)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE usuarios SET nome=@nome,email=@email,senha=@senha,perfil=@perfil"; 

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", usuarios.Nome);
                    comando.Parameters.AddWithValue("@email", usuarios.Email);
                    comando.Parameters.AddWithValue("@senha", usuarios.Senha);
                    comando.Parameters.AddWithValue("@perfil", usuarios.Perfil);

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
