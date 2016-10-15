using BookStore.DAL.Base;
using BookStore.DAL.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL
{
    public class TestRepository : RepositoryBase<TestModel>, ITestRepository
    {
    }
}
