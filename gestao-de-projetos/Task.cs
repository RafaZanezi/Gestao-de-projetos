﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_projetos
{
    class Task
    {
        private int Id;
        private int IdProjeto;
        private int IdUsuario;
        private string Nome;
        private double Estimate;
        private string Status;

        // atributos flutuantes
        private string NomeUsuario;

        public Task() { }


        // Insert
        public Task(
            String Nome,
            Double Estimate)
        {
            this.Nome = Nome;
            this.Estimate = Estimate;
        }

        public static void Insert(Task NewTask)
        {
            List<QueryParameters> List = new List<QueryParameters>();

            String Query = "INSERT INTO Tarefa(" +
                    "nome_tarefa, " +
                    "tempo_estimado, " +
                ")";

            List.Add(Connection.addQueryListItem("nome_tarefa", NewTask.GetNome()));
            List.Add(Connection.addQueryListItem("tempo_estimado", NewTask.GetEstimate().ToString()));
           
            try { Connection.InsertUpdateData(Query, List); } catch (NpgsqlException e) { throw e; }
        }
        // Update
        public Task(
            int Id,
           String Nome,
           Double Estimate)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Estimate = Estimate;
        }

        public static void Update(Task NewTask)
        {
            List<QueryParameters> List = new List<QueryParameters>();

            String Query = "UPDATE Tarefa SET " +
                    "nome_tarefa=@nome_tarefa," +
                    "WHERE Cod_tarefa = cast(@Cod_tarefa as integer) " +
                ")";

            List.Add(Connection.addQueryListItem("nome_tarefa", NewTask.GetNome()));
            List.Add(Connection.addQueryListItem("tempo_estimado", NewTask.GetEstimate().ToString()));

            try { Connection.InsertUpdateData(Query, List); } catch (NpgsqlException e) { throw e; }
        }



        // List 
        public Task(
            int Id,
            string Nome,
            double Estimate,
            string NomeUsuario)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Estimate = Estimate;
            this.NomeUsuario = NomeUsuario;
        }

        public static List<Task> List(int IdProjeto)
        {


            List <Task> List = new List<Task>();
            List<QueryParameters> ParamsList = new List<QueryParameters>();

            string Query = "SELECT ts.cod_tarefa as id, " +
                                  "ts.nome_tarefa," +
                                  "ts.tempo_estimado, " +
                                  "u.nome as nome_usuario," +
                                  "ts.status " +
                            "FROM tarefa ts " +
                                "INNER JOIN usuario u " +
                                    "ON ts.id_usuario = u.id_usuario " +
                            "WHERE ts.id_projeto = cast(@id_projeto as integer) ";

            ParamsList.Add(Connection.addQueryListItem("id_projeto", IdProjeto.ToString()));

            try {
                return Connection.List<Task>(Query, ParamsList);
            } catch (NpgsqlException e) { throw e; }
        }

        public static void StatusTarefa(int Id, string Status)
        {
            List<QueryParameters> ParamsList = new List<QueryParameters>();

            string Query = "UPDATE tarefa " +
                                "SET status = @status " +
                             "WHERE cod_tarefa = cast(@id as integer) ";

            ParamsList.Add(Connection.addQueryListItem("status", Status));
            ParamsList.Add(Connection.addQueryListItem("id", Id.ToString()));

            try { Connection.InsertUpdateData(Query, ParamsList); } catch (NpgsqlException e) { throw e; }
        }

        public static void Delete(int Id)
        {
            string Query = "DELETE FROM tarefa WHERE cod_tarefa = " + Id;
            try { Connection.Delete(Query); }
            catch (NpgsqlException e) { throw e; }
        }

        public static Task GetByPk(int id)
        {
            String Query = "SELECT cod_tarefa," +
                                 " nome_tarefa," +
                                 " tempo_estimado," +
                                
                           "FROM Task WHERE cod_tarefa = @id";

            try
            {
                return Connection.GetByPk<Task>(Query, id);
            }
            catch (NpgsqlException e) { throw e; }
        }

        public int GetId() { return Id; }
        public void SetId(int Id) { this.Id = Id; }

        public int GetIdProjeto() { return IdProjeto; }
        public void SetIdProjeto(int IdProjeto) { this.IdProjeto = IdProjeto; }

        public int GetIdUsuario() { return IdUsuario; }
        public void SetIdUsuario(int IdUsuario) { this.IdUsuario = IdUsuario; }

        public string GetNome() { return Nome; }
        public void SetNome(string Nome) { this.Nome = Nome; }

        public double GetEstimate() { return Estimate; }
        public void SetEstimate(double Estimate) { this.Estimate = Estimate; }

        public string GetNomeUsuario() { return NomeUsuario; }
        public void SetNomeUsuario(string NomeUsuario) { this.NomeUsuario = NomeUsuario; }

        public string GetStatus() { return Status; }
        public void SetStatus(string Status) { this.Status = Status; }

    }
}
