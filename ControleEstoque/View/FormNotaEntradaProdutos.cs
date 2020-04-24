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
    public partial class FormNotaEntradaProdutos : Form
    {
        private NotaEntradaController notaEntradaController = new NotaEntradaController();
        private ProdutoController produtoController = new ProdutoController();
        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutosNotaEntradaController produtosNotaEntradaController = new ProdutosNotaEntradaController();
        private NotaEntrada notaAtual;
        private ProdutoNotaEntrada produtoNotaAtual;

        public FormNotaEntradaProdutos()
        {
            InitializeComponent();
            InitializeComboBoxs();
            notaEntradaController.GetAllNotaEntrada(dgvNotaEntrada);     
        }

        private void InitializeComboBoxs()
        {
            cmbFornecedor.Items.Clear();
            cmbProduto.Items.Clear();
            foreach (Fornecedor fornecedor in this.fornecedorController.GetAllAsIList())
            {
                cmbFornecedor.Items.Add(fornecedor);
            }
            foreach (Produto produto in this.produtoController.GetAllAsIList())
            {
                cmbProduto.Items.Add(produto);
            }
        }

        private void ClearControls()
        {
            txtIdNotaEntrada.Text = string.Empty;
            cmbFornecedor.SelectedIndex = -1;
            txtNumeroNotaEntrada.Text = string.Empty;
            dtpDataEmissao.Value = DateTime.Now;
            dtpDataEntrada.Value = DateTime.Now;
            dgvNotaEntrada.ClearSelection();
            notaAtual = null;
            ClearControlsProdutoNota();
            dgvProdutoNotaEntrada.DataSource = null;

        }
        private void ClearControlsProdutoNota()
        {

            txtIdProdutoComprado.Text = string.Empty;
            cmbProduto.SelectedIndex = -1;
            txtPrecoCustoProdutoNota.Text = string.Empty;
            txtQuantidadeProduto.Text = string.Empty;
            dgvProdutoNotaEntrada.ClearSelection();
            produtoNotaAtual = null;
        }

        private void ChangeStatusControlsNovaNotaDeEntrada(bool status)
        {
            btnNovoNotaEntrada.Enabled = !status;
            btnGravarNotaEntrada.Enabled = status;
            btnCancelarNotaEntrada.Enabled = status;
            btnRemoverNotaEntrada.Enabled = false;
            btnNovoProdutoComprado.Enabled = false;
            btnGravaProdutoComprado.Enabled = false;
            btnCancelarPRodutoComprado.Enabled = false;
            btnRemoverProdutoComprado.Enabled = false;

            cmbProduto.Enabled = false;
            txtPrecoCustoProdutoNota.Enabled = false;
            txtQuantidadeProduto.Enabled = false;

            cmbFornecedor.Enabled = status;
            txtNumeroNotaEntrada.Enabled = status;
            dtpDataEmissao.Enabled = status;
            dtpDataEntrada.Enabled = status;

            if (notaAtual != null)
            {
                btnRemoverNotaEntrada.Enabled = status;
                btnNovoProdutoComprado.Enabled = status;
            }

        }
        private void ChangeStatusControlsProdutoNotaDeEntrada(bool status)
        {
            cmbProduto.Enabled = status;
            txtPrecoCustoProdutoNota.Enabled = status;
            txtQuantidadeProduto.Enabled = status;

            btnNovoProdutoComprado.Enabled = !status;
            btnGravaProdutoComprado.Enabled = status;
            btnCancelarPRodutoComprado.Enabled = status;
            btnRemoverProdutoComprado.Enabled = false;
            if (produtoNotaAtual != null)
            {
                btnRemoverProdutoComprado.Enabled = status;
            }
        }

        private bool ValidaCamposNota()
        {
            if (cmbFornecedor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o fornecedor!");
                cmbFornecedor.Focus();
                return false;
            }
            else if (txtNumeroNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Digite o número da nota de entrada!");
                txtNumeroNotaEntrada.Focus();
                return false;
            }
            return true;
        }

        private bool ValidaCamposProdutoNota()
        {
            double.TryParse(txtPrecoCustoProdutoNota.Text, out var s);
            double.TryParse(txtQuantidadeProduto.Text, out var a);
            if (cmbProduto.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o produto que deseja inserir na nota!");
                cmbProduto.Focus();
                return false;
            }
            else if (txtPrecoCustoProdutoNota.Text == string.Empty || s == 0)
            {
                MessageBox.Show("Preencha o Preço de custo corretamente");
                txtPrecoCustoProdutoNota.Focus();
                return false;
            }
            else if (txtQuantidadeProduto.Text == string.Empty ||  a == 0)
            {
                MessageBox.Show("Preencha a quantidade corretamente!");
                txtQuantidadeProduto.Focus();
                return false;
            }
            return true;
        }

        private void AtualizarProdutoNotaEntradaDataGridView()
        {
            produtosNotaEntradaController.GetAllprodutoNotaEntrada(notaAtual.Id, dgvProdutoNotaEntrada);
            
        }

        private void btnNovoNotaEntrada_Click(object sender, EventArgs e)
        {
            ClearControls();
            ChangeStatusControlsNovaNotaDeEntrada(true);
        }
        private void btnCancelarNotaEntrada_Click(object sender, EventArgs e)
        {
            ClearControls();
            ChangeStatusControlsNovaNotaDeEntrada(false);
        }
        private void btnGravarNotaEntrada_Click(object sender, EventArgs e)
        {
            if (ValidaCamposNota() == true)
            {
                notaEntradaController.Save(new NotaEntrada() 
                { 
                    Id = string.IsNullOrEmpty(txtIdNotaEntrada.Text) ? (long?) null : Convert.ToInt64(txtIdNotaEntrada.Text),
                    FornecedorNota = (Fornecedor) cmbFornecedor.SelectedItem,
                    Numero = txtNumeroNotaEntrada.Text,
                    DataEmissao = Convert.ToDateTime(dtpDataEmissao.Value),
                    DataEntrada = Convert.ToDateTime(dtpDataEntrada.Value)
                });
                notaEntradaController.GetAllNotaEntrada(dgvNotaEntrada);
                ChangeStatusControlsNovaNotaDeEntrada(false);
                ClearControls();
            }
        } 
        private void btnRemoverNotaEntrada_Click(object sender, EventArgs e)
        {
            if (txtIdNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a Nota que Deseja Remover");
            }
            else
            {
                produtosNotaEntradaController.RemoveAllProdutosPorNota(this.notaAtual.Id);
                notaEntradaController.Remove(this.notaAtual.Id);
                notaEntradaController.GetAllNotaEntrada(dgvNotaEntrada);
                ChangeStatusControlsNovaNotaDeEntrada(false);
                ClearControls();
                MessageBox.Show("Nota removida com sucesso!");
            }
        }

        private void btnNovoProdutoComprado_Click(object sender, EventArgs e)
        {
            ClearControlsProdutoNota();
            ChangeStatusControlsProdutoNotaDeEntrada(true);
        }
        private void btnCancelarPRodutoComprado_Click(object sender, EventArgs e)
        {
            ClearControlsProdutoNota();
            ChangeStatusControlsProdutoNotaDeEntrada(false);
        }
        private void btnGravaProdutoComprado_Click(object sender, EventArgs e)
        {
            if (ValidaCamposProdutoNota() == true)
            {
                produtosNotaEntradaController.Save(
                    new NotaEntrada()
                    {
                        Id = string.IsNullOrEmpty(txtIdNotaEntrada.Text) ? (long?)null : Convert.ToInt64(txtIdNotaEntrada.Text)
                    },
                    new ProdutoNotaEntrada()
                    {
                        Id = string.IsNullOrEmpty(txtIdProdutoComprado.Text) ? (long?)null : Convert.ToInt64(txtIdProdutoComprado.Text),
                        ProdutoNota = (Produto)cmbProduto.SelectedItem,
                        NotaEntrada = notaAtual,
                        PrecoCustoCompra = Convert.ToDouble(txtPrecoCustoProdutoNota.Text),
                        QuantidadeComprada = Convert.ToDouble(txtQuantidadeProduto.Text)
                    });
                ClearControlsProdutoNota();
                ChangeStatusControlsProdutoNotaDeEntrada(false);
                produtosNotaEntradaController.GetAllprodutoNotaEntrada(notaAtual.Id, dgvProdutoNotaEntrada);
            }
        }
        private void btnRemoverProdutoComprado_Click(object sender, EventArgs e)
        {
            if (txtIdProdutoComprado.Text == string.Empty)
            {
                MessageBox.Show("Selecione o Produto que Deseja Remover");
            }
            else
            {
                produtosNotaEntradaController.Remove(this.produtoNotaAtual.Id);
                AtualizarProdutoNotaEntradaDataGridView();
                ClearControlsProdutoNota();
                ChangeStatusControlsProdutoNotaDeEntrada(false);
            }
        }

        private void FormNotaEntradaProdutos_Shown(object sender, EventArgs e)
        {
            ChangeStatusControlsNovaNotaDeEntrada(false);
        }
        private void dgvNotaEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            this.notaAtual = notaEntradaController.GetNotaEntradabyId(Convert.ToInt64(dgvNotaEntrada.Rows[e.RowIndex].Cells[0].Value));
            txtIdNotaEntrada.Text = notaAtual.Id.ToString();
            cmbFornecedor.SelectedItem = notaAtual.FornecedorNota;
            txtNumeroNotaEntrada.Text = notaAtual.Numero;
            dtpDataEmissao.Value = notaAtual.DataEmissao;
            dtpDataEntrada.Value = notaAtual.DataEntrada;
            ChangeStatusControlsNovaNotaDeEntrada(true);
            AtualizarProdutoNotaEntradaDataGridView();
        }
        private void dgvProdutoNotaEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            this.produtoNotaAtual = produtosNotaEntradaController.GetProdutoNotaEntradaById(Convert.ToInt64(dgvProdutoNotaEntrada.Rows[e.RowIndex].Cells[0].Value));
            txtIdProdutoComprado.Text = produtoNotaAtual.Id.ToString();
            cmbProduto.SelectedItem = produtoNotaAtual.ProdutoNota;
            txtPrecoCustoProdutoNota.Text = produtoNotaAtual.PrecoCustoCompra.ToString();
            txtQuantidadeProduto.Text = produtoNotaAtual.QuantidadeComprada.ToString();
            ChangeStatusControlsProdutoNotaDeEntrada(true);
        }
    }
}
