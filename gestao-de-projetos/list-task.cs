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
    public partial class list_task : MaterialForm
    {
        private int IdProjeto;
        private List<Task> List;

        public list_task(int IdProjeto)
        {
            this.IdProjeto = IdProjeto;
            this.inicialize();
        }

        private void inicialize()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void loadItems(object sender, EventArgs e)
        {
            preencheListagem();
        }

        private void preencheListagem()
        {
            listView.Items.Clear();
            List = Task.List(this.IdProjeto);

            foreach (Task item in List)
            {
                ListViewItem listItem = new ListViewItem(item.GetEstimate().ToString() + "h(s)");
                listItem.SubItems.Add(new ListViewSubItem(listItem, item.GetNome()));
                listItem.SubItems.Add(new ListViewSubItem(listItem, item.GetNomeUsuario()));

                // armazena o id para operações
                listItem.Tag = item.GetId();

                if (item.GetStatus() == "DONE")
                {
                    listItem.Group = listView.Groups[1];
                }
                else
                {
                    listItem.Group = listView.Groups[0];
                }

                listView.Items.Add(listItem);
            }
        }

        private void clickItem(object sender, EventArgs e)
        {
           try
            {
                ListViewItem selectItem = listView.SelectedItems[0];
                int IdProjeto = (int)selectItem.Tag;
                string Status = FindTaskStatus(IdProjeto);

                // Chama dialog com botões personalizados
                actionDialog dialog = new actionDialog(this, IdProjeto, Status);
                dialog.Size = new Size(300, 150);
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.ShowDialog();
            } catch(InvalidCastException c)
            {
                MessageBox.Show(c.Message, "Regitro Indisponível");
            }
        }

        public void alteraStatusTarefa(int IdTarefa, string Status)
        {
            Task.StatusTarefa(IdTarefa, Status);
            preencheListagem();
        }

        public void removerTarefa(int IdTarefa)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover esta tarefa? Esta ação não poderá ser desfeita!", null, MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                Task.Delete(IdTarefa);
                preencheListagem();
            }
        }

        private string FindTaskStatus(int IdTarefa)
        {
            string Status = "";
            foreach(Task item in List)
            {
                if (item.GetId() == IdTarefa) { Status = item.GetStatus(); }
            }

            return Status;
        }
    }

    public class actionDialog : Form
    {

        public actionDialog(list_task listagem, int IdProjeto, string Status)
        {
            Label label = new Label();
            label.Text = "Oque você deseja fazer a seguir?";
            label.Font = new Font("Arial", 10, FontStyle.Regular);
            label.Size = new Size(230, 25);
            label.Location = new Point(35, 20);
            this.Controls.Add(label);

            if (Status == "DONE")
            {
                MaterialFlatButton complete = new MaterialFlatButton();
                complete.Text = "Refazer";
                // adiciona ação ao clique do button
                complete.Click += delegate (object sender, EventArgs args) { this.Close(); listagem.alteraStatusTarefa(IdProjeto, "TODO"); };
                complete.Location = new Point(85, 50);
                this.Controls.Add(complete);
            } else
            {
                MaterialFlatButton complete = new MaterialFlatButton();
                complete.Text = "Completar";
                // adiciona ação ao clique do button
                complete.Click += delegate (object sender, EventArgs args) { this.Close(); listagem.alteraStatusTarefa(IdProjeto, "DONE"); };
                complete.Location = new Point(85, 50);
                this.Controls.Add(complete);
            }

            MaterialFlatButton edit = new MaterialFlatButton();
            edit.Text = "Editar";
            // adiciona ação ao clique do button
            edit.Click += delegate (object sender, EventArgs args) { this.Close(); /* Chamar tela de edição passando o id */ };
            edit.Location = new Point(10, 50);
            this.Controls.Add(edit);

            MaterialRaisedButton delete = new MaterialRaisedButton();
            delete.Text = "Remover";
            // adiciona ação ao clique do button
            delete.Click += delegate (object sender, EventArgs args) { this.Close(); listagem.removerTarefa(IdProjeto); };
            delete.Location = new Point(190, 50);
            this.Controls.Add(delete);
        }
    }
}
