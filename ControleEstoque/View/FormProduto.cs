using ControleEstoque.Controller;
using ControleEstoque.Model;
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
    public partial class FormProduto : Form
    {
        ProdutoController produtoController = new ProdutoController();
        private Produto produtoAtual;
      
        public FormProduto()
        {
            InitializeComponent();
            produtoController.GetAllProdutos(dgvProdutos);
            ClearControls();
        }

        private void ClearControls()
        {
            txtIdProduto.Text = string.Empty;
            txtDescricaoProduto.Text = string.Empty;
            txtPrecoCusto.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            dgvProdutos.ClearSelection();
        }
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            this.produtoAtual = produtoController.GetProdutoById(Convert.ToInt64(dgvProdutos.Rows[e.RowIndex].Cells[0].Value));
            
            txtIdProduto.Text = this.produtoAtual.Id.ToString();
            txtDescricaoProduto.Text = this.produtoAtual.Descricao;
            txtPrecoVenda.Text = this.produtoAtual.PrecoDeVenda.ToString();
            txtPrecoCusto.Text = this.produtoAtual.PrecoDeCusto.ToString();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void btnGravarProduto_Click(object sender, EventArgs e)
        {
            produtoController.Save(new Produto()
            {
                Id = string.IsNullOrEmpty(txtIdProduto.Text) ? (long?)null : Convert.ToInt64(txtIdProduto.Text),
                Descricao = txtDescricaoProduto.Text,
                PrecoDeVenda = Convert.ToDouble(txtPrecoVenda.Text),
                PrecoDeCusto = Convert.ToDouble(txtPrecoCusto.Text)
            });
            produtoController.GetAllProdutos(dgvProdutos);
            ClearControls();
        }
        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (txtIdProduto.Text == null)
            {
                MessageBox.Show("Selecione o Produto que deseja remover!");
            }
            else
            {
                produtoController.Remove(this.produtoAtual.Id);
                MessageBox.Show("Produto removido com sucesso!");
            }
            produtoController.GetAllProdutos(dgvProdutos);
            ClearControls();
        }

    }
}
