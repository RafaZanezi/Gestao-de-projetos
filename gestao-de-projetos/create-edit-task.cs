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
    public partial class task_create_edit : MaterialForm
    {
       
         int id = 0;
        int idProjeto = 0;

        public task_create_edit()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        public task_create_edit(int id, int idProjeto)
        {
            this.id = id;
            this.idProjeto = idProjeto;
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nome_tarefa.Text == null || Tempo_tarefa.Text == null)
                {
                    MessageBox.Show("Campos obrigatórios não foram preenchidos", "Erro no formulário", MessageBoxButtons.OK);
                }


                Task Mytask = new Task(id,Nome_tarefa.Text, Convert.ToDouble(Tempo_tarefa.Text));
                
                if (this.id == 0)
                {
                    Task.Insert(Mytask);

                }
                else
                {
                    Mytask.SetId(this.id);
                    Task.Update(Mytask);

                }

                this.concluir();
                


            }
            catch (FormatException)
            {
                MessageBox.Show("Tempo invalido", "Erro no formulário", MessageBoxButtons.OK);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message + ex.StackTrace);
            }



        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.concluir();
        }



        private void setFields(Task tsk)
        {
            Nome_tarefa.Text = tsk.GetNome();
            Tempo_tarefa.Text = tsk.GetEstimate().ToString();
        }






        private void concluir()
        {
            this.Hide();
            Form f = new list_task(idProjeto);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void task_create_edit_Load(object sender, EventArgs e)
        {
            if(id > 0)
            {
            this.setFields(Task.GetByPk(this.id));
            }
        }
    }
}
