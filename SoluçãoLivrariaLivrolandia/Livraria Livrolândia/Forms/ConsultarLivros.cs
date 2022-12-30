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
    public partial class ConsultarLivros : Form
    {
        public ConsultarLivros()
        {
            InitializeComponent();

        }



        private void ConsultarLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lIVROSDataSet.LIVRO'. Você pode movê-la ou removê-la conforme necessário.
            this.lIVROTableAdapter.Fill(this.lIVROSDataSet.LIVRO);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.LIVROS'. Você pode movê-la ou removê-la conforme necessário.
            if (txtPesquisa.Text != "" && cmbProcurar.SelectedIndex != -1 && cmbColuna.SelectedIndex != -1)
            {
                BtnFiltrar.Enabled = true;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string vColuna, vProcurar, vFiltro, vTexto = "";

            vColuna = cmbColuna.Text;
            vProcurar = cmbProcurar.Text;
            vTexto = txtPesquisa.Text;

            vFiltro = vColuna;
           
            //Pesquisando com operadores, valores númericos 
            if (vProcurar == "Igual a")
            {
                vFiltro += " = '" + vTexto + "'";
            }

            else if (vProcurar == "Entre")
            {
                string ValorPesquisar = txtPesquisa2.Text;

                vFiltro += " >= "+ vTexto + " AND " + vColuna + " <= " + ValorPesquisar;
            }
           
            //Apenas strings, pesquisando com LIKE
            else if (vProcurar == "Começa com")
            {
                vFiltro += " like '" + vTexto + "%'";
            }

            else if (vProcurar == "Contem")
            {
                vFiltro += " like '%" + vTexto + "%'";
            }
            else if (vProcurar == "Termina com")
            {
                vFiltro += " like '%" + vTexto + "'";
            }
            else
            {
                vFiltro = "";
            }
            
            lIVROBindingSource.Filter = vFiltro;

        }

        private void CmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProcurar.Items.Clear();

            if (cmbColuna.Text == "PREÇO" || cmbColuna.Text =="ISBN" || cmbColuna.Text == "DATA")
            {
                cmbProcurar.Items.Add("Igual a");
                cmbProcurar.Items.Add("Entre");
                cmbProcurar.Items.Add("Todos");

            }
            else
            {
                cmbProcurar.Items.Add("Começa com");
                cmbProcurar.Items.Add("Contem");
                cmbProcurar.Items.Add("Todos");
                cmbProcurar.Items.Add("Termina com");
                cmbProcurar.Items.Add("Igual a");
            }
        }

        private void CmbProcurar_SelectedValueChanged(object sender, EventArgs e)
        {
            string vColuna, vProcurar, vFiltro, vTexto = "";

            vProcurar = cmbProcurar.Text;

            if (vProcurar == "Entre")
            {
                txtPesquisa2.Visible = true;
            }

            else
            {
                txtPesquisa2.Visible = false;
            }

            if (txtPesquisa.Text != "" && cmbProcurar.SelectedIndex != -1 && cmbColuna.SelectedIndex != -1)
            {
                BtnFiltrar.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa2.Visible = false;
            txtPesquisa.Text = "";
            cmbColuna.SelectedIndex = -1;
            cmbProcurar.SelectedIndex = -1;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "" && cmbProcurar.SelectedIndex != -1 && cmbColuna.SelectedIndex != -1)
            {
                BtnFiltrar.Enabled = true;
            }
            else
            {
                BtnFiltrar.Enabled = false;
            }
        }
    }
}
