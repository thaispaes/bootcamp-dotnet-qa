using bootcamp_dotnet_qa.Exemplos;
using bootcamp_dotnet_qa.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda Inválida!");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda Realizada!");
}
else
{
    Console.WriteLine("Desculpe. Produto em Falta");
}

