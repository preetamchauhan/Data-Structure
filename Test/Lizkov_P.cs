using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Lizkov_P
    {
    }

    public interface ICredit
    {
        void Credit(int amount);
    }
    public interface IBanking
    {
        void Debit(int amount);
    }

    public class Transaction
    {
        internal List<IBanking> account = new List<IBanking>();
        public Transaction()
        {
            this.account.Add(new SavingAccount(100));
            this.account.Add(new PremiumAccount(200));
        }
        
        public void DebitAnnualFee(List<IBanking> account)
        {
            account.ForEach(acc =>
            {
                    acc.Debit(5);
            });
        }      
    }

    public class SavingAccount : IBanking, ICredit
    {
        int Balance { get; set; }
        public SavingAccount(int balance)
        {
            Balance = balance;
        }
        public void Credit(int amount)
        {
            Balance = Balance + amount;
        }

        public void Debit(int amount)
        {
            Balance = Balance - amount;
        }
    }

    public class LongRunningAccount : ICredit
    {
        int Balance { get; set; }
        public void Credit(int amount)
        {
            Balance = Balance + amount;
        }
    }
    public class PremiumAccount : IBanking, ICredit
    {
        int Balance { get; set; }
        int CreditPoints;
        public PremiumAccount(int balance)
        {
            Balance = balance;
        }
        public void Credit(int amount)
        {
            Balance = Balance + amount;
            AddCredits();
        }

        public void Debit(int amount)
        {
            Balance = Balance - amount;
        }

        public void AddCredits()
        {
            CreditPoints++;
        }
    }
}
