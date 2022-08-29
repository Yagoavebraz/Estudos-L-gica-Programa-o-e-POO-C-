using Herança_e_Poli.Entities;

List<Account> list = new List<Account>();

list.Add(new SavingAccounts(1001, "Alex", 500, 1));

list.Add(new BusinessAccount(1002, "Maria", 500, 400));

list.Add(new SavingAccounts(1003, "Bob", 500, 1));

list.Add(new BusinessAccount(1004, "Ana", 500, 500));

double soma = 0;

foreach(Account acc in list) {
    soma += acc.Balance;
}

Console.WriteLine(soma);

foreach(Account acc in list) {
    acc.Withdraw(10);
}

foreach (Account acc in list) {
    Console.WriteLine("Saldo atualizado: " + acc.Number + "-" + acc.Balance);
}
