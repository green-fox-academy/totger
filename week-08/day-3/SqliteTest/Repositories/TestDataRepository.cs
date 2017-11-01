using System.Linq;
using SqliteTest.Entities;
using SqliteTest.Models;

namespace SqliteTest.Repositories
{
    public class TestDataRepository
    {

        TestDataContext TestDataContext;

        public TestDataRepository(TestDataContext testDataContext)
        {
            TestDataContext = testDataContext;
        }

        public void AddData()
        {
            var data = new TestData()
            {
                Name = "testName",
                Number = 42,
                IsTrue = true,
            };

            TestDataContext.TestDatas.Add(data);
            TestDataContext.SaveChanges();
        }

        public int ReturnCount()
        {
            return TestDataContext.TestDatas.ToList().Count();
        }
    }
}
