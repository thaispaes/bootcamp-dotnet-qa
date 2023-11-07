using BootcampDotNet.Common.Models;
using BootcampDotNet.Common.Models.ExemplosAula;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("PE", "Pernambuco");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("SP", "São Paulo"); //Adicionar

foreach (var item in estados)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine("----------");

estados.Remove("RJ"); // Remover

foreach (var item in estados)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine("----------");

estados["SP"] = "Sao Paulo";

foreach (var item in estados)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

