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
    public partial class FormNotaEntradaProdutos : Form
    {
        private NotaEntradaController controller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;
        private NotaEntrada notaAtual;
        private BindingSource dadosNotaEntrada = new BindingSource();

        public FormNotaEntradaProdutos(NotaEntradaController controller, FornecedorController fornecedorController, ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicializarComboBox();
            AtualizarDataGridViewNota();
        }
        private void InicializarComboBox()
        {
            cmbFornecedor.Items.Clear();
            cmbProduto.Items.Clear();

            foreach (Produto produto in this.produtoController.GetAllProduto())
            {
                cmbProduto.Items.Add(produto);
            }

            foreach (Fornecedor fornecedor in this.fornecedorController.GetAllFornecedor())
            {
                cmbFornecedor.Items.Add(fornecedor);
            }
        }
        private void FormNotaEntradaProdutos_Shown(object sender, EventArgs e)
        {
            ChangeStatusOfControls(false);
        }
        
        
        private void ClearControlsNota()
        {
            txtIdNotaEntrada.Text = string.Empty;
            cmbFornecedor.SelectedIndex = -1;
            txtNumeroNotaEntrada.Text = string.Empty;
            dtpDataEmissao.Value = DateTime.Now;
            dtpDataEntrada.Value = DateTime.Now;
            dgvNotaEntrada.ClearSelection();
            cmbFornecedor.Focus();
        }
        private void ChangeStatusOfControls(bool newStatus)
        {
            cmbProduto.Enabled = newStatus;
            txtPrecoCustoProdutoNota.Enabled = newStatus;
            btnNovoProdutoComprado.Enabled = !newStatus;
            btnGravaProdutoComprado.Enabled = newStatus;
            btnCancelarPRodutoComprado.Enabled = newStatus;
            btnRemoverProdutoComprado.Enabled = newStatus;
        }


        private void AtualizarDataGridViewNota()
        {
            dadosNotaEntrada.DataSource = this.controller.GetAllNotaEntrada();
            dgvNotaEntrada.DataSource = dadosNotaEntrada;
        }


        private void dgvProdutoNotaEntrada_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void dgvNotaEntrada_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.GetNotaPorId((Guid)dgvNotaEntrada.CurrentRow.Cells[0].Value);
                txtIdNotaEntrada.Text = notaAtual.Id.ToString();
                cmbFornecedor.SelectedItem = notaAtual.FornecedorNota;
                txtNumeroNotaEntrada.Text = notaAtual.Numero;
                dtpDataEmissao.Value = notaAtual.DataEmissao;
                dtpDataEntrada.Value = notaAtual.DataEntrada;
            }
            catch (Exception)
            {
                this.notaAtual = new NotaEntrada();
            }
        }
        

        private void btnNovoNotaEntrada_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
            ChangeStatusOfControls(false);
        }
        private void btnCancelarNotaEntrada_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
            ChangeStatusOfControls(false);
        }
        private void btnGravarNotaEntrada_Click(object sender, EventArgs e)
        {
            var notaEntrada = new NotaEntrada()
            {
                Id = (txtIdNotaEntrada.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIdNotaEntrada.Text)),
                FornecedorNota = (Fornecedor) cmbFornecedor.SelectedItem,
                Numero = txtNumeroNotaEntrada.Text,
                DataEmissao = dtpDataEmissao.Value,
                DataEntrada = dtpDataEntrada.Value
            };
            notaEntrada = (txtIdNotaEntrada.Text == string.Empty ? this.controller.InsertNotaEntrada(notaEntrada) : this.controller.UpdateNotaEntrada(notaEntrada));
            AtualizarDataGridViewNota();
            ClearControlsNota();
            ChangeStatusOfControls(false);
        }
        private void btnRemoverNotaEntrada_Click(object sender, EventArgs e)
        {
            if (txtIdNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA DE ENTRADA que deseja remover!");
            }
            else
            {
                this.controller.RemoverNotaEntrada(new NotaEntrada()
                {
                    Id = new Guid(txtIdNotaEntrada.Text)

                });
                AtualizarDataGridViewNota();
                ClearControlsNota();
                ChangeStatusOfControls(false);
            }
        }


        private void btnNovoProdutoComprado_Click(object sender, EventArgs e)
        {
        }
        private void btnCancelarPRodutoComprado_Click(object sender, EventArgs e)
        {
        }
        private void btnGravaProdutoComprado_Click(object sender, EventArgs e)
        {

        }
        private void btnRemoverProdutoComprado_Click(object sender, EventArgs e)
        {
        }

    }
}
