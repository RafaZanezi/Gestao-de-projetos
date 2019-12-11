namespace gestao_de_projetos
{
    partial class task_create_edit
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
            this.Nome_tarefa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Tempo_tarefa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_criar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Cancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // Nome_tarefa
            // 
            this.Nome_tarefa.Depth = 0;
            this.Nome_tarefa.Hint = "Nome da tarefa";
            this.Nome_tarefa.Location = new System.Drawing.Point(64, 136);
            this.Nome_tarefa.MaxLength = 32767;
            this.Nome_tarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nome_tarefa.Name = "Nome_tarefa";
            this.Nome_tarefa.PasswordChar = '\0';
            this.Nome_tarefa.SelectedText = "";
            this.Nome_tarefa.SelectionLength = 0;
            this.Nome_tarefa.SelectionStart = 0;
            this.Nome_tarefa.Size = new System.Drawing.Size(217, 23);
            this.Nome_tarefa.TabIndex = 0;
            this.Nome_tarefa.TabStop = false;
            this.Nome_tarefa.UseSystemPasswordChar = false;
            // 
            // Tempo_tarefa
            // 
            this.Tempo_tarefa.Depth = 0;
            this.Tempo_tarefa.Hint = "Tempo estimado";
            this.Tempo_tarefa.Location = new System.Drawing.Point(64, 211);
            this.Tempo_tarefa.MaxLength = 32767;
            this.Tempo_tarefa.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tempo_tarefa.Name = "Tempo_tarefa";
            this.Tempo_tarefa.PasswordChar = '\0';
            this.Tempo_tarefa.SelectedText = "";
            this.Tempo_tarefa.SelectionLength = 0;
            this.Tempo_tarefa.SelectionStart = 0;
            this.Tempo_tarefa.Size = new System.Drawing.Size(217, 23);
            this.Tempo_tarefa.TabIndex = 1;
            this.Tempo_tarefa.TabStop = false;
            this.Tempo_tarefa.UseSystemPasswordChar = false;
            // 
            // btn_criar
            // 
            this.btn_criar.AutoSize = true;
            this.btn_criar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_criar.Depth = 0;
            this.btn_criar.Icon = null;
            this.btn_criar.Location = new System.Drawing.Point(167, 348);
            this.btn_criar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Primary = true;
            this.btn_criar.Size = new System.Drawing.Size(114, 36);
            this.btn_criar.TabIndex = 2;
            this.btn_criar.Text = "Criar Tarefa";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.AutoSize = true;
            this.Cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancelar.Depth = 0;
            this.Cancelar.Icon = null;
            this.Cancelar.Location = new System.Drawing.Point(64, 348);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Primary = false;
            this.Cancelar.Size = new System.Drawing.Size(91, 36);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // task_create_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.Tempo_tarefa);
            this.Controls.Add(this.Nome_tarefa);
            this.Name = "task_create_edit";
            this.Text = "Criar Tarefa";
            this.Load += new System.EventHandler(this.task_create_edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Nome_tarefa;
        private MaterialSkin.Controls.MaterialSingleLineTextField Tempo_tarefa;
        private MaterialSkin.Controls.MaterialRaisedButton btn_criar;
        private MaterialSkin.Controls.MaterialFlatButton Cancelar;
    }
}