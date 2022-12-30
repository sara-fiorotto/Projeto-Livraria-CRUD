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
    public partial class RelatorioInforma : Form
    {
        public RelatorioInforma()
        {
            InitializeComponent();
        }

        private void RelatorioInforma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'book.CATEGORIAS_LIVROS'. Você pode movê-la ou removê-la conforme necessário.
            this.cATEGORIAS_LIVROSTableAdapter.Fill(this.book.CATEGORIAS_LIVROS);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            RelatorioFiltro objVizualiza = new RelatorioFiltro();
            objVizualiza.pCategoria = cmbNome.Text;
            objVizualiza.Show();

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            RelatorioFiltro objVizualiza = new RelatorioFiltro();
            objVizualiza.pCategoria = (string)null ;
            objVizualiza.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNome.SelectedIndex != -1)
            {
                btnFiltrar.Enabled = true;
            }
        }
    }
}
