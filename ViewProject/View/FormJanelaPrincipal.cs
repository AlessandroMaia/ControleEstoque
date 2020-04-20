using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.View
{
    public partial class FormJanelaPrincipal : Form
    {

        public FormJanelaPrincipal()
        {
            InitializeComponent();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor().ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
        }

        private void notaDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNotaEntradaProdutos().ShowDialog();
        }
    }
}
