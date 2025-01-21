using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// continue  Classes and Objects (C# OOP - Practical Programming Tutorial) - part 4

namespace Bank_Account
{	
	public class BankAccount
	{
		public string Owner {  get; set; }
		public Guid AccountNumber { get; set; }
		public decimal Balance { get; private set; }

		public BankAccount(string owner)
		{
			Owner = owner;
			AccountNumber = Guid.NewGuid();
			Balance = 0;
		}

		public string Deposit(decimal amount)
		{
			if(amount<= 0)
			{
				return "You cannot depoist $" + amount;
			}
			if(amount > 20000)
			{
				return "AML deposit Limit Reached!!!";
			}

			Balance += amount;
			return "Deposit successful!";
		}

		public string Withdraw(decimal amount)
		{
			if (amount <= 0)
			{
				return "You cannot Withdraw $" + amount;
			}
			if (amount > Balance)
			{
				return "Insuffecient funds!";
			}

			Balance -= amount;
			return "Withdraw successful!";
		}
	}
}
