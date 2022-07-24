using AccountFinance.Entities;
using AccountFinance.Business;

string[] personas = new string[3] { "Rafael", "Manuella", "Sabrina" };
List<Account> accounts = new List<Account>();

foreach (string persona in personas)
{
    AccountBusiness accountBusiness = new(persona);
    Account newAccount = accountBusiness.CreateAccount();
    accounts.Add(newAccount);
}

foreach(Account account in accounts)
{
    Console.WriteLine("Proprietário(a): " + account.Owner);
    Console.WriteLine("Número da conta: " +account.Number);
    Console.WriteLine("Balanço: " + account.Balance);
}
