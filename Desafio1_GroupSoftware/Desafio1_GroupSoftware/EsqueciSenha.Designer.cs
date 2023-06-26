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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueciSenha));
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
            groupBox1.Location = new Point(7, 10);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(361, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Esqueci minha senha";
            // 
            // button_Cancelar
            // 
            button_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancelar.Location = new Point(81, 113);
            button_Cancelar.Margin = new Padding(4, 5, 4, 5);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(129, 38);
            button_Cancelar.TabIndex = 3;
            button_Cancelar.Text = "CANCELAR";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(218, 113);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(132, 38);
            button1.TabIndex = 2;
            button1.Text = "ENVIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Enviar_Click;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(7, 65);
            textBox_Email.Margin = new Padding(4, 5, 4, 5);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(340, 31);
            textBox_Email.TabIndex = 1;
            textBox_Email.KeyDown += textBox_Email_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Email: ";
            // 
            // EsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 185);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
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