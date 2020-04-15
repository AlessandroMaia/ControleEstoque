using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PersistenceProject
{
    public class Repository<T> : IRepository<T>
    {
        private IList<T> generic = new BindingList<T>();
        public T Adicionar(T n)
        {
            this.generic.Add(n);
            return n;
        }

        public IList<T> GetAll()
        {
            return this.generic;
        }

        public void Remover(T n)
        {
            this.generic.Remove(n);
        }

        public T Update(T n)
        {
            this.generic[this.generic.IndexOf(n)] = n;
            return n;
        }
    }
}
