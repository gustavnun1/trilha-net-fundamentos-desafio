using System;
using System.Collections.Generic;


Console.OutputEncoding = System.Text.Encoding.UTF8;


decimal precoInicial = 0;
decimal precoPorHora = 0;
List<string> veiculos = new List<string>();


void AdicionarVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para estacionar:");
    string placa = Console.ReadLine();
    veiculos.Add(placa);
    Console.WriteLine("Veículo estacionado com sucesso!");
}


void RemoverVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para remover:");
    string placa = Console.ReadLine();

    // Verifica se o veículo existe
    if (veiculos.Contains(placa))
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        int horas = int.Parse(Console.ReadLine());

        decimal valorTotal = precoInicial + precoPorHora * horas;
        veiculos.Remove(placa);

        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
    }
    else
    {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Verifique se digitou a placa corretamente.");
    }
}


void ListarVeiculos()
{
    if (veiculos.Count > 0)
    {
        Console.WriteLine("Os veículos estacionados são:");
        foreach (var v in veiculos)
        {
            Console.WriteLine(v);
        }
    }
    else
    {
        Console.WriteLine("Não há veículos estacionados.");
    }
}

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

string opcao = string.Empty;
bool exibirMenu = true;


while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            AdicionarVeiculo();
            break;

        case "2":
            RemoverVeiculo();
            break;

        case "3":
            ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
}

Console.WriteLine("O programa se encerrou");
