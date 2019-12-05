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


namespace gestao_de_projetos
{
    public partial class Task_Registration : MaterialForm
    {
        public Task_Registration()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void Task_Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
