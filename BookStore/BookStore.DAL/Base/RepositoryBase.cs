using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.Base;
using BookStore.DAL.Interfaces.Base;

namespace BookStore.DAL.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : ModelBase, new()
    {
        public T Get(int Id)
        {
            return new T();
        }

        public void Update(T t)
        {
            return;
        }
    }
}
