using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Model
{
    public class ProdutoNotaEntrada
    {
        public long? Id { get; set; }
        public Produto ProdutoNota { get; set; }
        public double PrecoCustoCompra { get; set; }
        public double QuantidadeComprada { get; set; }
    }
}
