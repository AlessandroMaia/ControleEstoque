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

        private void ChangeStatusControlsProduto(bool status)
        {
            btnNovoProduto.Enabled = !status;
            btnGravarProduto.Enabled = status;
            btnCancelarProduto.Enabled = status;
            btnRemoverProduto.Enabled = false;

            txtDescricaoProduto.Enabled = status;
            txtPrecoCusto.Enabled = status;
            txtPrecoVenda.Enabled = status;
            if (produtoAtual != null)
            {
                btnRemoverProduto.Enabled = status;
            }
        }
        private bool ValidaCampos()
        {
            if(txtDescricaoProduto.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescricaoProduto.Focus();
                return false;
            }
            else if (txtPrecoVenda.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Preço de venda!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecoVenda.Focus();
                return false;
            }
            else if (txtPrecoCusto.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Preço de custo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecoCusto.Focus();
                return false;
            }
            return true;
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
            ChangeStatusControlsProduto(true);
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ClearControls();
            ChangeStatusControlsProduto(true);
        }
        private void btnGravarProduto_Click(object sender, EventArgs e)
        {
            if (ValidaCampos() == true)
            {
                produtoController.Save(new Produto()
                {
                    Id = string.IsNullOrEmpty(txtIdProduto.Text) ? (long?)null : Convert.ToInt64(txtIdProduto.Text),
                    Descricao = txtDescricaoProduto.Text,
                    PrecoDeVenda = Convert.ToDouble(txtPrecoVenda.Text),
                    PrecoDeCusto = Convert.ToDouble(txtPrecoCusto.Text)
                });
                produtoController.GetAllProdutos(dgvProdutos);
                ChangeStatusControlsProduto(false);
                ClearControls();
            }
        }
        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            ClearControls();
            produtoAtual = null;
            ChangeStatusControlsProduto(false);
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
                produtoController.GetAllProdutos(dgvProdutos);
                ClearControls();
                ChangeStatusControlsProduto(false);
            }
        }
        private void FormProduto_Shown(object sender, EventArgs e)
        {
            ChangeStatusControlsProduto(false);
        }
    }
}
