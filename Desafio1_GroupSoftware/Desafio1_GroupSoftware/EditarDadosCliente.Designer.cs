namespace Desafio1_GroupSoftware
{
    partial class EditarDadosCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarDadosCliente));
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
            txt_Endereco = new TextBox();
            txt_nome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label_Tipo = new Label();
            label_Endereco = new Label();
            label_Nome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            button_Delete = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_Delete);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(maskText_Documento);
            groupBox1.Controls.Add(mask_telefone);
            groupBox1.Controls.Add(label_Doc);
            groupBox1.Controls.Add(button_save);
            groupBox1.Controls.Add(button_exit);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_Endereco);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label_Tipo);
            groupBox1.Controls.Add(label_Endereco);
            groupBox1.Controls.Add(label_Nome);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(566, 173);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preencha os campos";
            // 
            // panel1
            // 
            panel1.Controls.Add(radio_CPF);
            panel1.Controls.Add(radio_CNPJ);
            panel1.Location = new Point(288, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(111, 25);
            panel1.TabIndex = 17;
            // 
            // radio_CPF
            // 
            radio_CPF.AutoSize = true;
            radio_CPF.Location = new Point(61, 3);
            radio_CPF.Name = "radio_CPF";
            radio_CPF.Size = new Size(46, 19);
            radio_CPF.TabIndex = 1;
            radio_CPF.TabStop = true;
            radio_CPF.Text = "CPF";
            radio_CPF.UseVisualStyleBackColor = true;
            radio_CPF.CheckedChanged += radio_CPF_CheckedChanged;
            // 
            // radio_CNPJ
            // 
            radio_CNPJ.AutoSize = true;
            radio_CNPJ.Location = new Point(3, 3);
            radio_CNPJ.Name = "radio_CNPJ";
            radio_CNPJ.Size = new Size(52, 19);
            radio_CNPJ.TabIndex = 0;
            radio_CNPJ.TabStop = true;
            radio_CNPJ.Text = "CNPJ";
            radio_CNPJ.UseVisualStyleBackColor = true;
            radio_CNPJ.CheckedChanged += radio_CNPJ_CheckedChanged;
            // 
            // maskText_Documento
            // 
            maskText_Documento.Location = new Point(13, 115);
            maskText_Documento.Name = "maskText_Documento";
            maskText_Documento.Size = new Size(256, 23);
            maskText_Documento.TabIndex = 6;
            maskText_Documento.MaskInputRejected += maskText_Documento_MaskInputRejected;
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
            // label_Doc
            // 
            label_Doc.AutoSize = true;
            label_Doc.Location = new Point(13, 98);
            label_Doc.Name = "label_Doc";
            label_Doc.Size = new Size(73, 15);
            label_Doc.TabIndex = 16;
            label_Doc.Text = "Documento:";
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_save.Location = new Point(475, 143);
            button_save.Margin = new Padding(3, 2, 3, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(82, 22);
            button_save.TabIndex = 8;
            button_save.Text = "SALVAR";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(388, 143);
            button_exit.Margin = new Padding(3, 2, 3, 2);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(82, 22);
            button_exit.TabIndex = 9;
            button_exit.Text = "VOLTAR";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
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
            // txt_Endereco
            // 
            txt_Endereco.Location = new Point(13, 74);
            txt_Endereco.Margin = new Padding(3, 2, 3, 2);
            txt_Endereco.Name = "txt_Endereco";
            txt_Endereco.Size = new Size(256, 23);
            txt_Endereco.TabIndex = 4;
            txt_Endereco.TextChanged += txt_Endereco_TextChanged;
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
            label6.Location = new Point(286, 98);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 57);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "E-mail:";
            // 
            // label_Tipo
            // 
            label_Tipo.AutoSize = true;
            label_Tipo.Location = new Point(286, 16);
            label_Tipo.Name = "label_Tipo";
            label_Tipo.Size = new Size(33, 15);
            label_Tipo.TabIndex = 3;
            label_Tipo.Text = "Tipo:";
            // 
            // label_Endereco
            // 
            label_Endereco.AutoSize = true;
            label_Endereco.Location = new Point(13, 56);
            label_Endereco.Name = "label_Endereco";
            label_Endereco.Size = new Size(59, 15);
            label_Endereco.TabIndex = 1;
            label_Endereco.Text = "Endereço:";
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new Point(11, 16);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(43, 15);
            label_Nome.TabIndex = 0;
            label_Nome.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(50, 16);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 18;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(82, 98);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 19;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 147);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 20;
            label3.Text = "Campos com ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(87, 147);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 21;
            label4.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 147);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 22;
            label7.Text = "não podem ser alterados";
            // 
            // button_Delete
            // 
            button_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Delete.Location = new Point(307, 143);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 23;
            button_Delete.Text = "DELETAR";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // EditarDadosCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 181);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditarDadosCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Dados Cliente";
            Load += EditarDadosCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private RadioButton radio_CPF;
        private RadioButton radio_CNPJ;
        private MaskedTextBox maskText_Documento;
        private MaskedTextBox mask_telefone;
        private Label label_Doc;
        private Button button_save;
        private Button button_exit;
        private TextBox txt_email;
        private TextBox txt_Endereco;
        private TextBox txt_nome;
        private Label label6;
        private Label label5;
        private Label label_Tipo;
        private Label label_Endereco;
        private Label label_Nome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_Delete;
        private Label label7;
        private Label label4;
    }
}