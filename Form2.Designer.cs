namespace Funcionario
{
    partial class Form2
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
            lblBanco = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblBanco
            // 
            lblBanco.AutoSize = true;
            lblBanco.Location = new Point(30, 59);
            lblBanco.Name = "lblBanco";
            lblBanco.Size = new Size(0, 20);
            lblBanco.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(677, 394);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(106, 32);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(lblBanco);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBanco;
        private Button btnVoltar;
    }
}