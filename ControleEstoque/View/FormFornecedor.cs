using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using ControleEstoque.Controller;
using ControleEstoque.Model;

namespace ControleEstoque.View
{
    public partial class FormFornecedor : Form
    {
        FornecedorController fornecedorController = new FornecedorController();
        private Fornecedor fornecedorAtual;

        public FormFornecedor()
        {
            InitializeComponent();
            fornecedorController.GetAllFornecedores(dgvFornecedores);
        }

        public void ClearControls()
        {
            txtIdFornecedor.Text = string.Empty;
            txtNomeFornecedor.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            fornecedorController.GetAllFornecedores(dgvFornecedores);
            dgvFornecedores.ClearSelection();
            this.fornecedorAtual = null;
            txtNomeFornecedor.Focus();
        }
        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            this.fornecedorAtual = fornecedorController.GetFornecedorById(Convert.ToInt64(dgvFornecedores.Rows[e.RowIndex].Cells[0].Value));
            txtIdFornecedor.Text = this.fornecedorAtual.Id.ToString();
            txtCNPJ.Text = this.fornecedorAtual.CNPJ;
            txtNomeFornecedor.Text = this.fornecedorAtual.Nome;
        }
       
        private void btnGravarFornecedor_Click(object sender, EventArgs e)
        {
            fornecedorController.Save(new Fornecedor()
            {
                Id = string.IsNullOrEmpty(txtIdFornecedor.Text) ? (long?) null : Convert.ToInt64(txtIdFornecedor.Text),
                Nome = txtNomeFornecedor.Text,
                CNPJ = txtCNPJ.Text
            });
            fornecedorController.GetAllFornecedores(dgvFornecedores);
        }
        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void btnRemoverFornecedor_Click(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Selecione o Fornecedor que deseja remover!");
            }
            else
            {
                fornecedorController.Remove(this.fornecedorAtual.Id);
                MessageBox.Show("Fornecedor removido com sucesso!");
            }
            fornecedorController.GetAllFornecedores(dgvFornecedores);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
