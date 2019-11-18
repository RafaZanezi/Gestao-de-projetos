using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

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
            //if (isAlteracao)
            //{
             //   lblContexto.Text = "Editar projeto";
                // TODO: Setar valores que vierem do banco nos campos
            //}
            //else
            //{
            //    lblContexto.Text = "Novo projeto";
            //}

            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void statusLinkRepositorio(object sender, EventArgs e)
        {
            linkRepositorio.Visible = !linkRepositorio.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cancelar(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new list_project();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
