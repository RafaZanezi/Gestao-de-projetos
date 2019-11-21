using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//biblioteca Material Skin
using MaterialSkin;
using MaterialSkin.Controls;
//biblioteca Npgsql
using Npgsql;
using NpgsqlTypes;

//TODO: Implementar possivel mudança de senha

namespace gestao_de_projetos
{
    public partial class login : MaterialForm
    {   
        //String para a conexão com o banco de dados
        private string strConexao = @"Host=localhost;Username=postgres;Password=12345;Database=bd_gestorprojetos";

        public login()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            //Comando para encontrar nome e senha
            string autorizacao = "select * from usuario where nome = @nome and senha = @senha";

            //Cria conexão
            using (NpgsqlConnection conexao = new NpgsqlConnection(strConexao))
            {   
                //Abre a conexão
                conexao.Open();

                try
                {   //Passa o comando
                    using (NpgsqlCommand comando = new NpgsqlCommand(autorizacao, conexao))
                    {
                        //Adiciona os paramêtros e passa o valor dos Texts
                        comando.Parameters.AddWithValue("@nome", lineUsuario.Text);
                        comando.Parameters.AddWithValue("@senha", lineSenha.Text);

                        //Inicia uma leitura
                        using (NpgsqlDataReader leitura = comando.ExecuteReader())
                        {
                            //Se a leitura puder ser lida irá para outra página se não irá retornar um message box
                            if (leitura.Read() == true)
                            {
                                //Manda para a próxima tela
                                this.Hide();
                                Form f = new createEditForm();
                                f.Closed += (s, args) => this.Close();
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha incorreta!");
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
                    //Fecha o conexão
                    conexao.Close();
                }

            }
        }
    }
}
