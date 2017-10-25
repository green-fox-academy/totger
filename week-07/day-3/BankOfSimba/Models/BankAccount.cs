using System;
namespace BankOfSimba.Models
{

    public class BankAccount
    {
		public enum Animal { Zebra, Monkey, Lion, Hyena, Vulture }

        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Animal AnimalType { get; set; }
        public bool IsKing { get; set; } = false;
        public bool IsGood { get; set; } = true;

        public BankAccount(string name, int balance, Animal animal, bool isGood)
        {
            Name = name;
            Balance = balance;
            AnimalType = animal;
            IsGood = isGood;
        }

        public BankAccount(string name, int balance, Animal animal, bool isGood, bool isKing)
        {
            Name = name;
            Balance = balance;
            AnimalType = animal;
            IsKing = isKing;
        }
    }
}
