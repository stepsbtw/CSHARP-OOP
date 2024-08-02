using System;
namespace Encapsulation
{
    class BankAccount
    {
        // private by default
        private int accountNumber;
        private float balance;

        public BankAccount(int accountNumber, float initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public bool Deposit(float val)
        {
            //if (val <= 0) return false;
            if (val <= 0)
            {
                Console.WriteLine("Zero or Negative value not accepted.");
                return false;
            }
            else // for the sake of readability
            {
                this.balance += val;
                Console.WriteLine($"Succefully deposited {val}." +
                    $"Your curent balance is : {this.balance}");
                return true;
            }
        }
        public bool Withdraw(float val)
        {
            //if(val <= 0) return false; 
            if (val <= 0)
            {
                Console.WriteLine("Zero or Negative value not accepted.");
                return false;
            }
            if (val > balance)
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }
            this.balance -= val;
            Console.WriteLine($"Succefully withdrew {val}." +
                $"Your current balance is : {this.balance}");
            return true;
        }

        public float GetBalance()
        {
            return this.balance;
        }
    }
    
    class Program
    {
        static void Main2()
        {
            BankAccount acc1 = new BankAccount(123456, 1000.50f);
            acc1.Deposit(500);
            acc1.Withdraw(200);
            Console.WriteLine($"Current balance: {acc1.GetBalance()}");
        }
    }
}