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

        private void ChangeStatusControlsFornecedor(bool status)
        {
            btnNovoFornecedor.Enabled = !status;
            btnGravarFornecedor.Enabled = status;
            btnCancelar.Enabled = status;
            btnRemoverFornecedor.Enabled = false;

            txtNomeFornecedor.Enabled = status;
            txtCNPJ.Enabled = status;

            if (fornecedorAtual != null)
            {
                btnRemoverFornecedor.Enabled = status;
            }
        }
        private bool ValidaCampos()
        {
            if(txtNomeFornecedor.Text == string.Empty || txtNomeFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo NOME!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeFornecedor.Focus();
                return false;
            }
            else if (txtCNPJ.Text == string.Empty || txtCNPJ.Text.Length <= 17)
            {
                MessageBox.Show("Preencha o campo CNPJ corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCNPJ.Focus();
                return false;
            }

            return true;
        }
        private void ClearControls()
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
            ChangeStatusControlsFornecedor(true);
        }
  
        private void btnGravarFornecedor_Click(object sender, EventArgs e)
        {
            if(ValidaCampos() == true)
            {
                fornecedorController.Save(new Fornecedor()
                {
                    Id = string.IsNullOrEmpty(txtIdFornecedor.Text) ? (long?)null : Convert.ToInt64(txtIdFornecedor.Text),
                    Nome = txtNomeFornecedor.Text,
                    CNPJ = txtCNPJ.Text //.Trim().Replace(",", "").Replace("/", "").Replace("-", "")
                });
                fornecedorController.GetAllFornecedores(dgvFornecedores);
                ClearControls();
                ChangeStatusControlsFornecedor(false);
            } 
        }
        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            ClearControls();
            ChangeStatusControlsFornecedor(true);
        }
        private void btnRemoverFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdFornecedor.Text == string.Empty)
                {
                    MessageBox.Show("Selecione o Fornecedor que deseja remover!");
                }
                else
                {
                    fornecedorController.Remove(this.fornecedorAtual.Id);
                    fornecedorController.GetAllFornecedores(dgvFornecedores);
                    ClearControls();
                    ChangeStatusControlsFornecedor(false);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não é possivel excluir fornecedor que está associado a uma nota de entrada!");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
            fornecedorAtual = null;
            ChangeStatusControlsFornecedor(false);
        }

        private void FormFornecedor_Shown(object sender, EventArgs e)
        {
            ChangeStatusControlsFornecedor(false);
        }
    }
}
