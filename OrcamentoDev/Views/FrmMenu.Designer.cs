namespace OrcamentoDev.Views
{
    partial class FrmMenu
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
            lblBoasVinda = new Label();
            btnRelatorio = new Button();
            btnSair = new Button();
            btnNovoOrçamento = new Button();
            SuspendLayout();
            // 
            // lblBoasVinda
            // 
            lblBoasVinda.AutoSize = true;
            lblBoasVinda.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVinda.ForeColor = Color.Black;
            lblBoasVinda.Location = new Point(213, 57);
            lblBoasVinda.Name = "lblBoasVinda";
            lblBoasVinda.Size = new Size(389, 30);
            lblBoasVinda.TabIndex = 0;
            lblBoasVinda.Text = "Bem-Vindo ao Sistema de Orçamentos";
            // 
            // btnRelatorio
            // 
            btnRelatorio.Font = new Font("Segoe UI", 12F);
            btnRelatorio.Location = new Point(580, 257);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(162, 56);
            btnRelatorio.TabIndex = 1;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.Location = new Point(310, 257);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(162, 56);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnNovoOrçamento
            // 
            btnNovoOrçamento.Font = new Font("Segoe UI", 12F);
            btnNovoOrçamento.Location = new Point(57, 257);
            btnNovoOrçamento.Name = "btnNovoOrçamento";
            btnNovoOrçamento.Size = new Size(162, 56);
            btnNovoOrçamento.TabIndex = 3;
            btnNovoOrçamento.Text = "Novo Orçamento";
            btnNovoOrçamento.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNovoOrçamento);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(lblBoasVinda);
            ForeColor = SystemColors.ControlText;
            Name = "FrmMenu";
            Text = "Menu Principal - Orçamentos";
            Load += FrmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoasVinda;
        private Button btnRelatorio;
        private Button btnSair;
        private Button btnNovoOrçamento;
    }
}