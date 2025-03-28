﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	internal class CreditAccount : BankAccount
	{
		double creditLimit;
		public double CreditLimit { get; }
		public CreditAccount(Owner owner, double creditLimit) : base(owner)
		{
			this.CreditLimit = creditLimit;
		}
		public override bool Withdraw(double amount)
		{
			if (this.Balance - amount >= creditLimit)
			{
				this.Balance -= amount;
				return true;
			}
			return false;
		}
	}
}
