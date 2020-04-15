using ModelProject;
using PersistenceProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerProject
{
    public class ProdutoController
    {
        private Repository<Produto> repository = new Repository<Produto>();

        public Produto InsertProduto(Produto produto)
        {
            return this.repository.Adicionar(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            this.repository.Remover(produto);
        }

        public IList<Produto> GetAllProduto()
        {
            return this.repository.GetAll();
        }

        public Produto UpdateProduto(Produto produto)
        {
            return this.repository.Update(produto);
        }
    }
}
