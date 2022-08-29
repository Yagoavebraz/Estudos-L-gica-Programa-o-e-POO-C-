using ConsoleApp12;

ContaCorrente primeiraContaCorrente = new ContaCorrente();
Console.ReadLine();

primeiraContaCorrente.saldo = 200;
Console.WriteLine(primeiraContaCorrente.saldo);
Console.ReadLine();

primeiraContaCorrente.saldo += 100;
Console.WriteLine(primeiraContaCorrente.saldo);

ContaCorrente segundaContaCorrente = new ContaCorrente();

segundaContaCorrente.saldo = 50;

Console.WriteLine("primeira conta tem " + primeiraContaCorrente.saldo);
Console.WriteLine("segunda conta tem " + segundaContaCorrente.saldo);
