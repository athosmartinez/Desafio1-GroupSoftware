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
            groupBox_Login = new GroupBox();
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
            groupBox_Login.Controls.Add(checkBox_Showpass);
            groupBox_Login.Controls.Add(button_Enter);
            groupBox_Login.Controls.Add(button_Cancel);
            groupBox_Login.Controls.Add(txt_Password);
            groupBox_Login.Controls.Add(label_Password);
            groupBox_Login.Controls.Add(txt_User);
            groupBox_Login.Controls.Add(label_User);
            groupBox_Login.Location = new Point(11, 11);
            groupBox_Login.Name = "groupBox_Login";
            groupBox_Login.Size = new Size(418, 204);
            groupBox_Login.TabIndex = 0;
            groupBox_Login.TabStop = false;
            groupBox_Login.Text = "Login";
            // 
            // checkBox_Showpass
            // 
            checkBox_Showpass.AutoSize = true;
            checkBox_Showpass.Location = new Point(289, 135);
            checkBox_Showpass.Name = "checkBox_Showpass";
            checkBox_Showpass.Size = new Size(132, 24);
            checkBox_Showpass.TabIndex = 3;
            checkBox_Showpass.Text = "Show Password";
            checkBox_Showpass.UseVisualStyleBackColor = true;
            checkBox_Showpass.CheckedChanged += checkBox_Showpass_CheckedChanged;
            // 
            // button_Enter
            // 
            button_Enter.Location = new Point(318, 163);
            button_Enter.Name = "button_Enter";
            button_Enter.Size = new Size(94, 29);
            button_Enter.TabIndex = 3;
            button_Enter.Text = "ENTER";
            button_Enter.UseVisualStyleBackColor = true;
            button_Enter.Click += button_Enter_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(218, 163);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 29);
            button_Cancel.TabIndex = 5;
            button_Cancel.Text = "CANCEL";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(6, 99);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(406, 27);
            txt_Password.TabIndex = 2;
            txt_Password.UseSystemPasswordChar = true;
            txt_Password.TextChanged += txt_Password_TextChanged;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(6, 76);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(70, 20);
            label_Password.TabIndex = 2;
            label_Password.Text = "Password";
            label_Password.Click += label_Password_Click;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(6, 45);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(406, 27);
            txt_User.TabIndex = 1;
            txt_User.TextChanged += txt_User_TextChanged;
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(6, 23);
            label_User.Name = "label_User";
            label_User.Size = new Size(38, 20);
            label_User.TabIndex = 0;
            label_User.Text = "User";
            label_User.Click += label_User_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 227);
            Controls.Add(groupBox_Login);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NOVO CADASTRAMENTO";
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
    }
}