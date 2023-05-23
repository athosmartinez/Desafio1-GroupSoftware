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
            panel1 = new Panel();
            radio_CPF = new RadioButton();
            radio_CNPJ = new RadioButton();
            maskText_Documento = new MaskedTextBox();
            mask_telefone = new MaskedTextBox();
            label_Doc = new Label();
            button_save = new Button();
            button_exit = new Button();
            txt_email = new TextBox();
            txt_endereco = new TextBox();
            txt_nome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label_Tipo = new Label();
            label_Endereco = new Label();
            label_Nome = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(maskText_Documento);
            groupBox1.Controls.Add(mask_telefone);
            groupBox1.Controls.Add(label_Doc);
            groupBox1.Controls.Add(button_save);
            groupBox1.Controls.Add(button_exit);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_endereco);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label_Tipo);
            groupBox1.Controls.Add(label_Endereco);
            groupBox1.Controls.Add(label_Nome);
            groupBox1.Location = new Point(11, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preencha os campos";
            groupBox1.Enter += groupBox_Form_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(radio_CPF);
            panel1.Controls.Add(radio_CNPJ);
            panel1.Location = new Point(329, 43);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 33);
            panel1.TabIndex = 17;
            // 
            // radio_CPF
            // 
            radio_CPF.AutoSize = true;
            radio_CPF.Location = new Point(70, 4);
            radio_CPF.Margin = new Padding(3, 4, 3, 4);
            radio_CPF.Name = "radio_CPF";
            radio_CPF.Size = new Size(54, 24);
            radio_CPF.TabIndex = 1;
            radio_CPF.TabStop = true;
            radio_CPF.Text = "CPF";
            radio_CPF.UseVisualStyleBackColor = true;
            radio_CPF.CheckedChanged += radio_CPF_CheckedChanged;
            // 
            // radio_CNPJ
            // 
            radio_CNPJ.AutoSize = true;
            radio_CNPJ.Location = new Point(3, 4);
            radio_CNPJ.Margin = new Padding(3, 4, 3, 4);
            radio_CNPJ.Name = "radio_CNPJ";
            radio_CNPJ.Size = new Size(62, 24);
            radio_CNPJ.TabIndex = 0;
            radio_CNPJ.TabStop = true;
            radio_CNPJ.Text = "CNPJ";
            radio_CNPJ.UseVisualStyleBackColor = true;
            radio_CNPJ.CheckedChanged += radio_CNPJ_CheckedChanged;
            // 
            // maskText_Documento
            // 
            maskText_Documento.Location = new Point(15, 153);
            maskText_Documento.Margin = new Padding(3, 4, 3, 4);
            maskText_Documento.Name = "maskText_Documento";
            maskText_Documento.Size = new Size(292, 27);
            maskText_Documento.TabIndex = 6;
            maskText_Documento.MaskInputRejected += maskText_Documento_MaskInputRejected;
            // 
            // mask_telefone
            // 
            mask_telefone.Location = new Point(326, 153);
            mask_telefone.Margin = new Padding(3, 4, 3, 4);
            mask_telefone.Mask = "(99) 00000-0000";
            mask_telefone.Name = "mask_telefone";
            mask_telefone.Size = new Size(310, 27);
            mask_telefone.TabIndex = 7;
            mask_telefone.MaskInputRejected += maskText_telefone_MaskInputRejected;
            // 
            // label_Doc
            // 
            label_Doc.AutoSize = true;
            label_Doc.Location = new Point(15, 132);
            label_Doc.Name = "label_Doc";
            label_Doc.Size = new Size(90, 20);
            label_Doc.TabIndex = 16;
            label_Doc.Text = "Documento:";
            label_Doc.Click += label_Doc_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(543, 191);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 8;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(443, 191);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 9;
            button_exit.Text = "EXIT";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(326, 99);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(310, 27);
            txt_email.TabIndex = 5;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(15, 99);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(292, 27);
            txt_endereco.TabIndex = 4;
            txt_endereco.TextChanged += txt_endereco_TextChanged;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(15, 45);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(292, 27);
            txt_nome.TabIndex = 1;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 132);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 77);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "E-mail:";
            // 
            // label_Tipo
            // 
            label_Tipo.AutoSize = true;
            label_Tipo.Location = new Point(327, 23);
            label_Tipo.Name = "label_Tipo";
            label_Tipo.Size = new Size(42, 20);
            label_Tipo.TabIndex = 3;
            label_Tipo.Text = "Tipo:";
            label_Tipo.Click += label_Tipo_Click;
            // 
            // label_Endereco
            // 
            label_Endereco.AutoSize = true;
            label_Endereco.Location = new Point(15, 76);
            label_Endereco.Name = "label_Endereco";
            label_Endereco.Size = new Size(74, 20);
            label_Endereco.TabIndex = 1;
            label_Endereco.Text = "Endereço:";
            label_Endereco.Click += label_Endereco_Click;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new Point(13, 23);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(53, 20);
            label_Nome.TabIndex = 0;
            label_Nome.Text = "Nome:";
            // 
            // CadastramentoClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 239);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CadastramentoClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastramento Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label_Tipo;
        private Label label_Endereco;
        private Label label_Nome;
        private TextBox txt_email;
        private TextBox txt_endereco;
        private TextBox txt_nome;
        private Button button_save;
        private Button button_exit;
        private RadioButton radioButton1;
        private Label label_Doc;
        private MaskedTextBox mask_telefone;
        private MaskedTextBox maskText_Documento;
        private Panel panel1;
        private RadioButton radio_CPF;
        private RadioButton radio_CNPJ;
    }
}