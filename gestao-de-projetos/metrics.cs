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
using System.Globalization;
// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

namespace gestao_de_projetos
{
    public partial class metrics : MaterialForm
    {
        private List<Project> List;
        private List<Task> ListTask;

        string dataInicio;
        string dataFim;
        int IdProjeto;
        double tarefas;
        double qtdTarefas = 0;

        public metrics(int IdProjeto)
        {
            this.IdProjeto = IdProjeto;

            inicializa();
        }

        public void inicializa()
        {
            InitializeComponent();
            design.configMaterialSkin(this);
        }

        public int retornaDiasProjeto()
        {
           
            List = Project.SelectListProj();

            foreach (Project item in List)
            {
                if (item.GetId() == IdProjeto) {

                    dataFim = item.GetDtFim();
                    dataInicio = item.GetDtInicio();
                    
                }

            }

            TimeSpan date = Convert.ToDateTime(dataInicio) - Convert.ToDateTime(dataFim);

            int totalDias = date.Days;

            return totalDias;

        }

        private int retornaDiasTarefa()
        {
            ListTask = Task.List(this.IdProjeto);

            foreach (Task item in ListTask)
            {
                if (item.GetStatus() == "TODO")
                {
                    tarefas = item.GetEstimate();
                    qtdTarefas = qtdTarefas + tarefas;
                }

            }

            double diaTarefas = qtdTarefas / 24;
            int convertDiaTarefas = Convert.ToInt32(diaTarefas);

            return convertDiaTarefas;

        }

        private void metrics_Load(object sender, EventArgs e)
        {
            retornaDiasProjeto();
            retornaDiasTarefa();

            lblTarefas.Text = retornaDiasTarefa().ToString();
            lblDias.Text = retornaDiasProjeto().ToString();

            if(retornaDiasTarefa() > retornaDiasProjeto())
            {
                lblStatusFinal.Text = "Não será possível terminar este projeto";
            }
            else
            {
                lblStatusFinal.Text = "Projeto á tempo";
            }

        }

        private void rbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new list_project();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }

}
