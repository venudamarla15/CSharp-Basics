using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.DeadLock
{
    public class AccountManager
    {
        private Account FromAccount;
        private Account ToAccount;
        private double TransferAmount;
        public AccountManager(Account AccountFrom, Account AccountTo, double AmountTransfer)
        {
            FromAccount = AccountFrom;
            ToAccount = AccountTo;
            TransferAmount = AmountTransfer;
        }

        public void FundTransfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {FromAccount.Id}");

            lock(FromAccount)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} Acquire lock on {FromAccount.Id}");
                Console.WriteLine($"{Thread.CurrentThread.Name} Doing Some work");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {ToAccount.Id}");
            }
            lock (ToAccount)
            {
                FromAccount.WithdrawMoney(TransferAmount);
                ToAccount.DepositeMoney(TransferAmount);
                ToAccount.DepositeMoney(TransferAmount);
            }
        }
    }
}
