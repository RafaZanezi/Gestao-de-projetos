using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//biblioteca Npgsql;
using Npgsql;

namespace Conexao
{
    class Program
    {
        static void Main(string[] args)
        {

            //string de conexão com o banco de dados
            string connString = @"Host=127.0.0.1;Username=postgres;Password=ffoBD@18;Database=bd_lp2";

            //tenta criar uma conexão com o banco
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                //abre a conexão com o banco
                conn.Open();

                // Executa uma consulta que não retorna nenhum valor
                // Insere um registro na tabela
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn; //atribui uma conexão ao comando (obrigatorio)

                    //variáveis contendo os dados que queremos inserir no banco
                    string nome = "José Campos Almeida";
                    string cpf = "11122233344";
                    string endereco = "Rua Jundiaí";
                    string cep = "11111222";

                    //seta o comando sql que será executado
                    cmd.CommandText = "INSERT INTO tb_cliente (nome, cpf, endereco, cep)" + 
                                      "VALUES ( @nome, @cpf, @endereco, @cep)";

                    //seta os parametros que deverão ser passados para a consulta sql
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("cpf", cpf);
                    cmd.Parameters.AddWithValue("endereco", endereco);
                    cmd.Parameters.AddWithValue("cep", cep);

                    //executa o comando / consulta sql
                    cmd.ExecuteNonQuery();
                }
                
 
                //Executa uma consulta que retorna uma tabela
                // Lê todas a linhas da tabela
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM tb_cliente", conn)) //comando de seleção
                using (NpgsqlDataReader reader = cmd.ExecuteReader()) //executa o comando que retornará uma tabela
                {
                    int numLinha = 0;

                    //lê uma linha
                    while (reader.Read())
                    {

                        Console.WriteLine("Linha: " + numLinha++);
                        Console.WriteLine("\tpk_cliente: " + reader.GetInt32(0));
                        Console.WriteLine("\tnome: " + reader.GetString(1));
                        Console.WriteLine("\tcpf: " + reader.GetString(2));
                        Console.WriteLine("\tendereco: " + reader.GetString(3));
                        Console.WriteLine("\tcep: " + reader.GetString(4));
                        Console.WriteLine();

                    }
                }


                //Executa uma consulta que devolve um escalar
                //retorna o total de linhas da tabela
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM tb_cliente", conn)) //comando de seleção
                {
                    long count = (long)cmd.ExecuteScalar();
                    Console.WriteLine("Total de Registos: " + count);
                }


            }
        }
    }
}
