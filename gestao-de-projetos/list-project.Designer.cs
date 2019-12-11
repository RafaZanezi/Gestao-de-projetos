namespace gestao_de_projetos
{
    partial class list_project
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
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "teste"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.HotTrack, null);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("dsfsdfdsf");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "sfrt"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveCaptionText, null);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("12444");
            this.listViewProj = new MaterialSkin.Controls.MaterialListView();
            this.columnProjeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrientador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addProjectButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listViewProj
            // 
            this.listViewProj.BackColor = System.Drawing.SystemColors.Window;
            this.listViewProj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProj.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProjeto,
            this.columnOrientador});
            this.listViewProj.Depth = 0;
            this.listViewProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewProj.FullRowSelect = true;
            this.listViewProj.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewProj.HideSelection = false;
            this.listViewProj.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.listViewProj.Location = new System.Drawing.Point(24, 80);
            this.listViewProj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewProj.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewProj.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewProj.Name = "listViewProj";
            this.listViewProj.OwnerDraw = true;
            this.listViewProj.Size = new System.Drawing.Size(449, 350);
            this.listViewProj.TabIndex = 0;
            this.listViewProj.UseCompatibleStateImageBehavior = false;
            this.listViewProj.View = System.Windows.Forms.View.Details;
            this.listViewProj.Click += new System.EventHandler(this.clickItemProj);
            // 
            // columnProjeto
            // 
            this.columnProjeto.Text = "Projeto";
            this.columnProjeto.Width = 175;
            // 
            // columnOrientador
            // 
            this.columnOrientador.Text = "Orientador";
            this.columnOrientador.Width = 160;
            // 
            // addProjectButton
            // 
            this.addProjectButton.AutoSize = true;
            this.addProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProjectButton.Depth = 0;
            this.addProjectButton.Icon = null;
            this.addProjectButton.Location = new System.Drawing.Point(355, 671);
            this.addProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Primary = true;
            this.addProjectButton.Size = new System.Drawing.Size(112, 36);
            this.addProjectButton.TabIndex = 1;
            this.addProjectButton.Text = "adicionar";
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // list_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 740);
            this.Controls.Add(this.addProjectButton);
            this.Controls.Add(this.listViewProj);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "list_project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos públicos";
            this.Load += new System.EventHandler(this.list_project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewProj;
        private System.Windows.Forms.ColumnHeader columnProjeto;
        private System.Windows.Forms.ColumnHeader columnOrientador;
        private MaterialSkin.Controls.MaterialRaisedButton addProjectButton;
    }
}