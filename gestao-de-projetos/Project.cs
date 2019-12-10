using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
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
        private String TpVisibilidade; // 'PB' e 'PV'
        private String DtInicio;
        private String DtFim;
        private String LinkRepositorio;

        public Project() { }

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

        public static void Insert(Project NewProject)
        {
            List<QueryParameters> List = new List<QueryParameters>();

            String Query = "INSERT INTO Projeto(" +
                    "nome, " +
                    "ds_link_repositorio, " +
                    "dt_fim, " +
                    "dt_inicio, " +
                    "tp_visibilidade, " +
                    "descricao, " +
                    "nome_orientador" +
                ") VALUES (" +
                    "@nome, " +
                    "@ds_link_repositorio, " +
                    "to_date(@dt_fim, 'yyy-MM-dd'), " +
                    "to_date(@dt_inicio, 'yyy-MM-dd'), " +
                    "@tp_visibilidade, " +
                    "@descricao, " +
                    "@nome_orientador" +
                ")";

            List.Add(Connection.addQueryListItem("nome", NewProject.GetNome()));
            List.Add(Connection.addQueryListItem("ds_link_repositorio", NewProject.GetLinkRepositorio()));
            List.Add(Connection.addQueryListItem("dt_fim", "" + NewProject.GetDtFim()));
            List.Add(Connection.addQueryListItem("dt_inicio", "" + NewProject.GetDtInicio()));
            List.Add(Connection.addQueryListItem("tp_visibilidade", NewProject.GetTpVisibilidade()));
            List.Add(Connection.addQueryListItem("descricao", NewProject.GetDescricao()));
            List.Add(Connection.addQueryListItem("nome_orientador", NewProject.GetNomeOrientador()));

            try { Connection.InsertUpdateData(Query, List); } catch (NpgsqlException e) { throw e; }
        }

        // Update
        public Project(
            int Id,
            String Nome,
            String NomeOrientador,
            String Descricao,
            String TpVisibilidade,
            String DtInicio,
            String DtFim,
            String LinkRepositorio)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.NomeOrientador = NomeOrientador;
            this.TpVisibilidade = TpVisibilidade;
            this.DtInicio = DtInicio;
            this.DtFim = DtFim;
            this.LinkRepositorio = LinkRepositorio;
        }

        public static void Update(Project MyProject)
        {
            List<QueryParameters> List = new List<QueryParameters>();

            String Query = "UPDATE Projeto SET " +
                                "nome = @nome, " +
                                "ds_link_repositorio = @ds_link_repositorio, " +
                                "dt_fim = to_date(@dt_fim, 'yyy-MM-dd'), " +
                                "dt_inicio = to_date(@dt_inicio, 'yyy-MM-dd'), " +
                                "tp_visibilidade = @tp_visibilidade, " +
                                "descricao = @descricao, " +
                                "nome_orientador = @nome_orientador " +
                            "WHERE id_projeto = cast(@id as integer) ";

            List.Add(Connection.addQueryListItem("nome", MyProject.GetNome()));
            List.Add(Connection.addQueryListItem("ds_link_repositorio", MyProject.GetLinkRepositorio()));
            List.Add(Connection.addQueryListItem("dt_fim", "" + MyProject.GetDtFim()));
            List.Add(Connection.addQueryListItem("dt_inicio", "" + MyProject.GetDtInicio()));
            List.Add(Connection.addQueryListItem("tp_visibilidade", MyProject.GetTpVisibilidade()));
            List.Add(Connection.addQueryListItem("descricao", MyProject.GetDescricao()));
            List.Add(Connection.addQueryListItem("nome_orientador", MyProject.GetNomeOrientador()));
            List.Add(Connection.addQueryListItem("id", MyProject.GetId().ToString()));

            try { Connection.InsertUpdateData(Query, List); } catch (NpgsqlException e) { throw e; }
        }

        //ListProj
        public Project(
            int Id,
            string Nome,
            string NomeOrientador,
            string TpVisibilidade)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.NomeOrientador = NomeOrientador;
            this.TpVisibilidade = TpVisibilidade;
        }

        public static List<Project> SelectListProj()
        {
            List<Project> SelectListProj = new List<Project>();
            List<QueryParameters> ParamProject = new List<QueryParameters>();


            string Query = "SELECT pr.id_projeto , " +
                                       "pr.nome," +
                                       "pr.nome_orientador," +
                                       "pr.tp_visibilidade " +
                                       "FROM projeto pr ";

            try
            {
                return Connection.List<Project>(Query, ParamProject);
            }
            catch (NpgsqlException e) { throw e; }
        }

        public static void DeleteProject(int Id)
        {
            string Query = "DELETE FROM projeto WHERE id_projeto = " + Id;
            try { Connection.Delete(Query); }
            catch (NpgsqlException e) { throw e; }
        }

        public static Project GetByPk(int id)
        {
            String Query = "SELECT id_projeto," +
                                 " nome," +
                                 " nome_orientador," +
                                 " descricao, " +
                                 " tp_visibilidade," +
                                 " dt_inicio," +
                                 " dt_fim," +
                                 " ds_link_repositorio " +
                           "FROM Projeto WHERE id_projeto = @id";

            try { 
                return Connection.GetByPk<Project>(Query, id); 
            } catch (NpgsqlException e) { throw e; }
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
