namespace gestao_de_projetos
{
    partial class createEditForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nomeProjeto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.descricaoProjeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicioProjeto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFimProjeto = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.possuiRepositorio = new MaterialSkin.Controls.MaterialCheckBox();
            this.projetoPublico = new MaterialSkin.Controls.MaterialRadioButton();
            this.projetoPrivado = new MaterialSkin.Controls.MaterialRadioButton();
            this.linkRepositorio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nomeOrientador = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeProjeto.BackColor = System.Drawing.Color.White;
            this.nomeProjeto.Depth = 0;
            this.nomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProjeto.Hint = "Nome do projeto";
            this.nomeProjeto.Location = new System.Drawing.Point(35, 117);
            this.nomeProjeto.MaxLength = 32767;
            this.nomeProjeto.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.PasswordChar = '\0';
            this.nomeProjeto.SelectedText = "";
            this.nomeProjeto.SelectionLength = 0;
            this.nomeProjeto.SelectionStart = 0;
            this.nomeProjeto.Size = new System.Drawing.Size(440, 28);
            this.nomeProjeto.TabIndex = 9;
            this.nomeProjeto.TabStop = false;
            this.nomeProjeto.UseSystemPasswordChar = false;
            // 
            // descricaoProjeto
            // 
            this.descricaoProjeto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.descricaoProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descricaoProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoProjeto.ForeColor = System.Drawing.Color.Black;
            this.descricaoProjeto.Location = new System.Drawing.Point(38, 249);
            this.descricaoProjeto.Margin = new System.Windows.Forms.Padding(5);
            this.descricaoProjeto.Multiline = true;
            this.descricaoProjeto.Name = "descricaoProjeto";
            this.descricaoProjeto.Size = new System.Drawing.Size(431, 141);
            this.descricaoProjeto.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(33, 215);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(440, 175);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descrição";
            // 
            // dtInicioProjeto
            // 
            this.dtInicioProjeto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtInicioProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtInicioProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicioProjeto.Location = new System.Drawing.Point(32, 511);
            this.dtInicioProjeto.Mask = "00/00/0000";
            this.dtInicioProjeto.Name = "dtInicioProjeto";
            this.dtInicioProjeto.Size = new System.Drawing.Size(125, 23);
            this.dtInicioProjeto.TabIndex = 14;
            this.dtInicioProjeto.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(32, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 2);
            this.label2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(34, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 2);
            this.label3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(32, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 49);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data de início";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(266, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 2);
            this.label5.TabIndex = 28;
            // 
            // dtFimProjeto
            // 
            this.dtFimProjeto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtFimProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtFimProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFimProjeto.Location = new System.Drawing.Point(266, 513);
            this.dtFimProjeto.Mask = "00/00/0000";
            this.dtFimProjeto.Name = "dtFimProjeto";
            this.dtFimProjeto.Size = new System.Drawing.Size(125, 23);
            this.dtFimProjeto.TabIndex = 15;
            this.dtFimProjeto.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(266, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 49);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data (prevista) término";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 413);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(127, 24);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Este projeto é";
            // 
            // possuiRepositorio
            // 
            this.possuiRepositorio.AutoSize = true;
            this.possuiRepositorio.Depth = 0;
            this.possuiRepositorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.possuiRepositorio.Location = new System.Drawing.Point(28, 557);
            this.possuiRepositorio.Margin = new System.Windows.Forms.Padding(0);
            this.possuiRepositorio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.possuiRepositorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.possuiRepositorio.Name = "possuiRepositorio";
            this.possuiRepositorio.Ripple = true;
            this.possuiRepositorio.Size = new System.Drawing.Size(265, 30);
            this.possuiRepositorio.TabIndex = 16;
            this.possuiRepositorio.Text = "Possui repositório de arquivos";
            this.possuiRepositorio.UseVisualStyleBackColor = true;
            this.possuiRepositorio.CheckedChanged += new System.EventHandler(this.statusLinkRepositorio);
            // 
            // projetoPublico
            // 
            this.projetoPublico.AutoSize = true;
            this.projetoPublico.Depth = 0;
            this.projetoPublico.Font = new System.Drawing.Font("Roboto", 10F);
            this.projetoPublico.Location = new System.Drawing.Point(28, 437);
            this.projetoPublico.Margin = new System.Windows.Forms.Padding(0);
            this.projetoPublico.MouseLocation = new System.Drawing.Point(-1, -1);
            this.projetoPublico.MouseState = MaterialSkin.MouseState.HOVER;
            this.projetoPublico.Name = "projetoPublico";
            this.projetoPublico.Ripple = true;
            this.projetoPublico.Size = new System.Drawing.Size(88, 30);
            this.projetoPublico.TabIndex = 12;
            this.projetoPublico.Text = "Público";
            this.projetoPublico.UseVisualStyleBackColor = true;
            // 
            // projetoPrivado
            // 
            this.projetoPrivado.AutoSize = true;
            this.projetoPrivado.Depth = 0;
            this.projetoPrivado.Font = new System.Drawing.Font("Roboto", 10F);
            this.projetoPrivado.Location = new System.Drawing.Point(155, 437);
            this.projetoPrivado.Margin = new System.Windows.Forms.Padding(0);
            this.projetoPrivado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.projetoPrivado.MouseState = MaterialSkin.MouseState.HOVER;
            this.projetoPrivado.Name = "projetoPrivado";
            this.projetoPrivado.Ripple = true;
            this.projetoPrivado.Size = new System.Drawing.Size(89, 30);
            this.projetoPrivado.TabIndex = 13;
            this.projetoPrivado.TabStop = true;
            this.projetoPrivado.Text = "Privado";
            this.projetoPrivado.UseVisualStyleBackColor = true;
            // 
            // linkRepositorio
            // 
            this.linkRepositorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRepositorio.BackColor = System.Drawing.Color.White;
            this.linkRepositorio.Depth = 0;
            this.linkRepositorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRepositorio.Hint = "Link do repositório";
            this.linkRepositorio.Location = new System.Drawing.Point(34, 607);
            this.linkRepositorio.MaxLength = 32767;
            this.linkRepositorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.linkRepositorio.Name = "linkRepositorio";
            this.linkRepositorio.PasswordChar = '\0';
            this.linkRepositorio.SelectedText = "";
            this.linkRepositorio.SelectionLength = 0;
            this.linkRepositorio.SelectionStart = 0;
            this.linkRepositorio.Size = new System.Drawing.Size(440, 28);
            this.linkRepositorio.TabIndex = 17;
            this.linkRepositorio.UseSystemPasswordChar = false;
            this.linkRepositorio.Visible = false;
            // 
            // nomeOrientador
            // 
            this.nomeOrientador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeOrientador.BackColor = System.Drawing.Color.White;
            this.nomeOrientador.Depth = 0;
            this.nomeOrientador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeOrientador.Hint = "Orientador";
            this.nomeOrientador.Location = new System.Drawing.Point(34, 168);
            this.nomeOrientador.MaxLength = 32767;
            this.nomeOrientador.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomeOrientador.Name = "nomeOrientador";
            this.nomeOrientador.PasswordChar = '\0';
            this.nomeOrientador.SelectedText = "";
            this.nomeOrientador.SelectionLength = 0;
            this.nomeOrientador.SelectionStart = 0;
            this.nomeOrientador.Size = new System.Drawing.Size(440, 28);
            this.nomeOrientador.TabIndex = 10;
            this.nomeOrientador.TabStop = false;
            this.nomeOrientador.UseSystemPasswordChar = false;
            // 
            // createEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(503, 682);
            this.Controls.Add(this.nomeOrientador);
            this.Controls.Add(this.linkRepositorio);
            this.Controls.Add(this.projetoPrivado);
            this.Controls.Add(this.projetoPublico);
            this.Controls.Add(this.possuiRepositorio);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFimProjeto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtInicioProjeto);
            this.Controls.Add(this.descricaoProjeto);
            this.Controls.Add(this.nomeProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "createEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomeProjeto;
        private System.Windows.Forms.TextBox descricaoProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dtInicioProjeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox dtFimProjeto;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox possuiRepositorio;
        private MaterialSkin.Controls.MaterialRadioButton projetoPublico;
        private MaterialSkin.Controls.MaterialRadioButton projetoPrivado;
        private MaterialSkin.Controls.MaterialSingleLineTextField linkRepositorio;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomeOrientador;
    }
}

