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
    public partial class login : MaterialForm
    {
        public login()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new createEditForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
