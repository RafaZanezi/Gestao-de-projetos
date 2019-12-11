using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;

namespace gestao_de_projetos
{
    public partial class Registration : MaterialForm
    {
        //Se não der tempo exclui essa e a gente apresenta sem insert//
        public Registration()
        {
            this.inicializar();
        }

        private void inicializar()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            List<QueryParameters> List = new List<QueryParameters>();

            String Query = "INSERT INTO Usuario(" +
                   "nome, " +
                   "senha, " +
                   "pergunta_emergnc, "+
                   "resposta_emergnc, " +
               ") VALUES (" +
                   "@nome, " +
                   "@senha, " +
                   "@pergunta_emergnc, " +
                   "@resposta_emergnc, " +
               ")";

            List.Add(Connection.addQueryListItem("nome", nome_usu.Text));
            List.Add(Connection.addQueryListItem("senha", senha_usu.Text));
            List.Add(Connection.addQueryListItem("pergunta_emergnc", pergunta_emergencia.Text));
            List.Add(Connection.addQueryListItem("senha", Resp_pergunta.Text));


            try { Connection.InsertUpdateData(Query, List); } catch (NpgsqlException excp) { throw excp; }

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
