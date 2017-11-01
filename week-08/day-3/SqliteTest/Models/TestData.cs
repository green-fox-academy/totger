using System;
namespace SqliteTest.Models
{
    public class TestData
    {
		public long Id { get; set; }
		public string Name { get; set; }
		public int Number { get;  set; }
		public bool IsTrue { get; set; } = false;
    }
}
