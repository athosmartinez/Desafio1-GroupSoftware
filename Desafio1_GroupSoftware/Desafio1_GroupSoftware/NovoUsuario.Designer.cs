namespace Desafio1_GroupSoftware
{
    partial class NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuario));
            groupBox_NovoUsuario = new GroupBox();
            button_Salvar = new Button();
            button_Cancelar = new Button();
            checkBox_ShowPassword = new CheckBox();
            text_ConfirmeSenha = new TextBox();
            label_ConfSenha = new Label();
            text_CrieSenha = new TextBox();
            label_CrieSenha = new Label();
            text_CrieUser = new TextBox();
            label_CrieUser = new Label();
            groupBox_NovoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_NovoUsuario
            // 
            groupBox_NovoUsuario.Controls.Add(button_Salvar);
            groupBox_NovoUsuario.Controls.Add(button_Cancelar);
            groupBox_NovoUsuario.Controls.Add(checkBox_ShowPassword);
            groupBox_NovoUsuario.Controls.Add(text_ConfirmeSenha);
            groupBox_NovoUsuario.Controls.Add(label_ConfSenha);
            groupBox_NovoUsuario.Controls.Add(text_CrieSenha);
            groupBox_NovoUsuario.Controls.Add(label_CrieSenha);
            groupBox_NovoUsuario.Controls.Add(text_CrieUser);
            groupBox_NovoUsuario.Controls.Add(label_CrieUser);
            groupBox_NovoUsuario.Location = new Point(5, 3);
            groupBox_NovoUsuario.Name = "groupBox_NovoUsuario";
            groupBox_NovoUsuario.Size = new Size(260, 209);
            groupBox_NovoUsuario.TabIndex = 0;
            groupBox_NovoUsuario.TabStop = false;
            groupBox_NovoUsuario.Text = "Novo usuário";
            // 
            // button_Salvar
            // 
            button_Salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Salvar.Location = new Point(180, 179);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(75, 23);
            button_Salvar.TabIndex = 8;
            button_Salvar.Text = "SALVAR";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancelar.Location = new Point(99, 179);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(75, 23);
            button_Cancelar.TabIndex = 7;
            button_Cancelar.Text = "CANCELAR";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(154, 154);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(101, 19);
            checkBox_ShowPassword.TabIndex = 6;
            checkBox_ShowPassword.Text = "Mostrar senha";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            checkBox_ShowPassword.CheckedChanged += checkBox_ShowPassword_CheckedChanged;
            // 
            // text_ConfirmeSenha
            // 
            text_ConfirmeSenha.Location = new Point(6, 125);
            text_ConfirmeSenha.Name = "text_ConfirmeSenha";
            text_ConfirmeSenha.Size = new Size(249, 23);
            text_ConfirmeSenha.TabIndex = 5;
            text_ConfirmeSenha.UseSystemPasswordChar = true;
            text_ConfirmeSenha.TextChanged += text_ConfirmeSenha_TextChanged;
            text_ConfirmeSenha.KeyDown += text_ConfirmeSenha_KeyDown;
            // 
            // label_ConfSenha
            // 
            label_ConfSenha.AutoSize = true;
            label_ConfSenha.Location = new Point(6, 107);
            label_ConfSenha.Name = "label_ConfSenha";
            label_ConfSenha.Size = new Size(103, 15);
            label_ConfSenha.TabIndex = 4;
            label_ConfSenha.Text = "Confirme a senha:";
            // 
            // text_CrieSenha
            // 
            text_CrieSenha.Location = new Point(6, 81);
            text_CrieSenha.Name = "text_CrieSenha";
            text_CrieSenha.Size = new Size(249, 23);
            text_CrieSenha.TabIndex = 3;
            text_CrieSenha.UseSystemPasswordChar = true;
            text_CrieSenha.TextChanged += text_CrieSenha_TextChanged;
            text_CrieSenha.KeyDown += text_CrieSenha_KeyDown;
            // 
            // label_CrieSenha
            // 
            label_CrieSenha.AutoSize = true;
            label_CrieSenha.Location = new Point(6, 63);
            label_CrieSenha.Name = "label_CrieSenha";
            label_CrieSenha.Size = new Size(86, 15);
            label_CrieSenha.TabIndex = 2;
            label_CrieSenha.Text = "Crie sua senha:";
            // 
            // text_CrieUser
            // 
            text_CrieUser.Location = new Point(6, 37);
            text_CrieUser.Name = "text_CrieUser";
            text_CrieUser.Size = new Size(249, 23);
            text_CrieUser.TabIndex = 1;
            text_CrieUser.TextChanged += text_CrieUser_TextChanged;
            text_CrieUser.KeyDown += text_CrieUser_KeyDown;
            // 
            // label_CrieUser
            // 
            label_CrieUser.AutoSize = true;
            label_CrieUser.Location = new Point(6, 19);
            label_CrieUser.Name = "label_CrieUser";
            label_CrieUser.Size = new Size(80, 15);
            label_CrieUser.TabIndex = 0;
            label_CrieUser.Text = "Crie seu user: ";
            // 
            // NovoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 217);
            Controls.Add(groupBox_NovoUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NovoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Usuário";
            KeyDown += NovoUsuario_KeyDown;
            groupBox_NovoUsuario.ResumeLayout(false);
            groupBox_NovoUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_NovoUsuario;
        private Button button_Salvar;
        private Button button_Cancelar;
        private CheckBox checkBox_ShowPassword;
        private TextBox text_ConfirmeSenha;
        private Label label_ConfSenha;
        private TextBox text_CrieSenha;
        private Label label_CrieSenha;
        private TextBox text_CrieUser;
        private Label label_CrieUser;
    }
}