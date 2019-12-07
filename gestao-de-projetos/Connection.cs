using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Npgsql;
using System.Data;

namespace gestao_de_projetos
{
    class Connection
    {
        private static string connString = @"Host=127.0.0.1;Username=postgres;Password=Senh@123;Database=Gestao_projDB";

        public static QueryParameters addQueryListItem(string Nome, string Valor)
        {
            QueryParameters Params = new QueryParameters();
            Params.SetNome(Nome);
            Params.SetValor(Valor);
            return Params;
        }
        
        public static NpgsqlDataReader ReadData(String Query, List<QueryParameters> QueryParams)
        {
            //tenta criar uma conexão com o banco
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    //abre a conexão com o banco
                    conn.Open();

                    //Cria um novo adaptador para os dados na tabela
                    NpgsqlDataAdapter data_adapter = new NpgsqlDataAdapter();

                    //Cria os objetos que representam os comandos de consulta sql !!!

                    //cria um comando de consulta do tipo select
                    NpgsqlCommand cmd_select = new NpgsqlCommand();
                    cmd_select.Connection = conn;

                    foreach (QueryParameters param in QueryParams)
                    {
                        cmd_select.Parameters.AddWithValue(param.GetNome(), param.GetValor());
                    }

                    return cmd_select.ExecuteReader();
                } catch(Exception e) { throw e; } finally { conn.Close(); }
            } // fim connection
        }

        public static void InsertUpdateData(String Query, List<QueryParameters> QueryParams)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    NpgsqlCommand cmd_select = new NpgsqlCommand();
                    cmd_select.Connection = conn;
                    cmd_select.CommandText = Query;

                    foreach (QueryParameters param in QueryParams)
                    {
                        cmd_select.Parameters.AddWithValue(param.GetNome(), param.GetValor());
                    }

                    int rowsAffected = cmd_select.ExecuteNonQuery();

                    if(rowsAffected == -1)
                    {
                        throw new Exception("Não foi possível inserir o registro");
                    }
                }
                catch (NpgsqlException e) { throw e; } finally { conn.Close(); }
            } // fim connection
        }

        public static Project GetByPk(String Query, int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                try
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader()) //executa o comando que retornará uma tabela
                        {
                            reader.Read();
                            Project prj = new Project();
                            prj.SetId(reader.GetInt32(0));

                            if (!reader.IsDBNull(1)) { prj.SetNome(reader.GetString(1)); }
                            if (!reader.IsDBNull(2)) { prj.SetNomeOrientador(reader.GetString(2)); }
                            if (!reader.IsDBNull(3)) { prj.SetDescricao(reader.GetString(3)); }
                            if (!reader.IsDBNull(4)) { prj.SetTpVisibilidade(reader.GetString(4)); }
                            if (!reader.IsDBNull(5)) { prj.SetDtInicio(reader.GetDateTime(5).ToString()); }
                            if (!reader.IsDBNull(6)) { prj.SetDtFim(reader.GetDateTime(6).ToString()); }
                            if (!reader.IsDBNull(7)) { prj.SetLinkRepositorio(reader.GetString(7)); }

                            return prj;
                        }
                    }
                } catch (NpgsqlException e) { throw e; } finally { conn.Close(); }
            }
        }

    }

    class QueryParameters
    {
        private string Nome;
        private string Valor;

        public string GetNome() { return Nome; }
        public void SetNome(string Nome) { this.Nome = Nome; }
        public string GetValor() { return Valor; }
        public void SetValor(string Valor) { this.Valor = Valor; }
    }
}

