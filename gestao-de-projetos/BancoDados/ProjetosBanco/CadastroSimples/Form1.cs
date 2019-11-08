using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//biblioteca Npgsql
using Npgsql;
using NpgsqlTypes;

namespace CadastroSimples
{
    public partial class FrmClient : Form
    {
        private BindingSource   bind_source;
        private NpgsqlDataAdapter data_adapter;
        private DataTable       data_table;

        public FrmClient()
        {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            //String de conexão com o banco de dados local
            //string strConexao = Properties.Settings.Default.NORTHWNDConnectionString;
            string strConexao = @"Host=127.0.0.1;Username=postgres;Password=ffoBD@18;Database=bd_lp2";

            //String de consulta
            string strSelect = "SELECT * FROM tb_cliente";

            //String de insersão de dados
            string strInsert = "INSERT INTO tb_cliente " +
                                "(nome, cpf, endereco, cep) " +
                                "VALUES( @nome, @cpf, @endereco, @cep);";

            //String de atualização
            string strUpdate = "UPDATE tb_cliente SET " +
                    "nome=@nome, " +
                    "endereco=@endereco, cep=@cep " +
                    "Where cpf = @cpf ;";

            //string de remoção
            string strDelete = "DELETE FROM tb_cliente WHERE cpf = @cpf ;";

            //cria a conexão
            NpgsqlConnection conexao = new NpgsqlConnection(strConexao);

            try
            {
                //Cria um novo adaptador para os dados na tabela
                data_adapter = new NpgsqlDataAdapter();
                data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexao);

                //cria e adiciona um comando de consulta 
                data_adapter.InsertCommand = new NpgsqlCommand(strInsert, conexao);
                data_adapter.InsertCommand.Parameters.Add("@nome", NpgsqlDbType.Varchar, 60, "nome");
                data_adapter.InsertCommand.Parameters.Add("@cpf", NpgsqlDbType.Varchar, 11, "cpf");
                data_adapter.InsertCommand.Parameters.Add("@endereco", NpgsqlDbType.Varchar, 255, "endereco");
                data_adapter.InsertCommand.Parameters.Add("@cep", NpgsqlDbType.Varchar, 11, "cep");

                //cria e adiciona um comando de atualização de dados
                data_adapter.UpdateCommand = new NpgsqlCommand(strUpdate, conexao);
                data_adapter.UpdateCommand.Parameters.Add("@nome", NpgsqlDbType.Varchar, 60, "nome");
                data_adapter.UpdateCommand.Parameters.Add("@cpf", NpgsqlDbType.Varchar, 11, "cpf");
                data_adapter.UpdateCommand.Parameters.Add("@endereco", NpgsqlDbType.Varchar, 255, "endereco");
                data_adapter.UpdateCommand.Parameters.Add("@cep", NpgsqlDbType.Varchar, 11, "cep");

                //cria e adiciona um comando de remoção
                data_adapter.DeleteCommand = new NpgsqlCommand(strDelete, conexao);
                data_adapter.DeleteCommand.Parameters.Add("@cpf", NpgsqlDbType.Varchar, 11, "cpf");

                //cria e prenche uma tabela com os dados do banco usando o adaptador
                data_table = new DataTable();
                data_adapter.Fill(data_table);

                //cria um bindsource usando a tabela como fonte de dados
                bind_source = new BindingSource();
                bind_source.DataSource = data_table;

                //Associa os dados da tabela com a propriedade "Text" dos textbox
                txbCpf.DataBindings.Add("Text", bind_source, "cpf", true);
                txbNome.DataBindings.Add("Text", bind_source, "nome", true);
                txbEndereco.DataBindings.Add("Text", bind_source, "endereco", true);
                txbCep.DataBindings.Add("Text", bind_source, "cep", true);
                //txbFax.DataBindings.Add("Text", bind_source, "Fax", true);

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

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            //move para a primeira linha da tabel
            bind_source.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //move para a linha anterior da tabela
            bind_source.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            //move para a proxima linha da tabela
            bind_source.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            //move para a ultima linha da tabela
            bind_source.MoveLast();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //adiciona uma nova linha na tabela
            bind_source.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //salva todas as mudanças efetuadas no banco
            bind_source.EndEdit();
            data_adapter.Update(data_table);
            MessageBox.Show("Dados Salvos no Banco!");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //remove a linha corrente da tabela
            bind_source.RemoveCurrent();
            bind_source.EndEdit();
            data_adapter.Update(data_table);

            MessageBox.Show("Dados Removidos do Banco!");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cancela a alteração corrente
            bind_source.CancelEdit();
        }
    }
}
