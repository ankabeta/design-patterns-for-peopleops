using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesingPattern
{
    class Program
    {
        //Soyut State nesnesi
        public interface IAccountState
        {
            void WithdrawMoney();
            void PayInterest();
        }

        //Concrete State nesnesi - 1
        public class GoldAccount : IAccountState
        {
            public void PayInterest()
            {
                Console.WriteLine("Interest paid with Golden Account");
            }

            public void WithdrawMoney()
            {
                Console.WriteLine("Money is taken with Golden Account");
            }
        }

        //Concrete State nesnesi - 2
        public class NormalAccount : IAccountState
        {
            public void PayInterest()
            {
                Console.WriteLine("Interest paid with Normal Account");
            }

            public void WithdrawMoney()
            {
                Console.WriteLine("Money is taken with Normal Account");
            }
        }

        //State değişimlerini yöneten ve statelere göre davranışları değişen context nesnesi  
        public class Account
        {
            private IAccountState _accountState;

            public Account()
            {
                _accountState = new NormalAccount();
            }

            public void PayInterest()
            {
                _accountState.PayInterest();
            }

            public void WithdrawMoney()
            {
                _accountState.WithdrawMoney();
            }

            public void ChangeStatus(IAccountState newACcountState)
            {
                _accountState = newACcountState;
            }
        }
        static void Main(string[] args)
        {
            Account account = new Account();
            account.WithdrawMoney();
            account.PayInterest();

            account.ChangeStatus(new GoldAccount());

            account.WithdrawMoney();
            account.PayInterest();

            Console.ReadKey();
        }
    }
}
