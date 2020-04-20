using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Model
{
    public class Fornecedor
    {
        public Fornecedor()
        {
             this.Id = null;
        }

        public long? Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

    }
}
