using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Model;


namespace WebApplication2.Repository
{
   public interface ITestRepository
    {
        IEnumerable<Test> GetTests();
        Test GetTestById(int id);
    }
}
