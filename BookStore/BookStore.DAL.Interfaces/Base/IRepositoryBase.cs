using BookStore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Interfaces.Base
{
    public interface IRepositoryBase<T> where T:ModelBase
    {
        T Get(int Id);
        void Update(T t);
    }
}
