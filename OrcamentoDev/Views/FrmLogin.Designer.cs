namespace OrcamentoDev.Views
{
    partial class FrmLogin
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
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Blue;
            lblTitulo.Location = new Point(295, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(223, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Acesso ao Sistema";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(98, 135);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.Location = new Point(98, 193);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(56, 21);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(204, 134);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(443, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(204, 192);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(443, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(317, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
    }
}