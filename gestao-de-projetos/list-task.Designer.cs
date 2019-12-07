namespace gestao_de_projetos
{
    partial class list_task
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("A fazer", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Feitas", System.Windows.Forms.HorizontalAlignment.Left);
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView = new MaterialSkin.Controls.MaterialListView();
            this.columnTarefa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstimativa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnResponsavel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(361, 671);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(112, 36);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Adicionar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTarefa,
            this.columnEstimativa,
            this.columnResponsavel});
            this.listView.Depth = 0;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listView.FullRowSelect = true;
            listViewGroup1.Header = "A fazer";
            listViewGroup1.Name = "todoList";
            listViewGroup2.Header = "Feitas";
            listViewGroup2.Name = "doneList";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(24, 80);
            this.listView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView.MouseState = MaterialSkin.MouseState.OUT;
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(449, 350);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnTarefa
            // 
            this.columnTarefa.Text = "";
            this.columnTarefa.Width = 150;
            // 
            // columnEstimativa
            // 
            this.columnEstimativa.Text = "Estimativa";
            this.columnEstimativa.Width = 71;
            // 
            // columnResponsavel
            // 
            this.columnResponsavel.Text = "Responsável";
            this.columnResponsavel.Width = 114;
            // 
            // list_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 740);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.listView);
            this.Name = "list_task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.loadItems);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialListView listView;
        private System.Windows.Forms.ColumnHeader columnTarefa;
        private System.Windows.Forms.ColumnHeader columnEstimativa;
        private System.Windows.Forms.ColumnHeader columnResponsavel;
    }
}