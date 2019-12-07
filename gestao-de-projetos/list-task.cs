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
using static System.Windows.Forms.ListViewItem;

namespace gestao_de_projetos
{
    public partial class list_task : MaterialForm
    {
        private int IdProjeto;

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
            List<Task> List = Task.List(this.IdProjeto);

            foreach (Task item in List)
            {
                ListViewItem listItem = new ListViewItem(item.GetNome());
                listItem.SubItems.Add(new ListViewSubItem(listItem, item.GetEstimate().ToString()));
                listItem.SubItems.Add(new ListViewSubItem(listItem, item.GetNomeUsuario()));

                if(item.GetStatus() == "DONE")
                {
                    listItem.Group = listView.Groups[1];
                } else
                {
                    listItem.Group = listView.Groups[0];
                }
                
                listView.Items.Add(listItem);
                
            }
        }

    }
}
