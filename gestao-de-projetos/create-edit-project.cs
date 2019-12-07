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
        int id = 0; // id do projeto para casos de edição
        
        public createEditForm()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        // sobrecarca para update
        public createEditForm(int id)
        {
            this.id = id;
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
            if(this.id != 0)
            {
                this.setFields(Project.GetByPk(this.id));
            }
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
                    string ds_link = "";
                    if(possuiRepositorio.Checked)
                    {
                        ds_link = linkRepositorio.Text;
                    }
                    Project MyProject = new Project(nomeProjeto.Text,
                                                    nomeOrientador.Text,
                                                    descricaoProjeto.Text,
                                                    tpVisibilidade,
                                                    resultDtInicio.ToString("yyyy-MM-dd"),
                                                    resultDtFim.ToString("yyyy-MM-dd"),
                                                    ds_link);
                    
                    if(this.id == 0)
                    {
                        // NpgsqlException e Exception
                        Project.Insert(MyProject);
                    } else
                    {
                        // NpgsqlException e Exception
                        MyProject.SetId(this.id);
                        Project.Update(MyProject);
                    }

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

        private void setFields(Project prj)
        {
            nomeProjeto.Text = prj.GetNome();
            nomeOrientador.Text = prj.GetNomeOrientador();
            descricaoProjeto.Text = prj.GetDescricao();
            projetoPublico.Checked = prj.GetTpVisibilidade() == "PB";

            dtInicioProjeto.Text = DateTime.Parse(prj.GetDtInicio()).ToString("dd-MM-yyyy");
            dtFimProjeto.Text = DateTime.Parse(prj.GetDtFim()).ToString("dd-MM-yyyy");

            possuiRepositorio.Checked = prj.GetLinkRepositorio() != "";
            linkRepositorio.Text = prj.GetLinkRepositorio();
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
