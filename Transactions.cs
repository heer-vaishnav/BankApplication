using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application
{
    class Transactions
    {
        //float balance;
        List<float> BalanceDep = new List<float>();
        List<float> BalanceWith = new List<float>();

        public void deposite(float Balance)
        {
            
            Console.WriteLine("Enter the amount you want to deposit:");
            float amount =float.Parse(Console.ReadLine());
            if (amount>0)
            {
                Balance = Balance + amount;
                BalanceDep.Add(amount);
                Console.WriteLine("Your Balance is:" + Balance);
            }
            else
            {
                Console.WriteLine("Enter proper amount");
            }
        }

        public void withdraw(float Balance)
        {

            Console.WriteLine("Enter the amount you want to withdraw:");
            float amount = float.Parse(Console.ReadLine());
            if (amount < Balance)
            {
                Balance = Balance - amount;
                BalanceWith.Remove(amount);
                Console.WriteLine("Your Balance is:" + Balance);
            }
            else
            {
                Console.WriteLine("Enter proper amount to withdraw");
                Console.WriteLine("Your Balance is" + Balance);
            }
        }
    }
}
