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
            groupBox1 = new GroupBox();
            checkBox_showpass = new CheckBox();
            button_enter = new Button();
            button_cancel = new Button();
            txt_password = new TextBox();
            label_Password = new Label();
            txt_user = new TextBox();
            label_User = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_showpass);
            groupBox1.Controls.Add(button_enter);
            groupBox1.Controls.Add(button_cancel);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label_Password);
            groupBox1.Controls.Add(txt_user);
            groupBox1.Controls.Add(label_User);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // checkBox_showpass
            // 
            checkBox_showpass.AutoSize = true;
            checkBox_showpass.Location = new Point(289, 135);
            checkBox_showpass.Name = "checkBox_showpass";
            checkBox_showpass.Size = new Size(132, 24);
            checkBox_showpass.TabIndex = 3;
            checkBox_showpass.Text = "Show Password";
            checkBox_showpass.UseVisualStyleBackColor = true;
            checkBox_showpass.CheckedChanged += checkBox_Showpass_CheckedChanged;
            // 
            // button_enter
            // 
            button_enter.Location = new Point(318, 163);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(94, 29);
            button_enter.TabIndex = 3;
            button_enter.Text = "ENTER";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_Enter_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(218, 163);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 5;
            button_cancel.Text = "CANCEL";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_Cancel_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(6, 99);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(406, 27);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            txt_password.TextChanged += txt_Password_TextChanged;
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
            // txt_user
            // 
            txt_user.Location = new Point(6, 45);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(406, 27);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += txt_User_TextChanged;
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
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NOVO CADASTRAMENTO";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label_User;
        private TextBox txt_user;
        private Label label_Password;
        private TextBox txt_password;
        private Button button_enter;
        private Button button_cancel;
        private CheckBox checkBox_showpass;
    }
}