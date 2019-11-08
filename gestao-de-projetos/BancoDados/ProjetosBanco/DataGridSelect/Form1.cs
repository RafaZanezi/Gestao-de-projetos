using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using NpgsqlTypes;

namespace DataGridSelect
{
    public partial class Form1 : Form
    {
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;

        public Form1()
        {
            InitializeComponent();

            lblCmdSql.Text = "";
        }


        private string criaTextoSql()
        {
            //lista de strings que irá conter os campos selecionados
            List<string> lstCampos = new List<string>();

            //irá conter o comando sql formado a partir dos campos selecionados
            string strCmdSql = "";


            if (cbxNome.Checked)
            {
                lstCampos.Add("nome");
            }

            if (cbxCpf.Checked)
            {
                lstCampos.Add("cpf");
            }

            if (cbxEndereco.Checked)
            {
                lstCampos.Add("endereco");
            }

            if (cbxCep.Checked)
            {
                lstCampos.Add("cep");
            }

            //caso nenhum checkbox tenha sido selecionado
            if (lstCampos.Count() == 0)
            {
                return "";
            }
            //se pelo menos um checkbox foi selecionado
            else
            {
                //começo do comando select
                strCmdSql = "SELECT ";

                //percorre todos os elementos da lista para formar 
                //a parte variável consulta sql
                for (int i = 0; i < lstCampos.Count; i++)
                {
                    strCmdSql += lstCampos.ElementAt(i);

                    //caso não seja o ultimo elemento da lista, insere uma virgula
                    //para separa-lo do proximo elemento !!!
                    if (i != lstCampos.Count - 1)
                    {
                        strCmdSql += ", ";
                    }

                }

                //final do comando select
                strCmdSql += " FROM tb_cliente;";

                return strCmdSql;
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            string strCmdSql = criaTextoSql();

            //exibe o comando select formado
            lblCmdSql.Text = strCmdSql;


            //caso algum checkbox tenha sido selecionado,
            //posso fazer a consulta no banco
            if (strCmdSql != "")
            {
                string strConexao = @"Host=127.0.0.1;Username=postgres;Password=ffoBD@18;Database=bd_lp2";

                //tenta criar uma conexão com o banco
                using (NpgsqlConnection conn = new NpgsqlConnection(strConexao))
                {
                    //abre a conexão com o banco
                    conn.Open();

                    //Cria um novo adaptador para os dados na tabela
                    data_adapter = new NpgsqlDataAdapter();

                    //Cria os objetos que representam os comandos de consulta sql !!!

                    //cria um comando de consulta do tipo select
                    NpgsqlCommand cmd_select = new NpgsqlCommand();
                    cmd_select.Connection = conn;
                    cmd_select.CommandText = strCmdSql;

                    //passa o comando select criado para o datasource usar
                    data_adapter.SelectCommand = cmd_select;

                    //cria e prenche uma tabela com os dados do banco usando o adaptador
                    data_table = new DataTable();
                    data_adapter.Fill(data_table);

                    //diz para o grid utilizar essa tabela como fonte de dados
                    gvClientes.DataSource = data_table;



                } // fim connection

            } //fim if

        } // fim btnExecutar_Click


    }
}
