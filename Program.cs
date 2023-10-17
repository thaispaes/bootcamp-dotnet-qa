using bootcamp_dotnet_qa.Exemplos;
using bootcamp_dotnet_qa.Models;

Pessoa pessoa = new()
{
    Name = "Thais",
    Age = 21
};

pessoa.Apresentar();

//Teste com Tipos de dados
ExemplosAula exemplos = new()
{
    apresentacao = "Olá, Bem Vindo!",
    quantidade = 6,
    altura = 1.80,
    preco = 1.60M,
    condicao = false

};

exemplos.ExemplosConsole();