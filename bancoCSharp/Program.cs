using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}
