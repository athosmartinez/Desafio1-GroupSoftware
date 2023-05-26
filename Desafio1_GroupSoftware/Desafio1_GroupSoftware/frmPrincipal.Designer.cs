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
            button_NovoUsuario = new Button();
            label_UserShow = new Label();
            button_CloseApp = new Button();
            SuspendLayout();
            // 
            // button_Cadastramento
            // 
            button_Cadastramento.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cadastramento.Location = new Point(12, 12);
            button_Cadastramento.Name = "button_Cadastramento";
            button_Cadastramento.Size = new Size(118, 76);
            button_Cadastramento.TabIndex = 0;
            button_Cadastramento.Text = "CADASTRAMENTO";
            button_Cadastramento.UseVisualStyleBackColor = true;
            button_Cadastramento.Click += button_Cadastramento_Click;
            // 
            // button_Lista
            // 
            button_Lista.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Lista.Location = new Point(136, 12);
            button_Lista.Name = "button_Lista";
            button_Lista.Size = new Size(118, 76);
            button_Lista.TabIndex = 1;
            button_Lista.Text = "LISTA";
            button_Lista.UseVisualStyleBackColor = true;
            button_Lista.Click += button_Lista_Click;
            // 
            // button_Sair
            // 
            button_Sair.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Sair.Location = new Point(384, 11);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(118, 76);
            button_Sair.TabIndex = 3;
            button_Sair.Text = "DESLOGAR";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // button_NovoUsuario
            // 
            button_NovoUsuario.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_NovoUsuario.Location = new Point(260, 12);
            button_NovoUsuario.Name = "button_NovoUsuario";
            button_NovoUsuario.Size = new Size(118, 75);
            button_NovoUsuario.TabIndex = 2;
            button_NovoUsuario.Text = "NOVO USUÁRIO";
            button_NovoUsuario.UseVisualStyleBackColor = true;
            button_NovoUsuario.Click += button_NovoUsuario_Click;
            // 
            // label_UserShow
            // 
            label_UserShow.AutoSize = true;
            label_UserShow.Location = new Point(12, 91);
            label_UserShow.Name = "label_UserShow";
            label_UserShow.Size = new Size(203, 15);
            label_UserShow.TabIndex = 4;
            label_UserShow.Text = "Ideia de mostrar o usuario conectado";
            label_UserShow.Click += label_UserShow_Click;
            // 
            // button_CloseApp
            // 
            button_CloseApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_CloseApp.Location = new Point(427, 87);
            button_CloseApp.Name = "button_CloseApp";
            button_CloseApp.Size = new Size(75, 23);
            button_CloseApp.TabIndex = 4;
            button_CloseApp.Text = "SAIR";
            button_CloseApp.UseVisualStyleBackColor = true;
            button_CloseApp.Click += button_CloseApp_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 112);
            Controls.Add(button_CloseApp);
            Controls.Add(label_UserShow);
            Controls.Add(button_NovoUsuario);
            Controls.Add(button_Sair);
            Controls.Add(button_Lista);
            Controls.Add(button_Cadastramento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += frmPrincipal_Load;
            Shown += frmPrincipal_Shown;
            RegionChanged += frmPrincipal_RegionChanged;
            VisibleChanged += frmPrincipal_VisibleChanged;
            MouseDown += frmPrincipal_MouseDown;
            MouseEnter += frmPrincipal_MouseEnter;
            MouseLeave += frmPrincipal_MouseLeave;
            MouseHover += frmPrincipal_MouseHover;
            MouseMove += frmPrincipal_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Cadastramento;
        private Button button_Lista;
        private Button button_Sair;
        private Button button_NovoUsuario;
        private Label label_UserShow;
        private Button button_CloseApp;
    }
}