namespace Desafio1_GroupSoftware
{
    partial class frmPrincipal
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
            button_cadastramento = new Button();
            button_lista = new Button();
            button_sair = new Button();
            SuspendLayout();
            // 
            // button_cadastramento
            // 
            button_cadastramento.Location = new Point(12, 12);
            button_cadastramento.Name = "button_cadastramento";
            button_cadastramento.Size = new Size(118, 76);
            button_cadastramento.TabIndex = 0;
            button_cadastramento.Text = "Cadastramento";
            button_cadastramento.UseVisualStyleBackColor = true;
            button_cadastramento.Click += button_cadastramento_Click;
            // 
            // button_lista
            // 
            button_lista.Location = new Point(145, 12);
            button_lista.Name = "button_lista";
            button_lista.Size = new Size(118, 76);
            button_lista.TabIndex = 1;
            button_lista.Text = "Lista";
            button_lista.UseVisualStyleBackColor = true;
            button_lista.Click += button_lista_Click;
            // 
            // button_sair
            // 
            button_sair.Location = new Point(278, 12);
            button_sair.Name = "button_sair";
            button_sair.Size = new Size(118, 76);
            button_sair.TabIndex = 2;
            button_sair.Text = "Sair";
            button_sair.UseVisualStyleBackColor = true;
            button_sair.Click += button_sair_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 99);
            Controls.Add(button_sair);
            Controls.Add(button_lista);
            Controls.Add(button_cadastramento);
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button button_cadastramento;
        private Button button_lista;
        private Button button_sair;
    }
}