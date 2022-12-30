using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Livrolândia.Teste
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'book.CATEGORIAS_LIVROS'. Você pode movê-la ou removê-la conforme necessário.
            this.cATEGORIAS_LIVROSTableAdapter.Fill(this.book.CATEGORIAS_LIVROS);
            // TODO: esta linha de código carrega dados na tabela 'lIVROSDataSet.LIVRO'. Você pode movê-la ou removê-la conforme necessário.
            this.lIVROTableAdapter.Fill(this.lIVROSDataSet.LIVRO);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

      

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CATEGORIA", cmbNome.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CATEGORIA", (string)null));
            this.reportViewer1.RefreshReport();

        }
    }
}
