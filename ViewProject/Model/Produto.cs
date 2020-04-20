using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Model
{
    public class Produto
    {
        public Produto()
        {
            this.Id = null;
        }
        public long? Id { get; set; }
        public string Descricao { get; set; }
        public double PrecoDeCusto { get; set; }
        public double PrecoDeVenda { get; set; }
        public double Estoque { get; set; }

    }
}
