namespace ViewProject
{
    partial class FormNotaEntradaProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdNotaEntrada = new System.Windows.Forms.TextBox();
            this.txtIdProdutoComprado = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumeroNotaEntrada = new System.Windows.Forms.TextBox();
            this.txtPrecoCustoProdutoNota = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnNovoNotaEntrada = new System.Windows.Forms.Button();
            this.btnGravarNotaEntrada = new System.Windows.Forms.Button();
            this.btnCancelarNotaEntrada = new System.Windows.Forms.Button();
            this.btnRemoverNotaEntrada = new System.Windows.Forms.Button();
            this.btnGravaProdutoComprado = new System.Windows.Forms.Button();
            this.btnCancelarPRodutoComprado = new System.Windows.Forms.Button();
            this.btnNovoProdutoComprado = new System.Windows.Forms.Button();
            this.btnRemoverProdutoComprado = new System.Windows.Forms.Button();
            this.dgvNotaEntrada = new System.Windows.Forms.DataGridView();
            this.dgvProdutoNotaEntrada = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoNotaEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIdNotaEntrada, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIdProdutoComprado, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbProduto, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFornecedor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtNumeroNotaEntrada, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecoCustoProdutoNota, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantidadeProduto, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDataEmissao, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDataEntrada, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNovoNotaEntrada, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGravarNotaEntrada, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarNotaEntrada, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoverNotaEntrada, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGravaProdutoComprado, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarPRodutoComprado, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnNovoProdutoComprado, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoverProdutoComprado, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.dgvNotaEntrada, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.dgvProdutoNotaEntrada, 5, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corpo da Nota";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 4);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produtos comprados";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fornecedor:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Produto:";
            // 
            // txtIdNotaEntrada
            // 
            this.txtIdNotaEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtIdNotaEntrada, 3);
            this.txtIdNotaEntrada.Enabled = false;
            this.txtIdNotaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdNotaEntrada.Location = new System.Drawing.Point(141, 34);
            this.txtIdNotaEntrada.Name = "txtIdNotaEntrada";
            this.txtIdNotaEntrada.Size = new System.Drawing.Size(408, 23);
            this.txtIdNotaEntrada.TabIndex = 6;
            // 
            // txtIdProdutoComprado
            // 
            this.txtIdProdutoComprado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtIdProdutoComprado, 3);
            this.txtIdProdutoComprado.Enabled = false;
            this.txtIdProdutoComprado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProdutoComprado.Location = new System.Drawing.Point(733, 34);
            this.txtIdProdutoComprado.Name = "txtIdProdutoComprado";
            this.txtIdProdutoComprado.Size = new System.Drawing.Size(412, 23);
            this.txtIdProdutoComprado.TabIndex = 8;
            // 
            // cmbProduto
            // 
            this.cmbProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.cmbProduto, 3);
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(733, 63);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(412, 24);
            this.cmbProduto.TabIndex = 9;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.cmbFornecedor, 3);
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(141, 63);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(408, 24);
            this.cmbFornecedor.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Número:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Custo:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Emissão:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(595, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Quantidade:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(316, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Entrada:";
            // 
            // txtNumeroNotaEntrada
            // 
            this.txtNumeroNotaEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtNumeroNotaEntrada, 3);
            this.txtNumeroNotaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroNotaEntrada.Location = new System.Drawing.Point(141, 93);
            this.txtNumeroNotaEntrada.Name = "txtNumeroNotaEntrada";
            this.txtNumeroNotaEntrada.Size = new System.Drawing.Size(408, 23);
            this.txtNumeroNotaEntrada.TabIndex = 17;
            // 
            // txtPrecoCustoProdutoNota
            // 
            this.txtPrecoCustoProdutoNota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtPrecoCustoProdutoNota, 3);
            this.txtPrecoCustoProdutoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCustoProdutoNota.Location = new System.Drawing.Point(733, 93);
            this.txtPrecoCustoProdutoNota.Name = "txtPrecoCustoProdutoNota";
            this.txtPrecoCustoProdutoNota.Size = new System.Drawing.Size(412, 23);
            this.txtPrecoCustoProdutoNota.TabIndex = 18;
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtQuantidadeProduto, 3);
            this.txtQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(733, 122);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(412, 23);
            this.txtQuantidadeProduto.TabIndex = 19;
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissao.Location = new System.Drawing.Point(141, 122);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(132, 23);
            this.dtpDataEmissao.TabIndex = 20;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(417, 122);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(132, 23);
            this.dtpDataEntrada.TabIndex = 21;
            // 
            // btnNovoNotaEntrada
            // 
            this.btnNovoNotaEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoNotaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoNotaEntrada.Location = new System.Drawing.Point(8, 158);
            this.btnNovoNotaEntrada.Name = "btnNovoNotaEntrada";
            this.btnNovoNotaEntrada.Size = new System.Drawing.Size(122, 30);
            this.btnNovoNotaEntrada.TabIndex = 22;
            this.btnNovoNotaEntrada.Text = "Novo";
            this.btnNovoNotaEntrada.UseVisualStyleBackColor = true;
            this.btnNovoNotaEntrada.Click += new System.EventHandler(this.btnNovoNotaEntrada_Click);
            // 
            // btnGravarNotaEntrada
            // 
            this.btnGravarNotaEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravarNotaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGravarNotaEntrada.Location = new System.Drawing.Point(146, 158);
            this.btnGravarNotaEntrada.Name = "btnGravarNotaEntrada";
            this.btnGravarNotaEntrada.Size = new System.Drawing.Size(122, 30);
            this.btnGravarNotaEntrada.TabIndex = 23;
            this.btnGravarNotaEntrada.Text = "Gravar";
            this.btnGravarNotaEntrada.UseVisualStyleBackColor = true;
            this.btnGravarNotaEntrada.Click += new System.EventHandler(this.btnGravarNotaEntrada_Click);
            // 
            // btnCancelarNotaEntrada
            // 
            this.btnCancelarNotaEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarNotaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarNotaEntrada.Location = new System.Drawing.Point(284, 158);
            this.btnCancelarNotaEntrada.Name = "btnCancelarNotaEntrada";
            this.btnCancelarNotaEntrada.Size = new System.Drawing.Size(122, 30);
            this.btnCancelarNotaEntrada.TabIndex = 24;
            this.btnCancelarNotaEntrada.Text = "Cancelar";
            this.btnCancelarNotaEntrada.UseVisualStyleBackColor = true;
            this.btnCancelarNotaEntrada.Click += new System.EventHandler(this.btnCancelarNotaEntrada_Click);
            // 
            // btnRemoverNotaEntrada
            // 
            this.btnRemoverNotaEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoverNotaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoverNotaEntrada.Location = new System.Drawing.Point(422, 158);
            this.btnRemoverNotaEntrada.Name = "btnRemoverNotaEntrada";
            this.btnRemoverNotaEntrada.Size = new System.Drawing.Size(122, 30);
            this.btnRemoverNotaEntrada.TabIndex = 25;
            this.btnRemoverNotaEntrada.Text = "Remover";
            this.btnRemoverNotaEntrada.UseVisualStyleBackColor = true;
            this.btnRemoverNotaEntrada.Click += new System.EventHandler(this.btnRemoverNotaEntrada_Click);
            // 
            // btnGravaProdutoComprado
            // 
            this.btnGravaProdutoComprado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravaProdutoComprado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGravaProdutoComprado.Location = new System.Drawing.Point(738, 158);
            this.btnGravaProdutoComprado.Name = "btnGravaProdutoComprado";
            this.btnGravaProdutoComprado.Size = new System.Drawing.Size(122, 30);
            this.btnGravaProdutoComprado.TabIndex = 26;
            this.btnGravaProdutoComprado.Text = "Gravar";
            this.btnGravaProdutoComprado.UseVisualStyleBackColor = true;
            this.btnGravaProdutoComprado.Click += new System.EventHandler(this.btnGravaProdutoComprado_Click);
            // 
            // btnCancelarPRodutoComprado
            // 
            this.btnCancelarPRodutoComprado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarPRodutoComprado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarPRodutoComprado.Location = new System.Drawing.Point(876, 158);
            this.btnCancelarPRodutoComprado.Name = "btnCancelarPRodutoComprado";
            this.btnCancelarPRodutoComprado.Size = new System.Drawing.Size(122, 30);
            this.btnCancelarPRodutoComprado.TabIndex = 27;
            this.btnCancelarPRodutoComprado.Text = "Cancelar";
            this.btnCancelarPRodutoComprado.UseVisualStyleBackColor = true;
            this.btnCancelarPRodutoComprado.Click += new System.EventHandler(this.btnCancelarPRodutoComprado_Click);
            // 
            // btnNovoProdutoComprado
            // 
            this.btnNovoProdutoComprado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoProdutoComprado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovoProdutoComprado.Location = new System.Drawing.Point(600, 158);
            this.btnNovoProdutoComprado.Name = "btnNovoProdutoComprado";
            this.btnNovoProdutoComprado.Size = new System.Drawing.Size(122, 30);
            this.btnNovoProdutoComprado.TabIndex = 28;
            this.btnNovoProdutoComprado.Text = "Novo";
            this.btnNovoProdutoComprado.UseVisualStyleBackColor = true;
            this.btnNovoProdutoComprado.Click += new System.EventHandler(this.btnNovoProdutoComprado_Click);
            // 
            // btnRemoverProdutoComprado
            // 
            this.btnRemoverProdutoComprado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoverProdutoComprado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoverProdutoComprado.Location = new System.Drawing.Point(1016, 158);
            this.btnRemoverProdutoComprado.Name = "btnRemoverProdutoComprado";
            this.btnRemoverProdutoComprado.Size = new System.Drawing.Size(122, 30);
            this.btnRemoverProdutoComprado.TabIndex = 29;
            this.btnRemoverProdutoComprado.Text = "Remover";
            this.btnRemoverProdutoComprado.UseVisualStyleBackColor = true;
            this.btnRemoverProdutoComprado.Click += new System.EventHandler(this.btnRemoverProdutoComprado_Click);
            // 
            // dgvNotaEntrada
            // 
            this.dgvNotaEntrada.AllowUserToAddRows = false;
            this.dgvNotaEntrada.AllowUserToDeleteRows = false;
            this.dgvNotaEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvNotaEntrada, 4);
            this.dgvNotaEntrada.Location = new System.Drawing.Point(3, 202);
            this.dgvNotaEntrada.Name = "dgvNotaEntrada";
            this.dgvNotaEntrada.ReadOnly = true;
            this.dgvNotaEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotaEntrada.Size = new System.Drawing.Size(546, 199);
            this.dgvNotaEntrada.TabIndex = 30;
            this.dgvNotaEntrada.SelectionChanged += new System.EventHandler(this.dgvNotaEntrada_SelectionChanged);
            // 
            // dgvProdutoNotaEntrada
            // 
            this.dgvProdutoNotaEntrada.AllowUserToAddRows = false;
            this.dgvProdutoNotaEntrada.AllowUserToDeleteRows = false;
            this.dgvProdutoNotaEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvProdutoNotaEntrada, 4);
            this.dgvProdutoNotaEntrada.Location = new System.Drawing.Point(595, 202);
            this.dgvProdutoNotaEntrada.Name = "dgvProdutoNotaEntrada";
            this.dgvProdutoNotaEntrada.ReadOnly = true;
            this.dgvProdutoNotaEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutoNotaEntrada.Size = new System.Drawing.Size(550, 199);
            this.dgvProdutoNotaEntrada.TabIndex = 31;
            this.dgvProdutoNotaEntrada.SelectionChanged += new System.EventHandler(this.dgvProdutoNotaEntrada_SelectionChanged);
            // 
            // FormNotaEntradaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormNotaEntradaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNotaEntradaProdutos";
            this.Shown += new System.EventHandler(this.FormNotaEntradaProdutos_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoNotaEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdNotaEntrada;
        private System.Windows.Forms.TextBox txtIdProdutoComprado;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumeroNotaEntrada;
        private System.Windows.Forms.TextBox txtPrecoCustoProdutoNota;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Button btnNovoNotaEntrada;
        private System.Windows.Forms.Button btnGravarNotaEntrada;
        private System.Windows.Forms.Button btnCancelarNotaEntrada;
        private System.Windows.Forms.Button btnRemoverNotaEntrada;
        private System.Windows.Forms.Button btnGravaProdutoComprado;
        private System.Windows.Forms.Button btnCancelarPRodutoComprado;
        private System.Windows.Forms.Button btnNovoProdutoComprado;
        private System.Windows.Forms.Button btnRemoverProdutoComprado;
        private System.Windows.Forms.DataGridView dgvNotaEntrada;
        private System.Windows.Forms.DataGridView dgvProdutoNotaEntrada;
    }
}