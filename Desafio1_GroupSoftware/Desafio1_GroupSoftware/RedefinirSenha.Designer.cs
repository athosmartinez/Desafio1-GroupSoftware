namespace Desafio1_GroupSoftware
{
    partial class RedefinirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha));
            groupBox1 = new GroupBox();
            checkBox_ShowPassword = new CheckBox();
            text_User = new TextBox();
            label_User = new Label();
            button_Voltar = new Button();
            button_Confirma = new Button();
            text_ConfirmeSenha = new TextBox();
            label_ConfirmeNova = new Label();
            text_NovaSenha = new TextBox();
            label_NovaSenha = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_ShowPassword);
            groupBox1.Controls.Add(text_User);
            groupBox1.Controls.Add(label_User);
            groupBox1.Controls.Add(button_Voltar);
            groupBox1.Controls.Add(button_Confirma);
            groupBox1.Controls.Add(text_ConfirmeSenha);
            groupBox1.Controls.Add(label_ConfirmeNova);
            groupBox1.Controls.Add(text_NovaSenha);
            groupBox1.Controls.Add(label_NovaSenha);
            groupBox1.Location = new Point(7, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Redefinir senha";
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(159, 152);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(101, 19);
            checkBox_ShowPassword.TabIndex = 3;
            checkBox_ShowPassword.Text = "Mostrar senha";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            checkBox_ShowPassword.CheckedChanged += checkBox_ShowPassword_CheckedChanged;
            // 
            // text_User
            // 
            text_User.Location = new Point(6, 34);
            text_User.Name = "text_User";
            text_User.Size = new Size(252, 23);
            text_User.TabIndex = 0;
            text_User.TextChanged += text_User_TextChanged;
            text_User.KeyDown += text_User_KeyDown;
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(6, 16);
            label_User.Name = "label_User";
            label_User.Size = new Size(35, 15);
            label_User.TabIndex = 6;
            label_User.Text = "Code";
            // 
            // button_Voltar
            // 
            button_Voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Voltar.Location = new Point(104, 177);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 5;
            button_Voltar.Text = "VOLTAR";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // button_Confirma
            // 
            button_Confirma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Confirma.Location = new Point(185, 177);
            button_Confirma.Name = "button_Confirma";
            button_Confirma.Size = new Size(75, 23);
            button_Confirma.TabIndex = 4;
            button_Confirma.Text = "ALTERAR";
            button_Confirma.UseVisualStyleBackColor = true;
            button_Confirma.Click += button_Confirma_Click;
            // 
            // text_ConfirmeSenha
            // 
            text_ConfirmeSenha.Location = new Point(6, 122);
            text_ConfirmeSenha.Name = "text_ConfirmeSenha";
            text_ConfirmeSenha.Size = new Size(252, 23);
            text_ConfirmeSenha.TabIndex = 2;
            text_ConfirmeSenha.UseSystemPasswordChar = true;
            text_ConfirmeSenha.TextChanged += text_ConfirmeSenha_TextChanged;
            text_ConfirmeSenha.KeyDown += text_ConfirmeSenha_KeyDown;
            // 
            // label_ConfirmeNova
            // 
            label_ConfirmeNova.AutoSize = true;
            label_ConfirmeNova.Location = new Point(6, 104);
            label_ConfirmeNova.Name = "label_ConfirmeNova";
            label_ConfirmeNova.Size = new Size(100, 15);
            label_ConfirmeNova.TabIndex = 2;
            label_ConfirmeNova.Text = "Confirme a senha";
            // 
            // text_NovaSenha
            // 
            text_NovaSenha.Location = new Point(6, 78);
            text_NovaSenha.Name = "text_NovaSenha";
            text_NovaSenha.Size = new Size(252, 23);
            text_NovaSenha.TabIndex = 1;
            text_NovaSenha.UseSystemPasswordChar = true;
            text_NovaSenha.TextChanged += text_NovaSenha_TextChanged;
            text_NovaSenha.KeyDown += text_NovaSenha_KeyDown;
            // 
            // label_NovaSenha
            // 
            label_NovaSenha.AutoSize = true;
            label_NovaSenha.Location = new Point(6, 60);
            label_NovaSenha.Name = "label_NovaSenha";
            label_NovaSenha.Size = new Size(69, 15);
            label_NovaSenha.TabIndex = 0;
            label_NovaSenha.Text = "Nova senha";
            // 
            // RedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 215);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RedefinirSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Redefinir Senha";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_Confirma;
        private TextBox text_ConfirmeSenha;
        private Label label_ConfirmeNova;
        private TextBox text_NovaSenha;
        private Label label_NovaSenha;
        private Button button_Voltar;
        private TextBox text_User;
        private Label label_User;
        private CheckBox checkBox_ShowPassword;
    }
}