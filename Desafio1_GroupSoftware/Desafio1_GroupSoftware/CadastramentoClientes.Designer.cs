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
            button_save = new Button();
            button_exit = new Button();
            checkbox_cnpj = new CheckBox();
            checkbox_cpf = new CheckBox();
            txt_telefone = new TextBox();
            txt_documento = new TextBox();
            txt_email = new TextBox();
            txt_endereco = new TextBox();
            txt_nome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_save);
            groupBox1.Controls.Add(button_exit);
            groupBox1.Controls.Add(checkbox_cnpj);
            groupBox1.Controls.Add(checkbox_cpf);
            groupBox1.Controls.Add(txt_telefone);
            groupBox1.Controls.Add(txt_documento);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_endereco);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preencha os campos";
            // 
            // button_save
            // 
            button_save.Location = new Point(543, 191);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 15;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(443, 191);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 14;
            button_exit.Text = "EXIT";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // checkbox_cnpj
            // 
            checkbox_cnpj.AutoSize = true;
            checkbox_cnpj.Location = new Point(327, 51);
            checkbox_cnpj.Name = "checkbox_cnpj";
            checkbox_cnpj.Size = new Size(63, 24);
            checkbox_cnpj.TabIndex = 13;
            checkbox_cnpj.Text = "CNPJ";
            checkbox_cnpj.UseVisualStyleBackColor = true;
            checkbox_cnpj.CheckedChanged += checkbox_cnpj_CheckedChanged;
            // 
            // checkbox_cpf
            // 
            checkbox_cpf.AutoSize = true;
            checkbox_cpf.Location = new Point(408, 51);
            checkbox_cpf.Name = "checkbox_cpf";
            checkbox_cpf.Size = new Size(55, 24);
            checkbox_cpf.TabIndex = 12;
            checkbox_cpf.Text = "CPF";
            checkbox_cpf.UseVisualStyleBackColor = true;
            checkbox_cpf.CheckedChanged += checkbox_cpf_CheckedChanged;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(327, 154);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(310, 27);
            txt_telefone.TabIndex = 11;
            txt_telefone.TextChanged += txt_telefone_TextChanged;
            // 
            // txt_documento
            // 
            txt_documento.Location = new Point(15, 154);
            txt_documento.Name = "txt_documento";
            txt_documento.Size = new Size(292, 27);
            txt_documento.TabIndex = 10;
            txt_documento.TextChanged += txt_documento_TextChanged;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(327, 101);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(310, 27);
            txt_email.TabIndex = 9;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(15, 99);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(292, 27);
            txt_endereco.TabIndex = 8;
            txt_endereco.TextChanged += txt_endereco_TextChanged;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(15, 46);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(295, 27);
            txt_nome.TabIndex = 6;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 131);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 78);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "E-MAIL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 23);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 131);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 76);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Endereço:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // CadastramentoClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 239);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkbox_cnpj;
        private CheckBox checkbox_cpf;
        private TextBox txt_telefone;
        private TextBox txt_documento;
        private TextBox txt_email;
        private TextBox txt_endereco;
        private TextBox txt_nome;
        private Button button_save;
        private Button button_exit;
    }
}