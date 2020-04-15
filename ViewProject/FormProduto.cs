using ControllerProject;
using ModelProject;
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
    public partial class FormProduto : Form
    {
        private ProdutoController controller;
        private BindingSource dadosProdutos = new BindingSource();
        
        public FormProduto(ProdutoController controller)
        {
            InitializeComponent();
            this.controller = controller;
            AtualizaDataGridView();
            ClearControls();
        }

        private void ClearControls()
        {
            dgvProdutos.ClearSelection();
            txtIdProduto.Text = string.Empty;
            txtDescricaoProduto.Text = string.Empty;
            txtPrecoCusto.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtDescricaoProduto.Focus();
        }
        private void AtualizaDataGridView()
        {
            dadosProdutos.DataSource = this.controller.GetAllProduto();
            dgvProdutos.DataSource = dadosProdutos;
        }
        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                txtIdProduto.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                txtDescricaoProduto.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                txtPrecoCusto.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                txtPrecoVenda.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void btnGravarProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                Id = (txtIdProduto.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIdProduto.Text)),
                Descricao = txtDescricaoProduto.Text,
                PrecoDeCusto = Convert.ToDouble(txtPrecoCusto.Text),
                PrecoDeVenda = Convert.ToDouble(txtPrecoVenda.Text),
                Estoque = 0
            };

            produto = (txtIdProduto.Text == string.Empty ? this.controller.InsertProduto(produto) : this.controller.UpdateProduto(produto));

            AtualizaDataGridView();
            ClearControls();

        }
        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (txtIdProduto.Text == string.Empty)
            {
                MessageBox.Show("Selecione o PRODUTO a ser removido!");
            }
            else
            {
                this.controller.RemoverProduto(
                    new Produto() 
                    { 
                        Id = new Guid(txtIdProduto.Text)
                    }
                );
                AtualizaDataGridView();
                ClearControls();
            } 
        }

        private void FormProduto_Shown(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
