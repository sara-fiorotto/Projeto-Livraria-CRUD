namespace Livraria_Livrolândia.Forms
{
    partial class ConsultarLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarLivros));
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.cmbProcurar = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.txtPesquisa2 = new System.Windows.Forms.TextBox();
            this.lIVROSDataSet = new Livraria_Livrolândia.LIVROSDataSet();
            this.lIVROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIVROTableAdapter = new Livraria_Livrolândia.LIVROSDataSetTableAdapters.LIVROTableAdapter();
            this.tableAdapterManager1 = new Livraria_Livrolândia.LIVROSDataSetTableAdapters.TableAdapterManager();
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVRODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColuna
            // 
            this.cmbColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "NOME",
            "ISBN",
            "CATEGORIA",
            "DESCRICAO",
            "PRATELEIRA",
            "AUTOR",
            "QUANTIDADE",
            "PREÇO"});
            this.cmbColuna.Location = new System.Drawing.Point(70, 111);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(150, 21);
            this.cmbColuna.TabIndex = 0;
            this.cmbColuna.SelectedIndexChanged += new System.EventHandler(this.CmbColuna_SelectedIndexChanged);
            // 
            // cmbProcurar
            // 
            this.cmbProcurar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcurar.FormattingEnabled = true;
            this.cmbProcurar.Items.AddRange(new object[] {
            "Igual a",
            "Começa com",
            "Contem",
            "Todos",
            "Termina com"});
            this.cmbProcurar.Location = new System.Drawing.Point(250, 111);
            this.cmbProcurar.Name = "cmbProcurar";
            this.cmbProcurar.Size = new System.Drawing.Size(114, 21);
            this.cmbProcurar.TabIndex = 1;
            this.cmbProcurar.SelectedValueChanged += new System.EventHandler(this.CmbProcurar_SelectedValueChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(387, 112);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(216, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Enabled = false;
            this.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFiltrar.Location = new System.Drawing.Point(615, 109);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 22);
            this.BtnFiltrar.TabIndex = 5;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // txtPesquisa2
            // 
            this.txtPesquisa2.Location = new System.Drawing.Point(387, 138);
            this.txtPesquisa2.Name = "txtPesquisa2";
            this.txtPesquisa2.Size = new System.Drawing.Size(216, 20);
            this.txtPesquisa2.TabIndex = 6;
            this.txtPesquisa2.Visible = false;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LIVROTableAdapter = this.lIVROTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Livraria_Livrolândia.LIVROSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.lIVRODataGridView.Location = new System.Drawing.Point(57, 189);
            this.lIVRODataGridView.Name = "lIVRODataGridView";
            this.lIVRODataGridView.ReadOnly = true;
            this.lIVRODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lIVRODataGridView.Size = new System.Drawing.Size(835, 220);
            this.lIVRODataGridView.TabIndex = 6;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CATEGORIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "CATEGORIA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DATA_LANÇAMENTO";
            this.dataGridViewTextBoxColumn5.HeaderText = "DATA_LANÇAMENTO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DESCRIÇÃO";
            this.dataGridViewTextBoxColumn6.HeaderText = "DESCRIÇÃO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PRATELEIRA";
            this.dataGridViewTextBoxColumn7.HeaderText = "PRATELEIRA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AUTOR";
            this.dataGridViewTextBoxColumn8.HeaderText = "AUTOR";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "QUANTIDADE";
            this.dataGridViewTextBoxColumn9.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PREÇO";
            this.dataGridViewTextBoxColumn10.HeaderText = "PREÇO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(615, 135);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 53);
            this.label1.TabIndex = 23;
            this.label1.Text = "Consulta de Livros";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(710, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(154, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Por:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Como:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Escreva:";
            // 
            // ConsultarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 532);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lIVRODataGridView);
            this.Controls.Add(this.txtPesquisa2);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cmbProcurar);
            this.Controls.Add(this.cmbColuna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarLivros";
            this.Text = "Consultar Livros";
            this.Load += new System.EventHandler(this.ConsultarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVRODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.ComboBox cmbProcurar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox txtPesquisa2;
        private LIVROSDataSet lIVROSDataSet;
        private System.Windows.Forms.BindingSource lIVROBindingSource;
        private LIVROSDataSetTableAdapters.LIVROTableAdapter lIVROTableAdapter;
        private LIVROSDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
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
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}