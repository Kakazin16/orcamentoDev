namespace OrcamentoDev.Views
{
    partial class FrmSplash
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
            components = new System.ComponentModel.Container();
            prgCarregando = new ProgressBar();
            lblTituloSplash = new Label();
            lblCarregando = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // prgCarregando
            // 
            prgCarregando.Location = new Point(-1, 428);
            prgCarregando.Name = "prgCarregando";
            prgCarregando.Size = new Size(831, 23);
            prgCarregando.TabIndex = 0;
            // 
            // lblTituloSplash
            // 
            lblTituloSplash.AutoSize = true;
            lblTituloSplash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloSplash.Location = new Point(351, 41);
            lblTituloSplash.Name = "lblTituloSplash";
            lblTituloSplash.Size = new Size(189, 21);
            lblTituloSplash.TabIndex = 1;
            lblTituloSplash.Text = "Sistema de Orçamentos";
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarregando.Location = new Point(351, 115);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(182, 21);
            lblCarregando.TabIndex = 2;
            lblCarregando.Text = "Carregando módulos...";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(828, 450);
            Controls.Add(lblCarregando);
            Controls.Add(lblTituloSplash);
            Controls.Add(prgCarregando);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar prgCarregando;
        private Label lblTituloSplash;
        private Label lblCarregando;
        private System.Windows.Forms.Timer timer1;
    }
}