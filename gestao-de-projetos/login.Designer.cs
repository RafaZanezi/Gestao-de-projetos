namespace gestao_de_projetos
{
    partial class login
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
            this.lineUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lineSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.fbtnRegistro = new MaterialSkin.Controls.MaterialFlatButton();
            this.fbtnEsqueceuSenha = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lineUsuario
            // 
            this.lineUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineUsuario.BackColor = System.Drawing.Color.White;
            this.lineUsuario.Depth = 0;
            this.lineUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineUsuario.Hint = "Usuário";
            this.lineUsuario.Location = new System.Drawing.Point(87, 172);
            this.lineUsuario.MaxLength = 32767;
            this.lineUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lineUsuario.Name = "lineUsuario";
            this.lineUsuario.PasswordChar = '\0';
            this.lineUsuario.SelectedText = "";
            this.lineUsuario.SelectionLength = 0;
            this.lineUsuario.SelectionStart = 0;
            this.lineUsuario.Size = new System.Drawing.Size(193, 23);
            this.lineUsuario.TabIndex = 17;
            this.lineUsuario.TabStop = false;
            this.lineUsuario.UseSystemPasswordChar = false;
            // 
            // lineSenha
            // 
            this.lineSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSenha.BackColor = System.Drawing.Color.White;
            this.lineSenha.Depth = 0;
            this.lineSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineSenha.Hint = "Senha";
            this.lineSenha.Location = new System.Drawing.Point(87, 227);
            this.lineSenha.MaxLength = 32767;
            this.lineSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lineSenha.Name = "lineSenha";
            this.lineSenha.PasswordChar = '\0';
            this.lineSenha.SelectedText = "";
            this.lineSenha.SelectionLength = 0;
            this.lineSenha.SelectionStart = 0;
            this.lineSenha.Size = new System.Drawing.Size(193, 23);
            this.lineSenha.TabIndex = 18;
            this.lineSenha.TabStop = false;
            this.lineSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(149, 283);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(61, 36);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(54, 347);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(260, 2);
            this.materialDivider1.TabIndex = 22;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // fbtnRegistro
            // 
            this.fbtnRegistro.AutoSize = true;
            this.fbtnRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fbtnRegistro.Depth = 0;
            this.fbtnRegistro.Icon = null;
            this.fbtnRegistro.Location = new System.Drawing.Point(118, 421);
            this.fbtnRegistro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fbtnRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.fbtnRegistro.Name = "fbtnRegistro";
            this.fbtnRegistro.Primary = false;
            this.fbtnRegistro.Size = new System.Drawing.Size(114, 36);
            this.fbtnRegistro.TabIndex = 23;
            this.fbtnRegistro.Text = "Registrar-se";
            this.fbtnRegistro.UseVisualStyleBackColor = true;
            // 
            // fbtnEsqueceuSenha
            // 
            this.fbtnEsqueceuSenha.AutoSize = true;
            this.fbtnEsqueceuSenha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fbtnEsqueceuSenha.Depth = 0;
            this.fbtnEsqueceuSenha.Icon = null;
            this.fbtnEsqueceuSenha.Location = new System.Drawing.Point(98, 373);
            this.fbtnEsqueceuSenha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fbtnEsqueceuSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.fbtnEsqueceuSenha.Name = "fbtnEsqueceuSenha";
            this.fbtnEsqueceuSenha.Primary = false;
            this.fbtnEsqueceuSenha.Size = new System.Drawing.Size(156, 36);
            this.fbtnEsqueceuSenha.TabIndex = 24;
            this.fbtnEsqueceuSenha.Text = "Esqueceu a senha?";
            this.fbtnEsqueceuSenha.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 601);
            this.Controls.Add(this.fbtnEsqueceuSenha);
            this.Controls.Add(this.fbtnRegistro);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lineSenha);
            this.Controls.Add(this.lineUsuario);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField lineUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField lineSenha;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton fbtnRegistro;
        private MaterialSkin.Controls.MaterialFlatButton fbtnEsqueceuSenha;
    }
}