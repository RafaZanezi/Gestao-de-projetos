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
// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

namespace gestao_de_projetos
{
    public partial class login : MaterialForm
    {
        private string strConexao = @"Host=localhost;Username=postgres;Password=12345;Database=bd_gestorprojetos";

        public login()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void login_Load(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string autorizacao = "select * from usuario where nome = @nome and senha = @senha";

            using (NpgsqlConnection conexao = new NpgsqlConnection(strConexao))
            {
                conexao.Open();

                try
                {
                    using (NpgsqlCommand comando = new NpgsqlCommand(autorizacao, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", lineUsuario.Text);
                        comando.Parameters.AddWithValue("@senha", lineSenha.Text);

                        using (NpgsqlDataReader leitura = comando.ExecuteReader())
                        {
                            if (leitura.Read() == true)
                            {
                                MessageBox.Show("Usuario e senha encontrados");
                            }
                            else
                            {
                                MessageBox.Show("Acesso negado");
                            }
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                finally
                {
                    conexao.Close();
                }

                this.Hide();
                Form f = new createEditForm();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }

        }
    }
}
