namespace Proj_Biblioteca.Formulários
{
    partial class frmCadLivros
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autoresLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label dataEdicaoLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadLivros));
            this.livroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1_Biblioteca = new Proj_Biblioteca.Dados.DataSet_Biblioteca();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.livroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autoresTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.dataEdicaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.livroDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroTableAdapter = new Proj_Biblioteca.Dados.DataSet_BibliotecaTableAdapters.LivroTableAdapter();
            this.tableAdapterManager = new Proj_Biblioteca.Dados.DataSet_BibliotecaTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autoresLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            dataEdicaoLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingNavigator)).BeginInit();
            this.livroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_Biblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(114, 57);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(34, 18);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(86, 87);
            tituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(62, 18);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "Titulo:";
            // 
            // autoresLabel
            // 
            autoresLabel.AutoSize = true;
            autoresLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autoresLabel.Location = new System.Drawing.Point(70, 119);
            autoresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            autoresLabel.Name = "autoresLabel";
            autoresLabel.Size = new System.Drawing.Size(78, 18);
            autoresLabel.TabIndex = 5;
            autoresLabel.Text = "Autores:";
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editoraLabel.Location = new System.Drawing.Point(477, 57);
            editoraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(73, 18);
            editoraLabel.TabIndex = 7;
            editoraLabel.Text = "Editora:";
            // 
            // dataEdicaoLabel
            // 
            dataEdicaoLabel.AutoSize = true;
            dataEdicaoLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataEdicaoLabel.Location = new System.Drawing.Point(437, 87);
            dataEdicaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataEdicaoLabel.Name = "dataEdicaoLabel";
            dataEdicaoLabel.Size = new System.Drawing.Size(113, 18);
            dataEdicaoLabel.TabIndex = 9;
            dataEdicaoLabel.Text = "Data Edicao:";
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            assuntoLabel.Location = new System.Drawing.Point(469, 119);
            assuntoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(81, 18);
            assuntoLabel.TabIndex = 11;
            assuntoLabel.Text = "Assunto:";
            // 
            // livroBindingNavigator
            // 
            this.livroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.livroBindingNavigator.BindingSource = this.livroBindingSource;
            this.livroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.livroBindingNavigator.DeleteItem = null;
            this.livroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.livroBindingNavigatorSaveItem});
            this.livroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.livroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.livroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.livroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.livroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.livroBindingNavigator.Name = "livroBindingNavigator";
            this.livroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.livroBindingNavigator.Size = new System.Drawing.Size(939, 25);
            this.livroBindingNavigator.TabIndex = 0;
            this.livroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.dataSet1_Biblioteca;
            // 
            // dataSet1_Biblioteca
            // 
            this.dataSet1_Biblioteca.DataSetName = "DataSet1_Biblioteca";
            this.dataSet1_Biblioteca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // livroBindingNavigatorSaveItem
            // 
            this.livroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.livroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("livroBindingNavigatorSaveItem.Image")));
            this.livroBindingNavigatorSaveItem.Name = "livroBindingNavigatorSaveItem";
            this.livroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.livroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.livroBindingNavigatorSaveItem.Click += new System.EventHandler(this.livroBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.Color.Silver;
            this.iDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.ForeColor = System.Drawing.Color.Black;
            this.iDTextBox.Location = new System.Drawing.Point(156, 57);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(112, 16);
            this.iDTextBox.TabIndex = 2;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BackColor = System.Drawing.Color.Silver;
            this.tituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Titulo", true));
            this.tituloTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.ForeColor = System.Drawing.Color.Black;
            this.tituloTextBox.Location = new System.Drawing.Point(156, 89);
            this.tituloTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(265, 16);
            this.tituloTextBox.TabIndex = 4;
            // 
            // autoresTextBox
            // 
            this.autoresTextBox.BackColor = System.Drawing.Color.Silver;
            this.autoresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autoresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Autores", true));
            this.autoresTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoresTextBox.ForeColor = System.Drawing.Color.Black;
            this.autoresTextBox.Location = new System.Drawing.Point(156, 121);
            this.autoresTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.autoresTextBox.Name = "autoresTextBox";
            this.autoresTextBox.Size = new System.Drawing.Size(265, 16);
            this.autoresTextBox.TabIndex = 6;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.BackColor = System.Drawing.Color.Silver;
            this.editoraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Editora", true));
            this.editoraTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editoraTextBox.ForeColor = System.Drawing.Color.Black;
            this.editoraTextBox.Location = new System.Drawing.Point(558, 57);
            this.editoraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(209, 16);
            this.editoraTextBox.TabIndex = 8;
            // 
            // dataEdicaoDateTimePicker
            // 
            this.dataEdicaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.livroBindingSource, "DataEdicao", true));
            this.dataEdicaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataEdicaoDateTimePicker.Location = new System.Drawing.Point(558, 89);
            this.dataEdicaoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataEdicaoDateTimePicker.Name = "dataEdicaoDateTimePicker";
            this.dataEdicaoDateTimePicker.Size = new System.Drawing.Size(125, 23);
            this.dataEdicaoDateTimePicker.TabIndex = 10;
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.BackColor = System.Drawing.Color.Silver;
            this.assuntoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Assunto", true));
            this.assuntoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assuntoTextBox.ForeColor = System.Drawing.Color.Black;
            this.assuntoTextBox.Location = new System.Drawing.Point(558, 121);
            this.assuntoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(209, 16);
            this.assuntoTextBox.TabIndex = 12;
            // 
            // livroDataGridView
            // 
            this.livroDataGridView.AutoGenerateColumns = false;
            this.livroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.livroDataGridView.DataSource = this.livroBindingSource;
            this.livroDataGridView.Location = new System.Drawing.Point(16, 206);
            this.livroDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.livroDataGridView.Name = "livroDataGridView";
            this.livroDataGridView.Size = new System.Drawing.Size(904, 409);
            this.livroDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Autores";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autores";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 155;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Editora";
            this.dataGridViewTextBoxColumn4.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataEdicao";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataEdicao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Assunto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Assunto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 155;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LivroTableAdapter = this.livroTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj_Biblioteca.Dados.DataSet_BibliotecaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCadLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 622);
            this.Controls.Add(this.livroDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(autoresLabel);
            this.Controls.Add(this.autoresTextBox);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(dataEdicaoLabel);
            this.Controls.Add(this.dataEdicaoDateTimePicker);
            this.Controls.Add(assuntoLabel);
            this.Controls.Add(this.assuntoTextBox);
            this.Controls.Add(this.livroBindingNavigator);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.frmCadLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingNavigator)).EndInit();
            this.livroBindingNavigator.ResumeLayout(false);
            this.livroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_Biblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DataSet_Biblioteca dataSet1_Biblioteca;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private Dados.DataSet_BibliotecaTableAdapters.LivroTableAdapter livroTableAdapter;
        private Dados.DataSet_BibliotecaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator livroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton livroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autoresTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.DateTimePicker dataEdicaoDateTimePicker;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.DataGridView livroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}