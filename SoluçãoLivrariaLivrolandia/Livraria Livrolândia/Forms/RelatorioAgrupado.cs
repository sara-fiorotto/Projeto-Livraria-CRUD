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
    public partial class RelatorioAgrupado : Form
    {
        public RelatorioAgrupado()
        {
            InitializeComponent();
        }

        private void RelatorioAgrupado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'book.LIVRO'. Você pode movê-la ou removê-la conforme necessário.
            this.lIVROTableAdapter.Fill(this.book.LIVRO);

            this.reportViewer1.RefreshReport();
        }
    }
}
