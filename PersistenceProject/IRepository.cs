using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceProject
{
    public interface IRepository<T>
    {
        T Adicionar(T n);

        void Remover(T n);

        IList<T> GetAll();

        T Update(T n);
    }
}
