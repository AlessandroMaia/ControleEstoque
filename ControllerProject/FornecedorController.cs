using ModelProject;
using PersistenceProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerProject
{
    public class FornecedorController
    {
        private Repository<Fornecedor> repository = new Repository<Fornecedor>();

        public Fornecedor InsertFornecedor(Fornecedor fornecedor)
        {
            return this.repository.Adicionar(fornecedor);
        }

        public void RemoverFornecedor(Fornecedor fornecedor)
        {
            this.repository.Remover(fornecedor);
        }

        public IList<Fornecedor> GetAllFornecedor()
        {
            return this.repository.GetAll();
        }

        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            return this.repository.Update(fornecedor);
        }
    }
}
