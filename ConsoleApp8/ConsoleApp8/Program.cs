using ConsoleApp8;

Produtos p = new Produtos();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preco: ");
p.Preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.Write("Digite numero de produtos adicionados ao estoque:");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine("Dados Atualizados: " + p);

Console.WriteLine();
Console.Write("Digite numero de produtos removidos ao estoque:");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine("Dados Atualizados: " + p);