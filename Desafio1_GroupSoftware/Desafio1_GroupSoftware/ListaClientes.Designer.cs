namespace Desafio1_GroupSoftware
{
    partial class ListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            groupBox_Pesquisa = new GroupBox();
            button_Pesquisa = new Button();
            txt_Pesquisa = new TextBox();
            button_Voltar = new Button();
            dataGrid_Clientes = new DataGridView();
            groupBox_Pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Clientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Pesquisa
            // 
            groupBox_Pesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Pesquisa.Controls.Add(button_Pesquisa);
            groupBox_Pesquisa.Controls.Add(txt_Pesquisa);
            groupBox_Pesquisa.Location = new Point(10, 6);
            groupBox_Pesquisa.Name = "groupBox_Pesquisa";
            groupBox_Pesquisa.Size = new Size(678, 66);
            groupBox_Pesquisa.TabIndex = 0;
            groupBox_Pesquisa.TabStop = false;
            groupBox_Pesquisa.Text = "Pesquisa";
            // 
            // button_Pesquisa
            // 
            button_Pesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Pesquisa.Location = new Point(597, 21);
            button_Pesquisa.Name = "button_Pesquisa";
            button_Pesquisa.Size = new Size(75, 23);
            button_Pesquisa.TabIndex = 1;
            button_Pesquisa.Text = "BUSCAR";
            button_Pesquisa.UseVisualStyleBackColor = true;
            button_Pesquisa.Click += button_Pesquisa_Click;
            // 
            // txt_Pesquisa
            // 
            txt_Pesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Pesquisa.Location = new Point(6, 21);
            txt_Pesquisa.Name = "txt_Pesquisa";
            txt_Pesquisa.Size = new Size(585, 23);
            txt_Pesquisa.TabIndex = 0;
            txt_Pesquisa.TextChanged += txt_Pesquisa_TextChanged;
            // 
            // button_Voltar
            // 
            button_Voltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Voltar.Location = new Point(608, 310);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 2;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // dataGrid_Clientes
            // 
            dataGrid_Clientes.AllowUserToAddRows = false;
            dataGrid_Clientes.AllowUserToDeleteRows = false;
            dataGrid_Clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid_Clientes.Location = new Point(16, 78);
            dataGrid_Clientes.Name = "dataGrid_Clientes";
            dataGrid_Clientes.ReadOnly = true;
            dataGrid_Clientes.RowTemplate.Height = 25;
            dataGrid_Clientes.Size = new Size(666, 226);
            dataGrid_Clientes.TabIndex = 3;
            dataGrid_Clientes.CellContentClick += dataGrid_Clientes_CellContentClick;
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button_Voltar);
            Controls.Add(groupBox_Pesquisa);
            Controls.Add(dataGrid_Clientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            groupBox_Pesquisa.ResumeLayout(false);
            groupBox_Pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Pesquisa;
        private Button button_Pesquisa;
        private TextBox txt_Pesquisa;
        private Button button_Voltar;
        private DataGridView dataGrid_Clientes;
    }
}