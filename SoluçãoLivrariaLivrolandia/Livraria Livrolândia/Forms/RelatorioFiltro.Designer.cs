
namespace Livraria_Livrolândia.Forms
{
    partial class RelatorioFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioFiltro));
            this.lIVROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book = new Livraria_Livrolândia.Dados.Book();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lIVROTableAdapter = new Livraria_Livrolândia.Dados.BookTableAdapters.LIVROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book)).BeginInit();
            this.SuspendLayout();
            // 
            // lIVROBindingSource
            // 
            this.lIVROBindingSource.DataMember = "LIVRO";
            this.lIVROBindingSource.DataSource = this.book;
            // 
            // book
            // 
            this.book.DataSetName = "Book";
            this.book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Teste";
            reportDataSource1.Value = this.lIVROBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Livraria_Livrolândia.Teste.Teste.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // lIVROTableAdapter
            // 
            this.lIVROTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioFiltro";
            this.Text = "Relatorio Com Filtro";
            this.Load += new System.EventHandler(this.RelatorioFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.Book book;
        private System.Windows.Forms.BindingSource lIVROBindingSource;
        private Dados.BookTableAdapters.LIVROTableAdapter lIVROTableAdapter;
    }
}