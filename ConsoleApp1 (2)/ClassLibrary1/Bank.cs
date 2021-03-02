using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bank
    {
        private string bankName;
        public Account[] accounts;

        public Bank (string bankName, int size)
        {
            this.bankName = bankName;
            this.accounts = new Account[4];
        }

        public void Addaccount(Account account)
        {

            for(int i=0; i<accounts.Length;i++)
            {
                if(accounts[i] == null)
                {
                    accounts[i] = account;
                    break;

                }
            }
        }

        public void DeleteAccount(Account account)
        {

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == account)
                {
                    accounts[i] = null;
                    break;

                }
            }
        }

        public void ShowAccountDetails(int accountNo)
        {

            for (int i = 0; i < accounts.Length; i++)
            {
                if(accounts[i] == null)
                {
                    break;
                }

                if (accounts[i].AccountNumber  == accountNo)
                {
                    accounts[i].ShowAccountInformation();
                    break;

                }
            }
        }


    }
}
