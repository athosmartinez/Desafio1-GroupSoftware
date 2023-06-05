namespace Desafio1_GroupSoftware
{
    partial class EsqueciSenha
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
            groupBox1 = new GroupBox();
            button_Cancelar = new Button();
            button1 = new Button();
            textBox_Email = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_Cancelar);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox_Email);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Esqueci minha senha";
            // 
            // button_Cancelar
            // 
            button_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancelar.Location = new Point(88, 68);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(75, 23);
            button_Cancelar.TabIndex = 3;
            button_Cancelar.Text = "CANCELAR";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(170, 68);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "ENVIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Enviar_Click;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(5, 39);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(239, 23);
            textBox_Email.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Email: ";
            // 
            // EsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 111);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "EsqueciSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esqueci Minha Senha";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox_Email;
        private Button button_Cancelar;
        private Button button1;
    }
}