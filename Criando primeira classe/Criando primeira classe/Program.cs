using Criando_primeira_classe;

ContaCorrente primeiraContaCorrente = new ContaCorrente();

primeiraContaCorrente.saldo = 200;

Console.WriteLine(primeiraContaCorrente.saldo);
primeiraContaCorrente.saldo = +100;
Console.WriteLine(primeiraContaCorrente.saldo);

ContaCorrente segundaContaCorrente = new ContaCorrente();
segundaContaCorrente.saldo = 50;

Console.WriteLine("Primeira conta tem: " + primeiraContaCorrente.saldo);
Console.WriteLine("Segunda conta tem: " + segundaContaCorrente.saldo);





Console.ReadLine();

