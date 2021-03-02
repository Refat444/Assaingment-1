using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        private static int count = 1;


        public Account()
        {
            //accountNumber = count;
            //count++;
        }

        public Account(string accountName, double balance, Address address)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;

            accountNumber = count;
            count++;
        }


        
        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public string  AccountName
        {
            set {  this.accountName = value; }
            get { return this.accountName; }
        }

        public double  Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }


        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}",
           
                this.accountNumber, this.accountName, this.balance);
            Console.WriteLine("Address:"+address.GetAddress());
        
        }


        public void doWithdrawl(double amount)
        {
            if(this.balance - amount >0)
            {
                balance -= amount;

                
            }

            else
            {
                Console.WriteLine("You are not allowed!!!");
            }


        }


        public void doDeposit(double amount)
        {
            balance += amount;
            
        }


        public void transfer(Account receiver , double amount)
        {
            if (this.balance - amount > 0)
            {
                balance -= amount;
                receiver.balance += amount;


            }

            else
            {
                Console.WriteLine("You have not enough balance");
            }

        }


    }
}
