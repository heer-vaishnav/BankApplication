using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application
{
    class NewAccount
    {
        //public string UserName { get; set; }
        //public string Password { get; set; }
        Dictionary<string, string> User = new Dictionary<string, string>();

        public void openAcc()
        {
            Console.WriteLine("Enter UserName and Password to open a new account");
            string UserName =Console.ReadLine();
            string Password = Console.ReadLine();
            User.Add(UserName, Password);
            Console.WriteLine("UserName: " + UserName);
            Console.WriteLine("Password: " + Password);
        }

        public void getDetails()
        {

            Console.WriteLine("Your Account Details are:");
            //Console.WriteLine("UserName:"+ UserName);
            //Console.WriteLine("Password: " + Password);
            //Console.WriteLine("Balance:" + Balance)
        }

        public void Update()
        {
            Console.WriteLine("Enter UserName to Update Your Password:");
            string oldName = Console.ReadLine();

            if (User.ContainsKey("" + oldName))
            {
                Console.WriteLine("Enter new Password:");
                string newPassword = Console.ReadLine();
                User.Remove(oldName);
                User.Add(oldName, newPassword);
                Console.WriteLine("PassWord updated");
            }
            else
            {
                Console.WriteLine("Enter right username to update your password!!!");
            }
        }
    }
}
