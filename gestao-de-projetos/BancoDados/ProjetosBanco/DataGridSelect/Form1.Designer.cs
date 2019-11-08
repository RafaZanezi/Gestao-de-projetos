namespace DataGridSelect
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvClientes = new System.Windows.Forms.DataGridView();
            this.gbxSelect = new System.Windows.Forms.GroupBox();
            this.cbxCep = new System.Windows.Forms.CheckBox();
            this.cbxCpf = new System.Windows.Forms.CheckBox();
            this.cbxEndereco = new System.Windows.Forms.CheckBox();
            this.cbxNome = new System.Windows.Forms.CheckBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCmdSql = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            this.gbxSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvClientes
            // 
            this.gvClientes.AllowUserToAddRows = false;
            this.gvClientes.AllowUserToDeleteRows = false;
            this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientes.Location = new System.Drawing.Point(12, 142);
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.ReadOnly = true;
            this.gvClientes.Size = new System.Drawing.Size(562, 242);
            this.gvClientes.TabIndex = 3;
            // 
            // gbxSelect
            // 
            this.gbxSelect.Controls.Add(this.cbxCep);
            this.gbxSelect.Controls.Add(this.cbxCpf);
            this.gbxSelect.Controls.Add(this.cbxEndereco);
            this.gbxSelect.Controls.Add(this.cbxNome);
            this.gbxSelect.Location = new System.Drawing.Point(12, 12);
            this.gbxSelect.Name = "gbxSelect";
            this.gbxSelect.Size = new System.Drawing.Size(234, 73);
            this.gbxSelect.TabIndex = 4;
            this.gbxSelect.TabStop = false;
            this.gbxSelect.Text = "Campos da Tabela";
            // 
            // cbxCep
            // 
            this.cbxCep.AutoSize = true;
            this.cbxCep.Location = new System.Drawing.Point(138, 43);
            this.cbxCep.Name = "cbxCep";
            this.cbxCep.Size = new System.Drawing.Size(47, 17);
            this.cbxCep.TabIndex = 3;
            this.cbxCep.Text = "CEP";
            this.cbxCep.UseVisualStyleBackColor = true;
            // 
            // cbxCpf
            // 
            this.cbxCpf.AutoSize = true;
            this.cbxCpf.Location = new System.Drawing.Point(6, 43);
            this.cbxCpf.Name = "cbxCpf";
            this.cbxCpf.Size = new System.Drawing.Size(46, 17);
            this.cbxCpf.TabIndex = 2;
            this.cbxCpf.Text = "CPF";
            this.cbxCpf.UseVisualStyleBackColor = true;
            // 
            // cbxEndereco
            // 
            this.cbxEndereco.AutoSize = true;
            this.cbxEndereco.Location = new System.Drawing.Point(138, 20);
            this.cbxEndereco.Name = "cbxEndereco";
            this.cbxEndereco.Size = new System.Drawing.Size(72, 17);
            this.cbxEndereco.TabIndex = 1;
            this.cbxEndereco.Text = "Endereço";
            this.cbxEndereco.UseVisualStyleBackColor = true;
            // 
            // cbxNome
            // 
            this.cbxNome.AutoSize = true;
            this.cbxNome.Location = new System.Drawing.Point(6, 19);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(54, 17);
            this.cbxNome.TabIndex = 0;
            this.cbxNome.Text = "Nome";
            this.cbxNome.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(252, 17);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 68);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SQL:";
            // 
            // lblCmdSql
            // 
            this.lblCmdSql.AutoSize = true;
            this.lblCmdSql.Location = new System.Drawing.Point(70, 110);
            this.lblCmdSql.Name = "lblCmdSql";
            this.lblCmdSql.Size = new System.Drawing.Size(67, 13);
            this.lblCmdSql.TabIndex = 7;
            this.lblCmdSql.Text = "comando sql";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 398);
            this.Controls.Add(this.lblCmdSql);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.gbxSelect);
            this.Controls.Add(this.gvClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            this.gbxSelect.ResumeLayout(false);
            this.gbxSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvClientes;
        private System.Windows.Forms.GroupBox gbxSelect;
        private System.Windows.Forms.CheckBox cbxCep;
        private System.Windows.Forms.CheckBox cbxCpf;
        private System.Windows.Forms.CheckBox cbxEndereco;
        private System.Windows.Forms.CheckBox cbxNome;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCmdSql;
    }
}

