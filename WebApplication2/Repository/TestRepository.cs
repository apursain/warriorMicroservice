using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DbContexts;
using WebApplication2.Model;

namespace WebApplication2.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly TestContext _testContext;
        public TestRepository(TestContext TContext)
        {
            _testContext = TContext;
        }
        public Test GetTestById(int id)
        {
            return _testContext.lstTests.Find(id);
        }

        public IEnumerable<Test> GetTests()
        {
            return _testContext.lstTests.ToList();
        }
    }
}
