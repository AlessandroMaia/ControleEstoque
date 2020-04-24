using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Model
{
    public class NotaEntrada
    {
        public long? Id { get; set; }
        public string Numero { get; set; }
        public Fornecedor FornecedorNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<ProdutoNotaEntrada> Produtos { get; set; }
       
        public NotaEntrada()
        {
            this.Id = null;
            this.Produtos = new List<ProdutoNotaEntrada>();
        }

        public override string ToString()
        {
            return this.FornecedorNota.Nome;
        }
    }
}
