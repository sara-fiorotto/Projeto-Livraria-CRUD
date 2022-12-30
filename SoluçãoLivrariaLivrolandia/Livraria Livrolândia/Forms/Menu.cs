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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GerarRelatóriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Forms.RelatorioGeral objCadPessoas = new Forms.RelatorioGeral();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();

        }

        private void ConsultarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ConsultarLivros objCadPessoas = new Forms.ConsultarLivros();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void RelatórioComFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teste.Teste objCadPessoas = new Teste.Teste();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();

        }

        private void cadastrarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Cadastro objCadPessoas = new Forms.Cadastro();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void relatórioAgrupadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.RelatorioAgrupado objCadPessoas = new Forms.RelatorioAgrupado();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();

        }

        private void relatórioInformaFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.RelatorioInforma objCadPessoas = new Forms.RelatorioInforma();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
