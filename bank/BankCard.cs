using bank;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	internal class BankCard : BankingService
	{
		double accountBalance;
		string cardNumber;

		public string CardNumber { get; }
		public double AccountBalance { get; }
		public BankCard(Owner ownerm double accountBalance, string cardNumber)
		{
			this.accountBalance = accountBalance;
			this.cardNumber = cardNumber;
		}
	
		public bool Purchase(double amount)
		{
			if (accountBalance - amount >= 0)
			{
				return true;
			}
			return false;
		}
	
	}
}
