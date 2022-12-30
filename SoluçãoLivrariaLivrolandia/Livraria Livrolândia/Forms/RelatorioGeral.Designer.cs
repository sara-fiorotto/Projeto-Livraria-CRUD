
namespace Livraria_Livrolândia.Forms
{
    partial class RelatorioGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioGeral));
            this.lIVROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIVROSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIVROSDataSet = new Livraria_Livrolândia.LIVROSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lIVROTableAdapter = new Livraria_Livrolândia.LIVROSDataSetTableAdapters.LIVROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSet)).BeginInit();
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
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Relatorio";
            reportDataSource1.Value = this.lIVROBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Livraria_Livrolândia.Relatorios.RelatorioLivro.rdlc";
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
            // RelatorioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioGeral";
            this.Text = "Relatorio Geral";
            this.Load += new System.EventHandler(this.RelatorioGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lIVROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lIVROSDataSetBindingSource;
        private LIVROSDataSet lIVROSDataSet;
        private System.Windows.Forms.BindingSource lIVROBindingSource;
        private LIVROSDataSetTableAdapters.LIVROTableAdapter lIVROTableAdapter;
    }
}