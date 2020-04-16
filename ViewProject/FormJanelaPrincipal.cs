using ControllerProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormJanelaPrincipal : Form
    {
        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutoController produtoController = new ProdutoController();
        private NotaEntradaController notaEntradaController = new NotaEntradaController();

        public FormJanelaPrincipal()
        {
            InitializeComponent();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor(fornecedorController).ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto(produtoController).ShowDialog();
        }

        private void notaDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNotaEntradaProdutos(notaEntradaController, fornecedorController, produtoController).ShowDialog();
        }
    }
}
