using BookStore.DAL;
using BookStore.DAL.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL
{
    public class TestManager
    {
        public TestModel GetTestModel(int Id)
        {
            ITestRepository repository = new TestRepository();
            var model = repository.Get(Id);
        }
    }
}
