using System;

namespace Bank_Application
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Transactions acc = new Transactions();
            NewAccount open = new NewAccount();
            Console.WriteLine("Enter Your Choice:");
            Console.WriteLine("1.Open new Account");
            Console.WriteLine("2.Deposite");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Update Password");
            Console.WriteLine("5.Exit");
            lable:
            int ch = Int16.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    open.openAcc();
                    //Console.WriteLine("UserName And Password are:");
                    goto lable;

                case 2:
                    acc.deposite(1000);
                    //Console.WriteLine("Deposit"+acc);
                    goto lable;

                case 3:
                    acc.withdraw(1000);
                    // Console.WriteLine("Deposit" + acc);
                    goto lable;

                case 4:
                    open.Update();
                    // Console.WriteLine("Deposit" + acc);
                    goto lable;

                case 5:
                    break;

                default: Console.WriteLine("Invalid!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}