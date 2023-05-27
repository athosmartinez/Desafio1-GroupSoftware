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
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            documentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            clienteBindingSource1 = new BindingSource(components);
            button_Exportar = new Button();
            label_ActiveUser = new Label();
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
            button_Pesquisa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
            txt_Pesquisa.KeyDown += txt_Pesquisa_KeyDown;
            // 
            // button_Voltar
            // 
            button_Voltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Voltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Voltar.Location = new Point(608, 310);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
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
            dataGrid_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid_Clientes.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, Endereço, documentoDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, usuarioIDDataGridViewTextBoxColumn });
            dataGrid_Clientes.DataSource = clienteBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGrid_Clientes.DefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Clientes.Location = new Point(16, 78);
            dataGrid_Clientes.Name = "dataGrid_Clientes";
            dataGrid_Clientes.ReadOnly = true;
            dataGrid_Clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGrid_Clientes.RowHeadersVisible = false;
            dataGrid_Clientes.RowTemplate.Height = 25;
            dataGrid_Clientes.Size = new Size(666, 226);
            dataGrid_Clientes.TabIndex = 3;
            dataGrid_Clientes.CellClick += dataGrid_Clientes_CellClick;
            dataGrid_Clientes.CellContentClick += dataGrid_Clientes_CellContentClick;
            dataGrid_Clientes.CellContentDoubleClick += dataGrid_Clientes_CellContentDoubleClick;
            dataGrid_Clientes.MouseDown += dataGrid_Clientes_MouseDown;
            dataGrid_Clientes.MouseEnter += dataGrid_Clientes_MouseEnter;
            dataGrid_Clientes.MouseMove += dataGrid_Clientes_MouseMove;
            dataGrid_Clientes.Move += dataGrid_Clientes_Move;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Endereço
            // 
            Endereço.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Endereço.DataPropertyName = "endereco";
            Endereço.HeaderText = "Endereço";
            Endereço.Name = "Endereço";
            Endereço.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID";
            usuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID";
            usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            button_Exportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Exportar.Location = new Point(16, 310);
            button_Exportar.Name = "button_Exportar";
            button_Exportar.Size = new Size(75, 23);
            button_Exportar.TabIndex = 4;
            button_Exportar.Text = "EXPORTAR";
            button_Exportar.UseVisualStyleBackColor = true;
            button_Exportar.Click += button_Exportar_Click;
            // 
            // label_ActiveUser
            // 
            label_ActiveUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_ActiveUser.AutoSize = true;
            label_ActiveUser.Location = new Point(94, 314);
            label_ActiveUser.Name = "label_ActiveUser";
            label_ActiveUser.Size = new Size(29, 15);
            label_ActiveUser.TabIndex = 5;
            label_ActiveUser.Text = "user";
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label_ActiveUser);
            Controls.Add(button_Exportar);
            Controls.Add(button_Voltar);
            Controls.Add(groupBox_Pesquisa);
            Controls.Add(dataGrid_Clientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Deactivate += ListaClientes_Deactivate;
            Load += ListaClientes_Load;
            Shown += ListaClientes_Shown;
            MouseMove += ListaClientes_MouseMove;
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
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Endereço;
        private DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
    }
}