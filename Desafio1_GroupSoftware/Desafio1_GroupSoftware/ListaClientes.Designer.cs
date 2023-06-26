using Desafio1_GroupSoftware.Classes;

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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            groupBox_Pesquisa = new GroupBox();
            button_Pesquisa = new Button();
            txt_Pesquisa = new TextBox();
            button_Voltar = new Button();
            dataGrid_Clientes = new DataGridView();
            clienteBindingSource = new BindingSource(components);
            clienteBindingSource1 = new BindingSource(components);
            button_Exportar = new Button();
            label_ActiveUser = new Label();
            button_Importar = new Button();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            documentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox_Pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Pesquisa
            // 
            groupBox_Pesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Pesquisa.Controls.Add(button_Pesquisa);
            groupBox_Pesquisa.Controls.Add(txt_Pesquisa);
            groupBox_Pesquisa.Location = new Point(14, 10);
            groupBox_Pesquisa.Margin = new Padding(4, 5, 4, 5);
            groupBox_Pesquisa.Name = "groupBox_Pesquisa";
            groupBox_Pesquisa.Padding = new Padding(4, 5, 4, 5);
            groupBox_Pesquisa.Size = new Size(969, 110);
            groupBox_Pesquisa.TabIndex = 0;
            groupBox_Pesquisa.TabStop = false;
            groupBox_Pesquisa.Text = "Pesquisa";
            // 
            // button_Pesquisa
            // 
            button_Pesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Pesquisa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Pesquisa.Location = new Point(853, 35);
            button_Pesquisa.Margin = new Padding(4, 5, 4, 5);
            button_Pesquisa.Name = "button_Pesquisa";
            button_Pesquisa.Size = new Size(107, 38);
            button_Pesquisa.TabIndex = 1;
            button_Pesquisa.Text = "BUSCAR";
            button_Pesquisa.UseVisualStyleBackColor = true;
            button_Pesquisa.Click += button_Pesquisa_Click;
            // 
            // txt_Pesquisa
            // 
            txt_Pesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Pesquisa.Location = new Point(9, 35);
            txt_Pesquisa.Margin = new Padding(4, 5, 4, 5);
            txt_Pesquisa.Name = "txt_Pesquisa";
            txt_Pesquisa.Size = new Size(834, 31);
            txt_Pesquisa.TabIndex = 0;
            txt_Pesquisa.TextChanged += txt_Pesquisa_TextChanged;
            txt_Pesquisa.KeyDown += txt_Pesquisa_KeyDown;
            // 
            // button_Voltar
            // 
            button_Voltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Voltar.Location = new Point(869, 517);
            button_Voltar.Margin = new Padding(4, 5, 4, 5);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(107, 38);
            button_Voltar.TabIndex = 2;
            button_Voltar.Text = "VOLTAR";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // dataGrid_Clientes
            // 
            dataGrid_Clientes.AllowUserToAddRows = false;
            dataGrid_Clientes.AllowUserToDeleteRows = false;
            dataGrid_Clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Clientes.AutoGenerateColumns = false;
            dataGrid_Clientes.ColumnHeadersHeight = 34;
            dataGrid_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid_Clientes.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, Endereço, documentoDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn });
            dataGrid_Clientes.DataSource = clienteBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGrid_Clientes.DefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Clientes.Location = new Point(23, 130);
            dataGrid_Clientes.Margin = new Padding(4, 5, 4, 5);
            dataGrid_Clientes.Name = "dataGrid_Clientes";
            dataGrid_Clientes.ReadOnly = true;
            dataGrid_Clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGrid_Clientes.RowHeadersVisible = false;
            dataGrid_Clientes.RowHeadersWidth = 62;
            dataGrid_Clientes.RowTemplate.Height = 25;
            dataGrid_Clientes.Size = new Size(951, 377);
            dataGrid_Clientes.TabIndex = 3;
            dataGrid_Clientes.CellContentClick += dataGrid_Clientes_CellContentClick;
            dataGrid_Clientes.CellContentDoubleClick += dataGrid_Clientes_CellContentDoubleClick;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Cliente);
            // 
            // clienteBindingSource1
            // 
            clienteBindingSource1.DataSource = typeof(Cliente);
            // 
            // button_Exportar
            // 
            button_Exportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Exportar.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Exportar.Location = new Point(141, 517);
            button_Exportar.Margin = new Padding(4, 5, 4, 5);
            button_Exportar.Name = "button_Exportar";
            button_Exportar.Size = new Size(107, 38);
            button_Exportar.TabIndex = 4;
            button_Exportar.Text = "EXPORTAR";
            button_Exportar.UseVisualStyleBackColor = true;
            button_Exportar.Click += button_Exportar_Click;
            // 
            // label_ActiveUser
            // 
            label_ActiveUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_ActiveUser.AutoSize = true;
            label_ActiveUser.Location = new Point(257, 523);
            label_ActiveUser.Margin = new Padding(4, 0, 4, 0);
            label_ActiveUser.Name = "label_ActiveUser";
            label_ActiveUser.Size = new Size(45, 25);
            label_ActiveUser.TabIndex = 5;
            label_ActiveUser.Text = "user";
            // 
            // button_Importar
            // 
            button_Importar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Importar.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Importar.Location = new Point(23, 517);
            button_Importar.Margin = new Padding(4, 5, 4, 5);
            button_Importar.Name = "button_Importar";
            button_Importar.Size = new Size(107, 38);
            button_Importar.TabIndex = 6;
            button_Importar.Text = "IMPORTAR";
            button_Importar.UseVisualStyleBackColor = true;
            button_Importar.MouseClick += button_Importar_MouseClick;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Endereço
            // 
            Endereço.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Endereço.DataPropertyName = "endereco";
            Endereço.HeaderText = "Endereço";
            Endereço.MinimumWidth = 8;
            Endereço.Name = "Endereço";
            Endereço.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            documentoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            documentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 563);
            Controls.Add(button_Importar);
            Controls.Add(label_ActiveUser);
            Controls.Add(button_Exportar);
            Controls.Add(button_Voltar);
            Controls.Add(groupBox_Pesquisa);
            Controls.Add(dataGrid_Clientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += ListaClientes_Load;
            Shown += ListaClientes_Shown;
            groupBox_Pesquisa.ResumeLayout(false);
            groupBox_Pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_Pesquisa;
        private Button button_Pesquisa;
        private TextBox txt_Pesquisa;
        private Button button_Voltar;
        private DataGridView dataGrid_Clientes;
        private BindingSource clienteBindingSource;
        private BindingSource clienteBindingSource1;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button button_Exportar;
        private Label label_ActiveUser;
        private Button button_Importar;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Endereço;
        private DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}