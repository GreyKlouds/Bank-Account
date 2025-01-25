using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
	public class SavingsAccount:BankAccount
	{
		public decimal InterestRate { get; set; }
		
		public SavingsAccount(string owner, decimal interestRate):base(owner + "("+ interestRate + "%)")
		{
			InterestRate = interestRate;
		}
		public override string Deposit(decimal amount)
		{
			if (amount <= 0)
			{
				return "You cannot depoist $" + amount;
			}
			if (amount > 20000)
			{
				return "AML deposit Limit Reached!!!";
			}
			decimal intrestAmount = (InterestRate / 100) * amount;
			Balance += amount + intrestAmount;
			return "Deposit successful!";
		}
	}
}
