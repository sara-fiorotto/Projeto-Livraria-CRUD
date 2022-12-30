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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void lIVROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lIVROBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lIVROSDataSet);

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lIVROSDataSet.LIVRO'. Você pode movê-la ou removê-la conforme necessário.
            this.lIVROTableAdapter.Fill(this.lIVROSDataSet.LIVRO);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Exclusão?", "Excluindo Registro..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                lIVROBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.lIVROSDataSet);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
