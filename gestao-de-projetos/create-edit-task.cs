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
    public partial class task_create_edit : MaterialForm
    {
        private string strConexao = @"Host=localhost;Username=postgres;Password=12345;Database=bd_gestorprojetos";

        Project pj = new Project();
        Task tk = new Task();

        int id = 0;
        public task_create_edit()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (Nome_tarefa.Text == null || Tempo_tarefa.Text == null)
            {
                MessageBox.Show("Campos obrigatórios não foram preenchidos", "Erro no formulário", MessageBoxButtons.OK);
            }






            id = pj.GetId();



            tk.SetId(id);
            tk.SetNome(Nome_tarefa.ToString());
            tk.SetEstimate(Convert.ToDouble(Tempo_tarefa));

            
            
        }
    }
}
