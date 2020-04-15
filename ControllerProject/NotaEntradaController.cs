using ModelProject;
using PersistenceProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerProject
{
    public class NotaEntradaController
    {
        private Repository<NotaEntrada> repository = new Repository<NotaEntrada>();

        public NotaEntrada InsertNotaEntrada(NotaEntrada notaEntrada)
        {
            return this.repository.Adicionar(notaEntrada);
        }

        public void RemoverNotaEntrada(NotaEntrada notaEntrada)
        {
            this.repository.Remover(notaEntrada);
        }

        public IList<NotaEntrada> GetAllNotaEntrada()
        {
            return this.repository.GetAll();
        }

        public NotaEntrada UpdateNotaEntrada(NotaEntrada notaEntrada)
        {
            return this.repository.Update(notaEntrada);
        }
    }
}
