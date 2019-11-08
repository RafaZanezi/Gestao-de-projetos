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

namespace DataGrid
{
    public partial class Form1 : Form
    {
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string strConexao = Properties.Settings.Default.PostgresConnectionString;

            //String de conexão com o banco de dados local
            string strConexao = @"Host=127.0.0.1;Username=postgres;Password=ffoBD@18;Database=bd_lp2";


            //String com o comado select
            //string strSelect = "SELECT nome, cpf, endereco, cep FROM tb_cliente";
            string strSelect = "SELECT * FROM tb_cliente";

            //cria a conexão
            NpgsqlConnection conexao = new NpgsqlConnection(strConexao);

            try
            {
                //Cria um novo adaptador para os dados na tabela
                data_adapter = new NpgsqlDataAdapter();
                data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexao);


                //cria os comandos insert update e delete
                NpgsqlCommandBuilder cmdBuilder = new NpgsqlCommandBuilder(data_adapter);

                //Diz que iremos utilizar "colchetes" para especificar objetos 
                //de banco de dados (tabelas, colunas...)cujos nomes contenham caracteres 
                //como espaços ou símbolos reservados;
                cmdBuilder.QuotePrefix = "[";
                cmdBuilder.QuoteSuffix = "]";

                //cria e prenche uma tabela com os dados do banco usando o adaptador
                data_table = new DataTable();
                data_adapter.Fill(data_table);

                //diz para o grid utilizar essa tabela como fonte de dados
                gvClientes.DataSource = data_table;

            }
            //monitora possíveis erros
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            //fecha a conexão
            finally
            {
                conexao.Close();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // sem o "SqlCommandBuilder" essa linha irá gerar um erro
            //passa os dados da tabela para o adapter que se conecta com o banco
            //e o atualiza
            data_adapter.Update(data_table);
            MessageBox.Show("Dados Salvos!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gvClientes.SelectedRows)
            {
                gvClientes.Rows.RemoveAt(item.Index);
            }

            // sem o "SqlCommandBuilder" essa linha irá gerar um erro
            //passa os dados da tabela para o adapter que se conecta com o banco
            //e o atualiza
            data_adapter.Update(data_table);
        }
    }
}
