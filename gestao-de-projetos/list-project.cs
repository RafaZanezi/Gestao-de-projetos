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
                ListViewItem listItem = new ListViewItem(item.GetNome());
                listItem.SubItems.Add(item.GetNomeOrientador());

                // armazena o id para operações
                listItem.Tag = item.GetId();

                listViewProj.Items.Add(listItem);
            }

        }

        private void clickItemProj(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectItem = listViewProj.SelectedItems[0];
                int IdProjeto = (int)selectItem.Tag;

                // Chama dialog com botões personalizados
                actionDialogProj dialog = new actionDialogProj(this, IdProjeto);
                dialog.Size = new Size(300, 150);
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.ShowDialog();
            }
            catch (InvalidCastException c)
            {
                MessageBox.Show(c.Message, "Regitro Indisponível");
            }

        }

        public class actionDialogProj : Form
        {
            list_project list = new list_project();

            public actionDialogProj(list_project listagem, int IdProjeto)
            {
                Label label = new Label();
                label.Text = "Mais opções";
                label.Font = new Font("Arial", 10, FontStyle.Regular);
                label.Size = new Size(230, 25);
                label.Location = new Point(35, 20);
                this.Controls.Add(label);

                MaterialFlatButton edit = new MaterialFlatButton();
                edit.Text = "Editar";
                // adiciona ação ao clique do button
                edit.Click += delegate (object sender, EventArgs args) { this.Close(); /*Adicionar redirecionamento*/};
                edit.Location = new Point(100, 50);
                this.Controls.Add(edit);
            }
        }
    }
}
