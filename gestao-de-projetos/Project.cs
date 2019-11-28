using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_de_projetos
{
    class Project
    {
        private int Id;
        private String Nome;
        private String Descricao;
        private String NomeOrientador;
        private String TpVisibilidade; // 'PUB' e 'PVD'
        private String DtInicio;
        private String DtFim;
        private String LinkRepositorio;

        // Insert
        public Project(
            String Nome,
            String NomeOrientador,
            String Descricao,
            String TpVisibilidade,
            String DtInicio,
            String DtFim,
            String LinkRepositorio)
        {
            this.Nome = Nome;
            this.NomeOrientador = NomeOrientador;
            this.Descricao = Descricao;
            this.TpVisibilidade = TpVisibilidade;
            this.DtInicio = DtInicio;
            this.DtFim = DtFim;
            this.LinkRepositorio = LinkRepositorio;
        }

        public void Insert(Project NewProject)
        {
            List<QueryParameters> List = new List<QueryParameters>();

            String Query = "INSERT INTO Projeto(" +
                    "nome, " +
                    "ds_link_repositorio, " +
                    "dt_fim, " +
                    "dt_inicio, " +
                    "tp_visibilidade, " +
                    "descricao" +
                ") VALUES (" +
                    "@nome, " +
                    "@ds_link_repositorio, " +
                    "to_date(@dt_fim, 'yyy-MM-dd'), " +
                    "to_date(@dt_inicio, 'yyy-MM-dd'), " +
                    "@tp_visibilidade, " +
                    "@descricao" +
                ")";

            List.Add(Connection.addQueryListItem("nome", NewProject.GetNome()));
            List.Add(Connection.addQueryListItem("ds_link_repositorio", NewProject.GetLinkRepositorio()));
            List.Add(Connection.addQueryListItem("dt_fim", "" + NewProject.GetDtFim()));
            List.Add(Connection.addQueryListItem("dt_inicio", "" + NewProject.GetDtInicio()));
            List.Add(Connection.addQueryListItem("tp_visibilidade", NewProject.GetTpVisibilidade()));
            List.Add(Connection.addQueryListItem("descricao", NewProject.GetDescricao()));

            try{ Connection.InsertData(Query, List); } catch(NpgsqlException e ) { throw e; }
        }

        // Update
        public Project(
            int Id,
            String Nome,
            String NomeOrientador,
            String TpVisibilidade,
            String DtInicio,
            String DtFim,
            String LinkRepositorio)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.NomeOrientador = NomeOrientador;
            this.TpVisibilidade = TpVisibilidade;
            this.DtInicio = DtInicio;
            this.DtFim = DtFim;
            this.LinkRepositorio = LinkRepositorio;
        }

        public void Update()
        {

        }

        // List
        public Project(
            int Id,
            String Nome,
            String NomeOrientador,
            String DtFim)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.NomeOrientador = NomeOrientador;
            this.DtFim = DtFim;
        }

        public List<Project> List()
        {
            return new List<Project>();
        }

        public static string configVisibilidade(Boolean isPublic)
        {
            if (isPublic == false) { return "PV"; }  else { return "PB"; }
        }

        public int GetId() { return Id; }
        public void SetId(int Id) { this.Id = Id; }

        public String GetNome() { return Nome; }
        public void SetNome(String Nome) { this.Nome = Nome; }

        public String GetDescricao() { return Descricao; }
        public void SetDescricao(String Descricao) { this.Descricao = Descricao; }

        public String GetNomeOrientador() { return NomeOrientador; }
        public void SetNomeOrientador(String NomeOrientador) { this.NomeOrientador = NomeOrientador; }

        public String GetTpVisibilidade() { return TpVisibilidade; }
        public void SetTpVisibilidade(String TpVisibilidade) { this.TpVisibilidade = TpVisibilidade; }

        public String GetDtInicio() { return DtInicio; }
        public void SetDtInicio(String DtInicio) { this.DtInicio = DtInicio; }

        public String GetDtFim() { return DtFim; }
        public void SetDtFim(String DtFim) { this.DtFim = DtFim; }

        public String GetLinkRepositorio() { return LinkRepositorio; }
        public void SetLinkRepositorio(String LinkRepositorio) { this.LinkRepositorio = LinkRepositorio; }

    }
}
