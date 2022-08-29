using ConsoleApp10;

new ContaCorrente();

ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 863452;
contaDaGabriela.saldo = 100;

Console.WriteLine(contaDaGabriela.titular);
Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
Console.WriteLine("Numero: " + contaDaGabriela.numero);
Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

ContaCorrente contaDoBruno = new ContaCorrente();

contaDoBruno.titular = "Bruno";
contaDoBruno.agencia = 864;
contaDoBruno.numero = 863453;
contaDoBruno.saldo = 200;

Console.WriteLine();
Console.WriteLine(contaDoBruno.titular);
Console.WriteLine("Agencia: " + contaDoBruno.agencia);
Console.WriteLine("Numero: " + contaDoBruno.numero);
Console.WriteLine("Saldo: " + contaDoBruno.saldo);
