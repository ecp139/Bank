using NUnit.Framework;
using System;
using BankAccountNS;

namespace BankAccountNS
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void Debit_WithValidAmount_UpdatesBalance()
		{
			// arrange  
			double beginningBalance = 11.99;
			double debitAmount = 4.55;
			double expected = 7.44;
			BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

			// act  
			account.Debit(debitAmount);

			// assert  
			double actual = account.Balance;
			Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");


		}
	}
}
/*
// unit test code  
[TestMethod]
public void Debit_WithValidAmount_UpdatesBalance()
{
	// arrange  
	double beginningBalance = 11.99;
	double debitAmount = 4.55;
	double expected = 7.44;
	BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

	// act  
	account.Debit(debitAmount);

	// assert  
	double actual = account.Balance;
	Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
}
*/