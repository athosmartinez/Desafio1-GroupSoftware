namespace Desafio1_GroupSoftware
{
    partial class CadastramentoClientes
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
            maskedTextBox1 = new MaskedTextBox();
            mask_telefone = new MaskedTextBox();
            label7 = new Label();
            button_save = new Button();
            button_exit = new Button();
            checkbox_cnpj = new CheckBox();
            checkbox_cpf = new CheckBox();
            txt_email = new TextBox();
            txt_endereco = new TextBox();
            txt_nome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(mask_telefone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button_save);
            groupBox1.Controls.Add(button_exit);
            groupBox1.Controls.Add(checkbox_cnpj);
            groupBox1.Controls.Add(checkbox_cpf);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_endereco);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 5);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(566, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preencha os campos";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(13, 115);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(256, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // mask_telefone
            // 
            mask_telefone.Location = new Point(285, 115);
            mask_telefone.Mask = "(99) 00000-0000";
            mask_telefone.Name = "mask_telefone";
            mask_telefone.Size = new Size(272, 23);
            mask_telefone.TabIndex = 7;
            mask_telefone.MaskInputRejected += mask_telefone_MaskInputRejected;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 99);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 16;
            label7.Text = "Documento:";
            label7.Click += label7_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(475, 143);
            button_save.Margin = new Padding(3, 2, 3, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(82, 22);
            button_save.TabIndex = 8;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(388, 143);
            button_exit.Margin = new Padding(3, 2, 3, 2);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(82, 22);
            button_exit.TabIndex = 9;
            button_exit.Text = "EXIT";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // checkbox_cnpj
            // 
            checkbox_cnpj.AutoSize = true;
            checkbox_cnpj.Location = new Point(286, 38);
            checkbox_cnpj.Margin = new Padding(3, 2, 3, 2);
            checkbox_cnpj.Name = "checkbox_cnpj";
            checkbox_cnpj.Size = new Size(53, 19);
            checkbox_cnpj.TabIndex = 2;
            checkbox_cnpj.Text = "CNPJ";
            checkbox_cnpj.UseVisualStyleBackColor = true;
            checkbox_cnpj.CheckedChanged += checkbox_cnpj_CheckedChanged;
            // 
            // checkbox_cpf
            // 
            checkbox_cpf.AutoSize = true;
            checkbox_cpf.Location = new Point(357, 38);
            checkbox_cpf.Margin = new Padding(3, 2, 3, 2);
            checkbox_cpf.Name = "checkbox_cpf";
            checkbox_cpf.Size = new Size(47, 19);
            checkbox_cpf.TabIndex = 3;
            checkbox_cpf.Text = "CPF";
            checkbox_cpf.UseVisualStyleBackColor = true;
            checkbox_cpf.CheckedChanged += checkbox_cpf_CheckedChanged;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(285, 74);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(272, 23);
            txt_email.TabIndex = 5;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(13, 74);
            txt_endereco.Margin = new Padding(3, 2, 3, 2);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(256, 23);
            txt_endereco.TabIndex = 4;
            txt_endereco.TextChanged += txt_endereco_TextChanged;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(13, 34);
            txt_nome.Margin = new Padding(3, 2, 3, 2);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(256, 23);
            txt_nome.TabIndex = 1;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 99);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 58);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 17);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 57);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Endereço:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 17);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // CadastramentoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 179);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CadastramentoClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastramento Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private CheckBox checkbox_cnpj;
        private CheckBox checkbox_cpf;
        private TextBox txt_email;
        private TextBox txt_endereco;
        private TextBox txt_nome;
        private Button button_save;
        private Button button_exit;
        private RadioButton radioButton1;
        private Label label7;
        private MaskedTextBox mask_telefone;
        private MaskedTextBox maskedTextBox1;
    }
}