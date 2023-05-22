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
            label2 = new Label();
            txt_user = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_showpass);
            groupBox1.Controls.Add(button_enter);
            groupBox1.Controls.Add(button_cancel);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_user);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 8);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(366, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // checkBox_showpass
            // 
            checkBox_showpass.AutoSize = true;
            checkBox_showpass.Location = new Point(253, 101);
            checkBox_showpass.Margin = new Padding(3, 2, 3, 2);
            checkBox_showpass.Name = "checkBox_showpass";
            checkBox_showpass.Size = new Size(108, 19);
            checkBox_showpass.TabIndex = 6;
            checkBox_showpass.Text = "Show Password";
            checkBox_showpass.UseVisualStyleBackColor = true;
            checkBox_showpass.CheckedChanged += checkBox_showpass_CheckedChanged;
            // 
            // button_enter
            // 
            button_enter.Location = new Point(278, 122);
            button_enter.Margin = new Padding(3, 2, 3, 2);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(82, 22);
            button_enter.TabIndex = 5;
            button_enter.Text = "ENTER";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button2_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(191, 122);
            button_cancel.Margin = new Padding(3, 2, 3, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(82, 22);
            button_cancel.TabIndex = 4;
            button_cancel.Text = "CANCEL";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button1_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(5, 74);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(356, 23);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            txt_password.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 57);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(5, 34);
            txt_user.Margin = new Padding(3, 2, 3, 2);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(356, 23);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 17);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            label1.Click += label1_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 170);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label1;
        private TextBox txt_user;
        private Label label2;
        private TextBox txt_password;
        private Button button_enter;
        private Button button_cancel;
        private CheckBox checkBox_showpass;
    }
}