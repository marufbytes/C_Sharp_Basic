using System;

namespace ConsoleApp1
{
    public class Account
    {
        private int accountNumber;
        private string accountHolderName;
        private double balance;

        public Account(int accountNumber, string accountHolderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }

        public int GetAccountNumber() => accountNumber;
        public string GetAccountHolderName() => accountHolderName;
        public double GetBalance() => balance;
    }

    public class Customer
    {
        private string name;
        private int nid;
        private Account account;

        public Customer(string name, int nid, Account account)
        {
            this.name = name;
            this.nid = nid;
            this.account = account;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("NID: " + nid);
            if (account != null)
            {
                Console.WriteLine("Account Number: " + account.GetAccountNumber());
                Console.WriteLine("Account Holder Name: " + account.GetAccountHolderName());
                Console.WriteLine("Balance: " + account.GetBalance());
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Account acc = new Account(300, "Nova", 2000); // Creating account
            Customer cust = new Customer("Ongona", 4455, acc); // Linking account to customer

            cust.ShowDetails(); // Displaying all details

            Console.ReadLine();
        }
    }
}
