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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            button_Cadastramento = new Button();
            button_Lista = new Button();
            button_Sair = new Button();
            SuspendLayout();
            // 
            // button_Cadastramento
            // 
            button_Cadastramento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cadastramento.Location = new Point(12, 12);
            button_Cadastramento.Name = "button_Cadastramento";
            button_Cadastramento.Size = new Size(118, 76);
            button_Cadastramento.TabIndex = 0;
            button_Cadastramento.Text = "Cadastramento";
            button_Cadastramento.UseVisualStyleBackColor = true;
            button_Cadastramento.Click += button_Cadastramento_Click;
            // 
            // button_Lista
            // 
            button_Lista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Lista.Location = new Point(145, 12);
            button_Lista.Name = "button_Lista";
            button_Lista.Size = new Size(118, 76);
            button_Lista.TabIndex = 1;
            button_Lista.Text = "Lista";
            button_Lista.UseVisualStyleBackColor = true;
            button_Lista.Click += button_Lista_Click;
            // 
            // button_Sair
            // 
            button_Sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Sair.Location = new Point(278, 12);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(118, 76);
            button_Sair.TabIndex = 2;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 99);
            Controls.Add(button_Sair);
            Controls.Add(button_Lista);
            Controls.Add(button_Cadastramento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Cadastramento;
        private Button button_Lista;
        private Button button_Sair;
    }
}