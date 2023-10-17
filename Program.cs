using bootcamp_dotnet_qa.Exemplos;
using bootcamp_dotnet_qa.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {quantidadeEmEstoque >= quantidadeCompra}");

if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda Realizada!");
}
else
{
    Console.WriteLine("Desculpe. Produto em Falta");
}

