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
    public partial class createEditForm : MaterialForm
    {
        Boolean isAlteracao = false;
        public createEditForm()
        {
            if (isAlteracao)
            {
                this.Text = "Editar projeto";
                // TODO: Setar valores que vierem do banco nos campos
            } else
            {
                this.Text = "Novo projeto";
            }
            
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal700, Primary.Teal800,
                Primary.Teal700, Accent.Red700,
                TextShade.WHITE
            );

        }

        private void statusLinkRepositorio(object sender, EventArgs e)
        {
            linkRepositorio.Visible = !linkRepositorio.Visible;
        }

    }
}
