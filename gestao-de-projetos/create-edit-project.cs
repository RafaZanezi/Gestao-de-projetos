using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;
using System.Globalization;

namespace gestao_de_projetos
{
    public partial class createEditForm : MaterialForm
    {
        Boolean isAlteracao = false;
        public createEditForm()
        {
            //if (isAlteracao)
            //{
             //   lblContexto.Text = "Editar projeto";
                // TODO: Setar valores que vierem do banco nos campos
            //}
            //else
            //{
            //    lblContexto.Text = "Novo projeto";
            //}

            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void statusLinkRepositorio(object sender, EventArgs e)
        {
            linkRepositorio.Visible = !linkRepositorio.Visible;
        }

        private void cancelar(object sender, EventArgs e)
        {
            this.concluir();
        }

        private void createEditForm_Load(object sender, EventArgs e)
        {
        }

        private void save(object sender, EventArgs e)
        {
            if(nomeProjeto.Text == null || nomeOrientador.Text == null || 
               dtInicioProjeto.Text == null || dtFimProjeto.Text == null)
            {
                MessageBox.Show("Campos obrigatórios não foram preenchidos", "Erro no formulário", MessageBoxButtons.OK);
            }

            string tpVisibilidade = Project.configVisibilidade(projetoPublico.Checked);

            try
            {
                // FormatException
                DateTime resultDtInicio = DateTime.ParseExact(dtInicioProjeto.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                DateTime resultDtFim = DateTime.ParseExact(dtFimProjeto.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                if (resultDtInicio >= resultDtFim)
                {
                    MessageBox.Show("Período inválido de datas", "Erro no formulário", MessageBoxButtons.OK);
                }
                else
                {
                    Project NewProject = new Project(nomeProjeto.Text,
                                                     nomeOrientador.Text,
                                                     descricaoProjeto.Text,
                                                     tpVisibilidade,
                                                     resultDtInicio.ToString("yyyy-MM-dd"),
                                                     resultDtFim.ToString("yyyy-MM-dd"),
                                                     linkRepositorio.Text);
                    // NpgsqlException e Exception
                    NewProject.Insert(NewProject);
                    this.concluir();
                }
            } catch (FormatException)
            {
                MessageBox.Show("Data inválida", "Erro no formulário", MessageBoxButtons.OK);
            } catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message + ex.StackTrace);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        private void concluir()
        {
            this.Hide();
            Form f = new list_project();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
