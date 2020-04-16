using System;
using System.Collections.Generic;
using System.Text;

namespace ModelProject
{
    public class NotaEntrada
    {

        public Guid Id { get; set; }
        public string Numero { get; set; }
        public Fornecedor FornecedorNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<ProdutoNotaEntrada> Produtos { get; set; }
        
        public NotaEntrada()
        {
            this.Produtos = new List<ProdutoNotaEntrada>();
        }


        public void RemoverProduto(ProdutoNotaEntrada produto)
        {
            this.Produtos.Remove(produto);
        }

        public void RemoverTodosProdutos()
        {
            this.Produtos.Clear();
        }

        public void RegistrarProdutos(ProdutoNotaEntrada produto)
        {
            if (this.Produtos.Contains(produto))
            {
                this.Produtos.Remove(produto);
            }
            this.Produtos.Add(produto);
        }

        public bool Equals(NotaEntrada other)
        {
            return Id.Equals(other.Id);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(NotaEntrada)) return false;

            return Equals((NotaEntrada)obj);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
