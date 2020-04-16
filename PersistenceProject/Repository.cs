using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PersistenceProject
{
    public class Repository<T> : IRepository<T>
    {
        private IList<T> listGeneric = new BindingList<T>();
        
        public T Adicionar(T n)
        {
            this.listGeneric.Add(n);
            return n;
        }

        public IList<T> GetAll()
        {
            return this.listGeneric;
        }


        public void Remover(T n)
        {
            this.listGeneric.Remove(n);
        }

        public T Update(T n)
        {
            this.listGeneric[this.listGeneric.IndexOf(n)] = n;
            return n;
        }
       
    }
}
