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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "teste"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.HotTrack, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("dsfsdfdsf");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "sfrt"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveCaptionText, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("12444");
            this.listViewProj = new MaterialSkin.Controls.MaterialListView();
            this.columnProjeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrientador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewProj.Location = new System.Drawing.Point(18, 65);
            this.listViewProj.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProj.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewProj.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewProj.Name = "listViewProj";
            this.listViewProj.OwnerDraw = true;
            this.listViewProj.Size = new System.Drawing.Size(337, 284);
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
            // list_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 601);
            this.Controls.Add(this.listViewProj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "list_project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos públicos";
            this.Load += new System.EventHandler(this.list_project_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewProj;
        private System.Windows.Forms.ColumnHeader columnProjeto;
        private System.Windows.Forms.ColumnHeader columnOrientador;
    }
}