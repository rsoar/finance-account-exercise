using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountFinance.Entities;

namespace AccountFinance.Business
{
    public class AccountBusiness
    {
        private readonly string _name;

        public AccountBusiness(string name)
        {
            _name = name;
        }

        public Account CreateAccount()
        {
            Random _random = new Random();
            int numb = _random.Next(1, 99999);
            string _accountNumber = string.Format("{0:00000}", numb);
            string result = _accountNumber.Remove(_accountNumber.Length - 1);
            string formatted = result + "-" + _accountNumber[_accountNumber.Length - 1];

            Account _account = new(this._name, formatted);
            return _account;
        }
    }
}
