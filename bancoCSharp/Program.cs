using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace bancoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;uid=root;password=root");
            try
            {
                conexao.Open();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            string sql ="'select * from login where usuario=" + "\'" + P.Usuario + "\'" + "and senha=" + "\'" + P.Senha + "\'";
            MySqlCommand cmd = new MySqlCommand(this.sql, this.mConn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            //Read vai ler os dados do banco
            rdr.Read();

            //HasRows vai ler linhas do banco
            if (rdr.HasRows) {

                //comparação do usuario com o P.usuario usando Equals, o mesmo com a senha
                if (rdr["usuario"].ToString().Equals(P.Usuario) && rdr["senha"].ToString().Equals(P.Senha)) {
                        
                    //Vai fechar essa linha
                    rdr.Close();
                }

                //Se retornar true, vai retornar o usuario com a senha
                return true;
            }
            else {
                rdr.Close();

                //se nao tiver, vai retornar vazio
                return false;
            }
            try
            {

                String sql = "UPDATE login SET nome = @nome," + "telefone= @telefone WHERE id= @id";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@nome", user.Nome);
                cmd.Parameters.AddWithValue("@telefone", user.Telefone);

                var linhas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            { 
            
            }

          }
       }
    }

