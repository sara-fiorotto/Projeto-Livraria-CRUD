
namespace Livraria_Livrolândia.Forms
{
    partial class Cadastro
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
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label cATEGORIALabel;
            System.Windows.Forms.Label dATA_LANÇAMENTOLabel;
            System.Windows.Forms.Label dESCRIÇÃOLabel;
            System.Windows.Forms.Label pRATELEIRALabel;
            System.Windows.Forms.Label aUTORLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.Windows.Forms.Label pREÇOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.lIVROSDataSet = new Livraria_Livrolândia.LIVROSDataSet();
            this.lIVROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIVROTableAdapter = new Livraria_Livrolândia.LIVROSDataSetTableAdapters.LIVROTableAdapter();
            this.tableAdapterManager = new Livraria_Livrolândia.LIVROSDataSetTableAdapters.TableAdapterManager();
            this.lIVROBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lIVROBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.cATEGORIATextBox = new System.Windows.Forms.TextBox();
            this.dATA_LANÇAMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dESCRIÇÃOTextBox = new System.Windows.Forms.TextBox();
            this.pRATELEIRATextBox = new System.Windows.Forms.TextBox();
            this.aUTORTextBox = new System.Windows.Forms.TextBox();
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.pREÇOTextBox = new System.Windows.Forms.TextBox();
            this.lIVRODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            nOMELabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            cATEGORIALabel = new System.Windows.Forms.Label();
            dATA_LANÇAMENTOLabel = new System.Windows.Forms.Label();
            dESCRIÇÃOLabel = new System.Windows.Forms.Label();
            pRATELEIRALabel = new System.Windows.Forms.Label();
            aUTORLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            pREÇOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingNavigator)).BeginInit();
            this.lIVROBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIVRODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(280, 116);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "NOME:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(280, 142);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 5;
            iSBNLabel.Text = "ISBN:";
            // 
            // cATEGORIALabel
            // 
            cATEGORIALabel.AutoSize = true;
            cATEGORIALabel.Location = new System.Drawing.Point(280, 168);
            cATEGORIALabel.Name = "cATEGORIALabel";
            cATEGORIALabel.Size = new System.Drawing.Size(72, 13);
            cATEGORIALabel.TabIndex = 7;
            cATEGORIALabel.Text = "CATEGORIA:";
            // 
            // dATA_LANÇAMENTOLabel
            // 
            dATA_LANÇAMENTOLabel.AutoSize = true;
            dATA_LANÇAMENTOLabel.Location = new System.Drawing.Point(280, 195);
            dATA_LANÇAMENTOLabel.Name = "dATA_LANÇAMENTOLabel";
            dATA_LANÇAMENTOLabel.Size = new System.Drawing.Size(116, 13);
            dATA_LANÇAMENTOLabel.TabIndex = 9;
            dATA_LANÇAMENTOLabel.Text = "DATA LANÇAMENTO:";
            // 
            // dESCRIÇÃOLabel
            // 
            dESCRIÇÃOLabel.AutoSize = true;
            dESCRIÇÃOLabel.Location = new System.Drawing.Point(280, 220);
            dESCRIÇÃOLabel.Name = "dESCRIÇÃOLabel";
            dESCRIÇÃOLabel.Size = new System.Drawing.Size(72, 13);
            dESCRIÇÃOLabel.TabIndex = 11;
            dESCRIÇÃOLabel.Text = "DESCRIÇÃO:";
            // 
            // pRATELEIRALabel
            // 
            pRATELEIRALabel.AutoSize = true;
            pRATELEIRALabel.Location = new System.Drawing.Point(280, 246);
            pRATELEIRALabel.Name = "pRATELEIRALabel";
            pRATELEIRALabel.Size = new System.Drawing.Size(77, 13);
            pRATELEIRALabel.TabIndex = 13;
            pRATELEIRALabel.Text = "PRATELEIRA:";
            // 
            // aUTORLabel
            // 
            aUTORLabel.AutoSize = true;
            aUTORLabel.Location = new System.Drawing.Point(280, 272);
            aUTORLabel.Name = "aUTORLabel";
            aUTORLabel.Size = new System.Drawing.Size(48, 13);
            aUTORLabel.TabIndex = 15;
            aUTORLabel.Text = "AUTOR:";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(280, 298);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(81, 13);
            qUANTIDADELabel.TabIndex = 17;
            qUANTIDADELabel.Text = "QUANTIDADE:";
            // 
            // pREÇOLabel
            // 
            pREÇOLabel.AutoSize = true;
            pREÇOLabel.Location = new System.Drawing.Point(280, 324);
            pREÇOLabel.Name = "pREÇOLabel";
            pREÇOLabel.Size = new System.Drawing.Size(47, 13);
            pREÇOLabel.TabIndex = 19;
            pREÇOLabel.Text = "PREÇO:";
            // 
            // lIVROSDataSet
            // 
            this.lIVROSDataSet.DataSetName = "LIVROSDataSet";
            this.lIVROSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIVROBindingSource
            // 
            this.lIVROBindingSource.DataMember = "LIVRO";
            this.lIVROBindingSource.DataSource = this.lIVROSDataSet;
            // 
            // lIVROTableAdapter
            // 
            this.lIVROTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LIVROTableAdapter = this.lIVROTableAdapter;
            this.tableAdapterManager.UpdateOrder = Livraria_Livrolândia.LIVROSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lIVROBindingNavigator
            // 
            this.lIVROBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lIVROBindingNavigator.BindingSource = this.lIVROBindingSource;
            this.lIVROBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lIVROBindingNavigator.DeleteItem = null;
            this.lIVROBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lIVROBindingNavigatorSaveItem});
            this.lIVROBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lIVROBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lIVROBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lIVROBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lIVROBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lIVROBindingNavigator.Name = "lIVROBindingNavigator";
            this.lIVROBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lIVROBindingNavigator.Size = new System.Drawing.Size(897, 25);
            this.lIVROBindingNavigator.TabIndex = 0;
            this.lIVROBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // lIVROBindingNavigatorSaveItem
            // 
            this.lIVROBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lIVROBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lIVROBindingNavigatorSaveItem.Image")));
            this.lIVROBindingNavigatorSaveItem.Name = "lIVROBindingNavigatorSaveItem";
            this.lIVROBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lIVROBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.lIVROBindingNavigatorSaveItem.Click += new System.EventHandler(this.lIVROBindingNavigatorSaveItem_Click);
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIVROBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(402, 113);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(200, 20);
            this.nOMETextBox.TabIndex = 4;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIVROBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(402, 139);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(200, 20);
            this.iSBNTextBox.TabIndex = 6;
            // 
            // cATEGORIATextBox
            // 
            this.cATEGORIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIVROBindingSource, "CATEGORIA", true));
            this.cATEGORIATextBox.Location = new System.Drawing.Point(402, 165);
            this.cATEGORIATextBox.Name = "cATEGORIATextBox";
            this.cATEGORIATextBox.Size = new System.Drawing.Size(200, 20);
            this.cATEGORIATextBox.TabIndex = 8;
            // 
            // dATA_LANÇAMENTODateTimePicker
            // 
            this.dATA_LANÇAMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lIVROBindingSource, "DATA_LANÇAMENTO", true));
            this.dATA_LANÇAMENTODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATA_LANÇAMENTODateTimePicker.Location = new System.Drawing.Point(402, 191);
            this.dATA_LANÇAMENTODateTimePicker.Name = "dATA_LANÇAMENTODateTimePicker";
            this.dATA_LANÇAMENTODateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATA_LANÇAMENTODateTimePicker.TabIndex = 10;
            // 
            // dESCRIÇÃOTextBox
            // 
            this.dESCRIÇÃOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIVROBindingSource, "DESCRIÇÃO", true));
            this.dESCRIÇÃOTextBox.Location = new System.Drawing.Point(402, 217);
            this.dESCRIÇÃOTextBox.Name = "dESCRIÇÃOTextBox";
            this.dESCRIÇÃOTextBox.Size = new System.Drawing.Size(200, 20);
            this.dESCRIÇÃOTextBox.TabIndex = 12;
            // 
            // pRATELEIRATextBox
            // 
            this.pRATELEIRATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIVROBindingSource, "PRATELEIRA", true));
            this.pRATELEIRATextBox.Location = new System.Drawing.Point(402, 243);
            this.pRATELEIRATextBox.Name = "pRATELEIRATextBox";
            this.pRATELEIRATextBox.Size = new System.Drawing.Size(200, 20);
            this.pRATELEIRATextBox.TabIndex = 14;
            // 
            // aUTORTextBox
            // 
            this.aUTORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIVROBindingSource, "AUTOR", true));
            this.aUTORTextBox.Location = new System.Drawing.Point(402, 269);
            this.aUTORTextBox.Name = "aUTORTextBox";
            this.aUTORTextBox.Size = new System.Drawing.Size(200, 20);
            this.aUTORTextBox.TabIndex = 16;
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIVROBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(402, 295);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(200, 20);
            this.qUANTIDADETextBox.TabIndex = 18;
            // 
            // pREÇOTextBox
            // 
            this.pREÇOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIVROBindingSource, "PREÇO", true));
            this.pREÇOTextBox.Location = new System.Drawing.Point(402, 321);
            this.pREÇOTextBox.Name = "pREÇOTextBox";
            this.pREÇOTextBox.Size = new System.Drawing.Size(200, 20);
            this.pREÇOTextBox.TabIndex = 20;
            // 
            // lIVRODataGridView
            // 
            this.lIVRODataGridView.AllowUserToAddRows = false;
            this.lIVRODataGridView.AllowUserToDeleteRows = false;
            this.lIVRODataGridView.AutoGenerateColumns = false;
            this.lIVRODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lIVRODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.lIVRODataGridView.Cursor = System.Windows.Forms.Cursors.No;
            this.lIVRODataGridView.DataSource = this.lIVROBindingSource;
            this.lIVRODataGridView.Location = new System.Drawing.Point(35, 370);
            this.lIVRODataGridView.Name = "lIVRODataGridView";
            this.lIVRODataGridView.ReadOnly = true;
            this.lIVRODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lIVRODataGridView.Size = new System.Drawing.Size(823, 220);
            this.lIVRODataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CATEGORIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "CATEGORIA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DATA_LANÇAMENTO";
            this.dataGridViewTextBoxColumn5.HeaderText = "DATA_LANÇAMENTO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DESCRIÇÃO";
            this.dataGridViewTextBoxColumn6.HeaderText = "DESCRIÇÃO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PRATELEIRA";
            this.dataGridViewTextBoxColumn7.HeaderText = "PRATELEIRA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AUTOR";
            this.dataGridViewTextBoxColumn8.HeaderText = "AUTOR";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "QUANTIDADE";
            this.dataGridViewTextBoxColumn9.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PREÇO";
            this.dataGridViewTextBoxColumn10.HeaderText = "PREÇO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 53);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cadastro de Livros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(608, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 620);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lIVRODataGridView);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(cATEGORIALabel);
            this.Controls.Add(this.cATEGORIATextBox);
            this.Controls.Add(dATA_LANÇAMENTOLabel);
            this.Controls.Add(this.dATA_LANÇAMENTODateTimePicker);
            this.Controls.Add(dESCRIÇÃOLabel);
            this.Controls.Add(this.dESCRIÇÃOTextBox);
            this.Controls.Add(pRATELEIRALabel);
            this.Controls.Add(this.pRATELEIRATextBox);
            this.Controls.Add(aUTORLabel);
            this.Controls.Add(this.aUTORTextBox);
            this.Controls.Add(qUANTIDADELabel);
            this.Controls.Add(this.qUANTIDADETextBox);
            this.Controls.Add(pREÇOLabel);
            this.Controls.Add(this.pREÇOTextBox);
            this.Controls.Add(this.lIVROBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingNavigator)).EndInit();
            this.lIVROBindingNavigator.ResumeLayout(false);
            this.lIVROBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIVRODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LIVROSDataSet lIVROSDataSet;
        private System.Windows.Forms.BindingSource lIVROBindingSource;
        private LIVROSDataSetTableAdapters.LIVROTableAdapter lIVROTableAdapter;
        private LIVROSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lIVROBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lIVROBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox cATEGORIATextBox;
        private System.Windows.Forms.DateTimePicker dATA_LANÇAMENTODateTimePicker;
        private System.Windows.Forms.TextBox dESCRIÇÃOTextBox;
        private System.Windows.Forms.TextBox pRATELEIRATextBox;
        private System.Windows.Forms.TextBox aUTORTextBox;
        private System.Windows.Forms.TextBox qUANTIDADETextBox;
        private System.Windows.Forms.TextBox pREÇOTextBox;
        private System.Windows.Forms.DataGridView lIVRODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}