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
        public list_project()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
                       
        }

        private void list_project_Load(object sender, EventArgs e)
        {
        }
    }
}
