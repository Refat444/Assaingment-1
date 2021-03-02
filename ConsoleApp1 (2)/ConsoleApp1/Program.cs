using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1; 


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address("208", "ty/90", "Dhaka", "Bangladesh");
            Account account1 = new Account("Refat", 5000.00, address);


            //account1.doWithdrawl(3000);
            //account1.doDeposit(5000);



            //account1.ShowAccountInformation();


            Address address2 = new Address("209", "ty/70", "Rajshahi", "Bangladesh");
            Account account2 = new Account("Rupok", 3000.00, address2);
            //account2.ShowAccountInformation();
            //account2.transfer(account1, 500);
            ////account2.ShowAccountInformation();
            ////account1.ShowAccountInformation();


            //////////////////////////////////////
            ///
            Bank b1 = new Bank("Ashar Alo Bank", 4);

            //b1.Addaccount(account1);
            //b1.Addaccount(account2);
            //b1.ShowAccountDetails(1);
            //b1.ShowAccountDetails(2);

            // b1.DeleteAccount(account1);
            // b1.ShowAccountDetails(1);

            /////////////////////////////////////
            ///

            do
            {
                Console.WriteLine("1.Account info\n 2.Deposit money\n 3.Withdraw money\n 4.Transfer money");
                Console.WriteLine("Enter your choice: ");





                int input = System.Convert.ToInt32(System.Console.ReadLine());





                if (input != 0)
                {
                    if (input == 1)
                    {


                        b1.Addaccount(account1);
                        b1.ShowAccountDetails(1);


                        b1.Addaccount(account2);
                        b1.ShowAccountDetails(2);


                    }






                    if (input == 2)
                    {
                        Console.WriteLine("===========Deposit section============");
                        Console.WriteLine("Enter the amount you will deposit: ");
                        double amount = System.Convert.ToDouble(System.Console.ReadLine());


                        account1.doDeposit(amount);
                        

                    }



                    if (input == 3)
                    {
                        Console.WriteLine("==========Withdraw section============");



                        Console.WriteLine("Enter the amount you will withdraw : ");
                        double amount = System.Convert.ToDouble(System.Console.ReadLine());

                        account1.doWithdrawl(amount);
                    }



                    if (input == 4)
                    {
                        Console.WriteLine("==========Transfer section============");




                        



                        Console.WriteLine("Enter the amount you will transfer: ");
                        double amount = System.Convert.ToDouble(System.Console.ReadLine());



                        account2.transfer(account1, amount);

                        //Console.WriteLine(account2);




                    }
                }
                else
                {
                    break;



                }
            } while (1 != 0);











        }
    }
}



 