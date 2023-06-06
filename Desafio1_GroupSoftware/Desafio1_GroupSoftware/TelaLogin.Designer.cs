namespace Desafio1_GroupSoftware
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            groupBox_Login = new GroupBox();
            button_Redefinir = new Button();
            checkBox_Showpass = new CheckBox();
            button_Enter = new Button();
            button_Cancel = new Button();
            txt_Password = new TextBox();
            label_Password = new Label();
            txt_User = new TextBox();
            label_User = new Label();
            groupBox_Login.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Login
            // 
            groupBox_Login.Controls.Add(button_Redefinir);
            groupBox_Login.Controls.Add(checkBox_Showpass);
            groupBox_Login.Controls.Add(button_Enter);
            groupBox_Login.Controls.Add(button_Cancel);
            groupBox_Login.Controls.Add(txt_Password);
            groupBox_Login.Controls.Add(label_Password);
            groupBox_Login.Controls.Add(txt_User);
            groupBox_Login.Controls.Add(label_User);
            groupBox_Login.Location = new Point(6, 5);
            groupBox_Login.Margin = new Padding(3, 2, 3, 2);
            groupBox_Login.Name = "groupBox_Login";
            groupBox_Login.Padding = new Padding(3, 2, 3, 2);
            groupBox_Login.Size = new Size(366, 153);
            groupBox_Login.TabIndex = 0;
            groupBox_Login.TabStop = false;
            groupBox_Login.Text = "Login";
            // 
            // button_Redefinir
            // 
            button_Redefinir.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            button_Redefinir.Location = new Point(5, 102);
            button_Redefinir.Name = "button_Redefinir";
            button_Redefinir.Size = new Size(132, 22);
            button_Redefinir.TabIndex = 6;
            button_Redefinir.Text = "ESQUECI MINHA SENHA";
            button_Redefinir.UseVisualStyleBackColor = true;
            button_Redefinir.Click += button_Redefinir_Click;
            // 
            // checkBox_Showpass
            // 
            checkBox_Showpass.AutoSize = true;
            checkBox_Showpass.Location = new Point(260, 101);
            checkBox_Showpass.Margin = new Padding(3, 2, 3, 2);
            checkBox_Showpass.Name = "checkBox_Showpass";
            checkBox_Showpass.Size = new Size(101, 19);
            checkBox_Showpass.TabIndex = 3;
            checkBox_Showpass.Text = "Mostrar senha";
            checkBox_Showpass.UseVisualStyleBackColor = true;
            checkBox_Showpass.CheckedChanged += checkBox_Showpass_CheckedChanged;
            // 
            // button_Enter
            // 
            button_Enter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Enter.Location = new Point(278, 122);
            button_Enter.Margin = new Padding(3, 2, 3, 2);
            button_Enter.Name = "button_Enter";
            button_Enter.Size = new Size(82, 22);
            button_Enter.TabIndex = 3;
            button_Enter.Text = "ENTRAR";
            button_Enter.UseVisualStyleBackColor = true;
            button_Enter.Click += button_Enter_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancel.Location = new Point(191, 122);
            button_Cancel.Margin = new Padding(3, 2, 3, 2);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(82, 22);
            button_Cancel.TabIndex = 5;
            button_Cancel.Text = "CANCELAR";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(5, 74);
            txt_Password.Margin = new Padding(3, 2, 3, 2);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(356, 23);
            txt_Password.TabIndex = 2;
            txt_Password.UseSystemPasswordChar = true;
            txt_Password.TextChanged += txt_Password_TextChanged;
            txt_Password.KeyDown += txt_Password_KeyDown;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(5, 57);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(57, 15);
            label_Password.TabIndex = 2;
            label_Password.Text = "Password";
            label_Password.Click += label_Password_Click;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(5, 34);
            txt_User.Margin = new Padding(3, 2, 3, 2);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(356, 23);
            txt_User.TabIndex = 1;
            txt_User.TextChanged += txt_User_TextChanged;
            txt_User.KeyDown += txt_User_KeyDown;
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(5, 17);
            label_User.Name = "label_User";
            label_User.Size = new Size(30, 15);
            label_User.TabIndex = 0;
            label_User.Text = "User";
            label_User.Click += label_User_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 162);
            Controls.Add(groupBox_Login);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox_Login.ResumeLayout(false);
            groupBox_Login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Login;
        private Label label_User;
        private TextBox txt_User;
        private Label label_Password;
        private TextBox txt_Password;
        private Button button_Enter;
        private Button button_Cancel;
        private CheckBox checkBox_Showpass;
        private Button button_Redefinir;
    }
}