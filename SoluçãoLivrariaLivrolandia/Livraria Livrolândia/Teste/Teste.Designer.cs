namespace Livraria_Livrolândia.Teste
{
    partial class Teste
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teste));
            this.lIVROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIVROSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIVROSDataSet = new Livraria_Livrolândia.LIVROSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lIVROTableAdapter = new Livraria_Livrolândia.LIVROSDataSetTableAdapters.LIVROTableAdapter();
            this.lIVROBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.cATEGORIASLIVROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book = new Livraria_Livrolândia.Dados.Book();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cATEGORIAS_LIVROSTableAdapter = new Livraria_Livrolândia.Dados.BookTableAdapters.CATEGORIAS_LIVROSTableAdapter();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASLIVROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book)).BeginInit();
            this.SuspendLayout();
            // 
            // lIVROBindingSource
            // 
            this.lIVROBindingSource.DataMember = "LIVRO";
            this.lIVROBindingSource.DataSource = this.lIVROSDataSetBindingSource;
            // 
            // lIVROSDataSetBindingSource
            // 
            this.lIVROSDataSetBindingSource.DataSource = this.lIVROSDataSet;
            this.lIVROSDataSetBindingSource.Position = 0;
            // 
            // lIVROSDataSet
            // 
            this.lIVROSDataSet.DataSetName = "LIVROSDataSet";
            this.lIVROSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "Teste";
            reportDataSource1.Value = this.lIVROBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Livraria_Livrolândia.Teste.Teste.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // lIVROTableAdapter
            // 
            this.lIVROTableAdapter.ClearBeforeFill = true;
            // 
            // lIVROBindingSource1
            // 
            this.lIVROBindingSource1.DataMember = "LIVRO";
            this.lIVROBindingSource1.DataSource = this.lIVROSDataSetBindingSource;
            // 
            // cmbNome
            // 
            this.cmbNome.DataSource = this.cATEGORIASLIVROSBindingSource;
            this.cmbNome.DisplayMember = "CATEGORIA";
            this.cmbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(42, 36);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(161, 21);
            this.cmbNome.TabIndex = 1;
            this.cmbNome.ValueMember = "CATEGORIA";
            // 
            // cATEGORIASLIVROSBindingSource
            // 
            this.cATEGORIASLIVROSBindingSource.DataMember = "CATEGORIAS_LIVROS";
            this.cATEGORIASLIVROSBindingSource.DataSource = this.book;
            // 
            // book
            // 
            this.book.DataSetName = "Book";
            this.book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar Por Categoria";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(224, 36);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cATEGORIAS_LIVROSTableAdapter
            // 
            this.cATEGORIAS_LIVROSTableAdapter.ClearBeforeFill = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(305, 36);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNome);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teste";
            this.Text = "Relatório com Filtro";
            this.Load += new System.EventHandler(this.Teste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASLIVROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LIVROSDataSet lIVROSDataSet;
        private System.Windows.Forms.BindingSource lIVROSDataSetBindingSource;
        private System.Windows.Forms.BindingSource lIVROBindingSource;
        private LIVROSDataSetTableAdapters.LIVROTableAdapter lIVROTableAdapter;
        private System.Windows.Forms.BindingSource lIVROBindingSource1;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private Dados.Book book;
        private System.Windows.Forms.BindingSource cATEGORIASLIVROSBindingSource;
        private Dados.BookTableAdapters.CATEGORIAS_LIVROSTableAdapter cATEGORIAS_LIVROSTableAdapter;
        private System.Windows.Forms.Button btnTodos;
    }
}