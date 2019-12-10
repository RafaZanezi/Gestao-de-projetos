using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.ListViewItem;

namespace gestao_de_projetos
{
    public partial class list_project : MaterialForm
    {
        private List<Project> List;

        public list_project()
        {
            this.inicialize();

        }

        private void inicialize()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void list_project_Load(object sender, EventArgs e)
        {
            preencheListagem();
        }

        private void preencheListagem()
        {
            listViewProj.Items.Clear();

            List = Project.SelectListProj();

            foreach (Project item in List)
            {
                ListViewItem listItem;

                if(item.GetTpVisibilidade() == "PB")
                {
                    listItem = new ListViewItem(item.GetNome());
                    listItem.SubItems.Add(item.GetNomeOrientador());
                    
                    // armazena o id para operações
                    listItem.Tag = item.GetId();
                    listViewProj.Items.Add(listItem);
                }

            }

        }


        public void retornaEdicao(int IdProjeto)
        {
            ListViewItem selectItem = listViewProj.SelectedItems[0];
            IdProjeto = (int)selectItem.Tag;

            this.Hide();
            Form f = new createEditForm(IdProjeto);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        public void retornaTarefa(int IdProjeto)
        {
            ListViewItem selectItem = listViewProj.SelectedItems[0];
            IdProjeto = (int)selectItem.Tag;

            this.Hide();
            Form f = new list_task(IdProjeto);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        public void removerProjeto(int IdProjeto)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover esta tarefa? Esta ação não poderá ser desfeita!", null, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Project.DeleteProject(IdProjeto);
                preencheListagem();
            }

        }

        private void clickItemProj(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectItem = listViewProj.SelectedItems[0];
                int IdProjeto = (int)selectItem.Tag;

                // Chama dialog com botões personalizados
                actionDialogProject dialog = new actionDialogProject(this, IdProjeto);
                dialog.Size = new Size(300, 150);
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.ShowDialog();
            }
            catch (InvalidCastException c)
            {
                MessageBox.Show(c.Message, "Registro Indisponível");
            }

        }

    }

    public class actionDialogProject : Form
    {

        public actionDialogProject(list_project listProject, int IdProjeto)
        {
            Label label = new Label();
            label.Text = "Oque você deseja fazer a seguir?";
            label.Font = new Font("Arial", 10, FontStyle.Regular);
            label.Size = new Size(230, 25);
            label.Location = new Point(35, 20);
            this.Controls.Add(label);

            MaterialFlatButton edit = new MaterialFlatButton();
            edit.Text = "Editar";
            // adiciona ação ao clique do button
            edit.Click += delegate (object sender, EventArgs args) { this.Close(); listProject.retornaEdicao(IdProjeto);};
            edit.Location = new Point(10, 50);
            this.Controls.Add(edit);

            MaterialFlatButton taskList = new MaterialFlatButton();
            taskList.Text = "Tarefas";
            // adiciona ação ao clique do button
            taskList.Click += delegate (object sender, EventArgs args) { this.Close(); listProject.retornaTarefa(IdProjeto);};
            taskList.Location = new Point(85, 50);
            this.Controls.Add(taskList);

            MaterialRaisedButton delete = new MaterialRaisedButton();
            delete.Text = "Remover";
            // adiciona ação ao clique do button
            delete.Click += delegate (object sender, EventArgs args) { this.Close(); listProject.removerProjeto(IdProjeto); };
            delete.Location = new Point(190, 50);
            this.Controls.Add(delete);
        }
    }
}
