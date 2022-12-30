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
    public partial class RelatorioGeral : Form
    {
        public string pCategoria;
        public RelatorioGeral()
        {
            InitializeComponent();
        }

        private void RelatorioGeral_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lIVROSDataSet.LIVRO'. Você pode movê-la ou removê-la conforme necessário.
            this.lIVROTableAdapter.Fill(this.lIVROSDataSet.LIVRO);

            this.reportViewer1.RefreshReport();
        }
    }
}
