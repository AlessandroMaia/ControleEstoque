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
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller;
        private BindingSource dadosFornecedores = new BindingSource();


        public FormFornecedor(FornecedorController controller)
        {
            InitializeComponent();
            this.controller = controller;
            AtualizarDgv();
        }

        private void ClearControls()
        {
            dgvFornecedores.ClearSelection();
            txtIdFornecedor.Text = string.Empty;
            txtNomeFornecedor.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNomeFornecedor.Focus();
        }
        private void AtualizarDgv()
        {
            dadosFornecedores.DataSource = this.controller.GetAllFornecedor();
            dgvFornecedores.DataSource = dadosFornecedores;
        }

        private void btnGravarFornecedor_Click(object sender, EventArgs e)
        {
            if(txtIdFornecedor.Text == string.Empty)
            {
                var fornecedor = this.controller.InsertFornecedor( 
                    new Fornecedor()
                    {
                        Id = Guid.NewGuid(),
                        Nome = txtNomeFornecedor.Text,
                        CNPJ = txtCNPJ.Text
                    }
                );
                AtualizarDgv();
                ClearControls();
            }
            else
            {
                var fornecedor = this.controller.UpdateFornecedor(
                     new Fornecedor()
                     {
                         Id = new Guid(txtIdFornecedor.Text),
                         Nome = txtNomeFornecedor.Text,
                         CNPJ = txtCNPJ.Text
                     }
                );
                AtualizarDgv();
                ClearControls();
            }
            
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvFornecedores.SelectedRows.Count > 0)
            {
                txtIdFornecedor.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
                txtNomeFornecedor.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
                txtCNPJ.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnRemoverFornecedor_Click(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Selecione o FORNECEDOR a ser removido!");
            }
            else
            {
                this.controller.RemoverFornecedor(
                    new Fornecedor()
                    {
                        Id = new Guid(txtIdFornecedor.Text)
                    }
                );
                AtualizarDgv();
                ClearControls();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
