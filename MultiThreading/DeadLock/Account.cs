using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.DeadLock
{
    public class Account
    {
        public int Id { get; }
        private double Balance { get; set; }

        public Account(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }

        public void WithdrawMoney(double amount)
        {
            Balance += amount;
        }

        public void DepositeMoney(double amount)
        {
            Balance -= amount;
        }
    }
}
