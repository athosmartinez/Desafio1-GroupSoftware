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
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Form";
            // 
            // checkBox_showpass
            // 
            checkBox_showpass.AutoSize = true;
            checkBox_showpass.Location = new Point(280, 132);
            checkBox_showpass.Name = "checkBox_showpass";
            checkBox_showpass.Size = new Size(132, 24);
            checkBox_showpass.TabIndex = 6;
            checkBox_showpass.Text = "Show Password";
            checkBox_showpass.UseVisualStyleBackColor = true;
            checkBox_showpass.CheckedChanged += checkBox_showpass_CheckedChanged;
            // 
            // button_enter
            // 
            button_enter.Location = new Point(318, 162);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(94, 29);
            button_enter.TabIndex = 5;
            button_enter.Text = "ENTER";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button2_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(218, 162);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 4;
            button_cancel.Text = "CANCEL";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button1_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(6, 99);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(406, 27);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            txt_password.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(6, 46);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(406, 27);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "User";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 217);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DESAFIO 1";
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