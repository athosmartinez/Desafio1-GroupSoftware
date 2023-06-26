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
            txt_Email = new TextBox();
            label1 = new Label();
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
            groupBox_NovoUsuario.Controls.Add(txt_Email);
            groupBox_NovoUsuario.Controls.Add(label1);
            groupBox_NovoUsuario.Controls.Add(button_Salvar);
            groupBox_NovoUsuario.Controls.Add(button_Cancelar);
            groupBox_NovoUsuario.Controls.Add(checkBox_ShowPassword);
            groupBox_NovoUsuario.Controls.Add(text_ConfirmeSenha);
            groupBox_NovoUsuario.Controls.Add(label_ConfSenha);
            groupBox_NovoUsuario.Controls.Add(text_CrieSenha);
            groupBox_NovoUsuario.Controls.Add(label_CrieSenha);
            groupBox_NovoUsuario.Controls.Add(text_CrieUser);
            groupBox_NovoUsuario.Controls.Add(label_CrieUser);
            groupBox_NovoUsuario.Location = new Point(7, 5);
            groupBox_NovoUsuario.Margin = new Padding(4, 5, 4, 5);
            groupBox_NovoUsuario.Name = "groupBox_NovoUsuario";
            groupBox_NovoUsuario.Padding = new Padding(4, 5, 4, 5);
            groupBox_NovoUsuario.Size = new Size(371, 414);
            groupBox_NovoUsuario.TabIndex = 0;
            groupBox_NovoUsuario.TabStop = false;
            groupBox_NovoUsuario.Text = "Novo usuário";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(7, 135);
            txt_Email.Margin = new Padding(4, 5, 4, 5);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(353, 31);
            txt_Email.TabIndex = 2;
            txt_Email.TextChanged += txt_Email_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 9;
            label1.Text = "E-mail:";
            // 
            // button_Salvar
            // 
            button_Salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Salvar.Location = new Point(244, 365);
            button_Salvar.Margin = new Padding(4, 5, 4, 5);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(116, 38);
            button_Salvar.TabIndex = 6;
            button_Salvar.Text = "SALVAR";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancelar.Location = new Point(123, 365);
            button_Cancelar.Margin = new Padding(4, 5, 4, 5);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(116, 38);
            button_Cancelar.TabIndex = 7;
            button_Cancelar.Text = "CANCELAR";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(215, 326);
            checkBox_ShowPassword.Margin = new Padding(4, 5, 4, 5);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(151, 29);
            checkBox_ShowPassword.TabIndex = 5;
            checkBox_ShowPassword.Text = "Mostrar senha";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            checkBox_ShowPassword.CheckedChanged += checkBox_ShowPassword_CheckedChanged;
            // 
            // text_ConfirmeSenha
            // 
            text_ConfirmeSenha.Location = new Point(7, 285);
            text_ConfirmeSenha.Margin = new Padding(4, 5, 4, 5);
            text_ConfirmeSenha.Name = "text_ConfirmeSenha";
            text_ConfirmeSenha.Size = new Size(354, 31);
            text_ConfirmeSenha.TabIndex = 4;
            text_ConfirmeSenha.UseSystemPasswordChar = true;
            text_ConfirmeSenha.TextChanged += text_ConfirmeSenha_TextChanged;
            text_ConfirmeSenha.KeyDown += text_ConfirmeSenha_KeyDown;
            // 
            // label_ConfSenha
            // 
            label_ConfSenha.AutoSize = true;
            label_ConfSenha.Location = new Point(7, 255);
            label_ConfSenha.Margin = new Padding(4, 0, 4, 0);
            label_ConfSenha.Name = "label_ConfSenha";
            label_ConfSenha.Size = new Size(154, 25);
            label_ConfSenha.TabIndex = 4;
            label_ConfSenha.Text = "Confirme a senha:";
            // 
            // text_CrieSenha
            // 
            text_CrieSenha.Location = new Point(7, 212);
            text_CrieSenha.Margin = new Padding(4, 5, 4, 5);
            text_CrieSenha.Name = "text_CrieSenha";
            text_CrieSenha.Size = new Size(354, 31);
            text_CrieSenha.TabIndex = 3;
            text_CrieSenha.UseSystemPasswordChar = true;
            text_CrieSenha.TextChanged += text_CrieSenha_TextChanged;
            text_CrieSenha.KeyDown += text_CrieSenha_KeyDown;
            // 
            // label_CrieSenha
            // 
            label_CrieSenha.AutoSize = true;
            label_CrieSenha.Location = new Point(10, 178);
            label_CrieSenha.Margin = new Padding(4, 0, 4, 0);
            label_CrieSenha.Name = "label_CrieSenha";
            label_CrieSenha.Size = new Size(129, 25);
            label_CrieSenha.TabIndex = 2;
            label_CrieSenha.Text = "Crie sua senha:";
            // 
            // text_CrieUser
            // 
            text_CrieUser.Location = new Point(9, 62);
            text_CrieUser.Margin = new Padding(4, 5, 4, 5);
            text_CrieUser.Name = "text_CrieUser";
            text_CrieUser.Size = new Size(354, 31);
            text_CrieUser.TabIndex = 1;
            text_CrieUser.TextChanged += text_CrieUser_TextChanged;
            text_CrieUser.KeyDown += text_CrieUser_KeyDown;
            // 
            // label_CrieUser
            // 
            label_CrieUser.AutoSize = true;
            label_CrieUser.Location = new Point(9, 32);
            label_CrieUser.Margin = new Padding(4, 0, 4, 0);
            label_CrieUser.Name = "label_CrieUser";
            label_CrieUser.Size = new Size(121, 25);
            label_CrieUser.TabIndex = 0;
            label_CrieUser.Text = "Crie seu user: ";
            // 
            // NovoUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 427);
            Controls.Add(groupBox_NovoUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox txt_Email;
        private Label label1;
    }
}