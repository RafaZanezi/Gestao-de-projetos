namespace gestao_de_projetos
{
    partial class metrics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQtdDias = new MaterialSkin.Controls.MaterialLabel();
            this.lblDias = new MaterialSkin.Controls.MaterialLabel();
            this.lblQtdTarefas = new MaterialSkin.Controls.MaterialLabel();
            this.lblTarefas = new MaterialSkin.Controls.MaterialLabel();
            this.lblStatusFinal = new MaterialSkin.Controls.MaterialLabel();
            this.rbtnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblQtdDias
            // 
            this.lblQtdDias.AutoSize = true;
            this.lblQtdDias.Depth = 0;
            this.lblQtdDias.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblQtdDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQtdDias.Location = new System.Drawing.Point(92, 173);
            this.lblQtdDias.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQtdDias.Name = "lblQtdDias";
            this.lblQtdDias.Size = new System.Drawing.Size(123, 19);
            this.lblQtdDias.TabIndex = 0;
            this.lblQtdDias.Text = "Dias disponivéis:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Depth = 0;
            this.lblDias.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDias.Location = new System.Drawing.Point(246, 173);
            this.lblDias.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(108, 19);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "materialLabel2";
            // 
            // lblQtdTarefas
            // 
            this.lblQtdTarefas.AutoSize = true;
            this.lblQtdTarefas.Depth = 0;
            this.lblQtdTarefas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblQtdTarefas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQtdTarefas.Location = new System.Drawing.Point(78, 213);
            this.lblQtdTarefas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQtdTarefas.Name = "lblQtdTarefas";
            this.lblQtdTarefas.Size = new System.Drawing.Size(151, 19);
            this.lblQtdTarefas.TabIndex = 2;
            this.lblQtdTarefas.Text = "Dias para as Tarefas:";
            // 
            // lblTarefas
            // 
            this.lblTarefas.AutoSize = true;
            this.lblTarefas.Depth = 0;
            this.lblTarefas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTarefas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTarefas.Location = new System.Drawing.Point(246, 213);
            this.lblTarefas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTarefas.Name = "lblTarefas";
            this.lblTarefas.Size = new System.Drawing.Size(108, 19);
            this.lblTarefas.TabIndex = 3;
            this.lblTarefas.Text = "materialLabel4";
            // 
            // lblStatusFinal
            // 
            this.lblStatusFinal.AutoSize = true;
            this.lblStatusFinal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatusFinal.Depth = 0;
            this.lblStatusFinal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusFinal.Location = new System.Drawing.Point(130, 281);
            this.lblStatusFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatusFinal.Name = "lblStatusFinal";
            this.lblStatusFinal.Size = new System.Drawing.Size(146, 22);
            this.lblStatusFinal.TabIndex = 4;
            this.lblStatusFinal.Text = "materialLabel5";
            // 
            // rbtnVoltar
            // 
            this.rbtnVoltar.AutoSize = true;
            this.rbtnVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnVoltar.Depth = 0;
            this.rbtnVoltar.Icon = null;
            this.rbtnVoltar.Location = new System.Drawing.Point(281, 553);
            this.rbtnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnVoltar.Name = "rbtnVoltar";
            this.rbtnVoltar.Primary = true;
            this.rbtnVoltar.Size = new System.Drawing.Size(73, 36);
            this.rbtnVoltar.TabIndex = 5;
            this.rbtnVoltar.Text = "Voltar";
            this.rbtnVoltar.UseVisualStyleBackColor = true;
            this.rbtnVoltar.Click += new System.EventHandler(this.rbtnVoltar_Click);
            // 
            // metrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 601);
            this.Controls.Add(this.rbtnVoltar);
            this.Controls.Add(this.lblStatusFinal);
            this.Controls.Add(this.lblTarefas);
            this.Controls.Add(this.lblQtdTarefas);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblQtdDias);
            this.Name = "metrics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métrica";
            this.Load += new System.EventHandler(this.metrics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblQtdDias;
        private MaterialSkin.Controls.MaterialLabel lblDias;
        private MaterialSkin.Controls.MaterialLabel lblQtdTarefas;
        private MaterialSkin.Controls.MaterialLabel lblTarefas;
        private MaterialSkin.Controls.MaterialLabel lblStatusFinal;
        private MaterialSkin.Controls.MaterialRaisedButton rbtnVoltar;
    }
}