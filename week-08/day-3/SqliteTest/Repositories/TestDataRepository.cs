using System.Linq;
using SqliteTest.Entities;
using SqliteTest.Models;

namespace SqliteTest.Repositories
{
    public class TestDataRepository
    {
        TestDataContext testDataContext;

        public TestDataRepository(TestDataContext testDataContext)
        {
            this.testDataContext = testDataContext;
        }

        public void AddData()
        {
            var testItem = new TestData
            {
                Name = "testName",
                Number = 42,
                IsTrue = true
            };

            testDataContext.TestDatas.Add(testItem);
            testDataContext.SaveChanges();
        }

        public int GetCount()
        {
            return testDataContext.TestDatas.ToList().Count;
        }
    }
}
