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
        
        public static List<T> List<T>(String Query, List<QueryParameters> QueryParams)
        {
            //é uma list genérica essa T da pra usar com tudo

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                try
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(Query, conn))
                    {
                        foreach (QueryParameters param in QueryParams)
                        {
                            cmd.Parameters.AddWithValue(param.GetNome(), param.GetValor());
                        }

                        using (NpgsqlDataReader reader = cmd.ExecuteReader()) //executa o comando que retornará uma tabela
                        {
                            // Retornara um objecto de acordo com o tipo especificado em T
                            List<T> genericList = new List<T>();

                            //Como ele tambem faz uma list do tipo T ele compara a Task com
                            //a T(Que é a do método) elas tem que ser iguais
                            if (typeof(Task) == typeof(T))
                            {
                                while(reader.Read())
                                {
                                    Task Tarefa = new Task();

                                    if (!reader.IsDBNull(0)) { Tarefa.SetId(reader.GetInt32(0)); }
                                    if (!reader.IsDBNull(1)) { Tarefa.SetNome(reader.GetString(1)); }
                                    if (!reader.IsDBNull(2)) { Tarefa.SetEstimate(reader.GetDouble(2)); }
                                    if (!reader.IsDBNull(3)) { Tarefa.SetNomeUsuario(reader.GetString(3)); }
                                    if (!reader.IsDBNull(4)) { Tarefa.SetStatus(reader.GetString(4)); }

                                    Object obj = Tarefa;
                                    T returnTask = (T)obj;
                                    genericList.Add(returnTask);
                                }
                            }else if(typeof(Project) == typeof(T))
                            {
                                while (reader.Read())
                                {
                                    Project ProjetoList = new Project();

                                    if (!reader.IsDBNull(0)) { ProjetoList.SetId(reader.GetInt32(0)); }
                                    if (!reader.IsDBNull(1)) { ProjetoList.SetNome(reader.GetString(1)); }
                                    if (!reader.IsDBNull(2)) { ProjetoList.SetNomeOrientador(reader.GetString(2)); }
                                    if (!reader.IsDBNull(3)) { ProjetoList.SetTpVisibilidade(reader.GetString(3)); }
                                    if (!reader.IsDBNull(4)) { ProjetoList.SetDtInicio(reader.GetDateTime(4).ToString()); }
                                    if (!reader.IsDBNull(5)) { ProjetoList.SetDtFim(reader.GetDateTime(5).ToString()); }

                                    Object obj = ProjetoList;
                                    T returnProject = (T)obj;
                                    genericList.Add(returnProject);
                                }

                            }

                            return genericList;

                        }
                    }
                }
                catch (NpgsqlException e) { throw e; }
                finally { conn.Close(); }
            }
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

        public static T GetByPk<T>(String Query, int id)
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
                            // Retornara um objecto de acordo com o tipo especificado em T
                            Object obj = new Object();

                            if (typeof(Project) == typeof(T))
                            {
                                obj = configProject(reader);
                            }

                            return (T)obj;
                        }
                    }
                } catch (NpgsqlException e) { throw e; } finally { conn.Close(); }
            }
        }

        public static void Delete(string Query)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    NpgsqlCommand cmd_select = new NpgsqlCommand();
                    cmd_select.Connection = conn;
                    cmd_select.CommandText = Query;

                    int rowsAffected = cmd_select.ExecuteNonQuery();

                    if (rowsAffected == -1)
                    {
                        throw new Exception("Não foi possível remover o registro");
                    }
                }
                catch (NpgsqlException e) { throw e; }
                finally { conn.Close(); }
            }
        }

        private static Project configProject(NpgsqlDataReader reader)
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

