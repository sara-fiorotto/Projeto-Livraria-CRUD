using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Livrolândia.Forms
{
    public partial class RelatorioFiltro : Form
    {
        public string pCategoria;
        public RelatorioFiltro()
        {
            InitializeComponent();
        }

        private void RelatorioFiltro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'book.LIVRO'. Você pode movê-la ou removê-la conforme necessário.
            this.lIVROTableAdapter.Fill(this.book.LIVRO);

            this.reportViewer1.RefreshReport();


            if (pCategoria == (string)null)
            {
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CATEGORIA", (string)null));
            }
            else
            {
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CATEGORIA", pCategoria));
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
