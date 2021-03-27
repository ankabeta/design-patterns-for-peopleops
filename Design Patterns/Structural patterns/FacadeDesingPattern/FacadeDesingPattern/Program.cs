using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Facade facade = new Facade();

            Customer customer1 = new Customer() { IDNo = "1245203836", Fullname = "Ahmet", CustomerNumber = 11243, CashAmount = 3456090.25M };
            Customer customer2 = new Customer() { IDNo = "2342342342", Fullname = "Mehmet", CustomerNumber = 123123, CashAmount = 34929272.36M };

            //send eft customer1 to customer2
            facade.SendEFT(customer1, customer2, 12345);

            //use credit to customer 2
            facade.UseCredit(customer2);

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string Fullname { get; set; }
        public string IDNo { get; set; }
        public decimal CashAmount { get; set; }
    }


    public static class ControlManager
    {
        public static bool CheckHasEnoughCashInBankAccount(Customer customer, decimal amount)
        {
            if (customer.CashAmount >= amount)
                return true;
            else
                return false;
        }

        public static bool CheckCanUseCredit(string IDNo)
        {
            //test için her zaman return true
            return true;
        }
    }
    public class EFTManager
    {
        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            if (ControlManager.CheckHasEnoughCashInBankAccount(fromCustomer, eftAmount))
            {
                fromCustomer.CashAmount -= eftAmount;
                Console.WriteLine("EFT " + toCustomer.CustomerNumber + " nolu hesaba gönderildi..");
            }
            else
                Console.WriteLine("Hesabınızda yeterli miktar olmadığı için EFT işleminiz gerçekleştirilemedi.");
        }
    }

    public class CreditManager
    {
        public void UseCredit(Customer customer)
        {
            if (ControlManager.CheckCanUseCredit(customer.IDNo))
                Console.WriteLine("Kredi kullandırılmıştır.");
            else
                Console.WriteLine("Banka kredinizi onaylamamıştır.");
        }
    }

    public class Facade
    {
        private EFTManager _eftManager;
        private CreditManager _creditManager;

        public Facade()
        {
            _eftManager = new EFTManager();
            _creditManager = new CreditManager();
        }

        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            _eftManager.SendEFT(fromCustomer, toCustomer, eftAmount);
        }

        public void UseCredit(Customer customer)
        {
            _creditManager.UseCredit(customer);
        }
    }

}
