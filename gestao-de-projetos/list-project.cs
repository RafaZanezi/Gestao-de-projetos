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
    }
}
