using System.Globalization;
// See https://aka.ms/new-console-template for more information

char genero = 'F';
int idade = 32;
double saldo = 10.35784;
string nome = "Sofia";

Console.WriteLine("Bom dia");
Console.WriteLine("Boa Tarde");
Console.WriteLine("Boa noite");
Console.WriteLine("--------------------------");
Console.WriteLine(genero);
Console.WriteLine(idade);
Console.WriteLine(saldo.ToString("F2"));
Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
// Concatenação
Console.WriteLine(nome + " tem a idade de " + idade + " anos e tem o Saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
// Usando placeHolders
Console.WriteLine("{0} tem a idade de {1} anos e tem o saldo de {2:F2} reais.", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
// Interpolação + 6
Console.WriteLine($"{nome} tem a idade de " + $"{idade}" + " anos e tem o saldo de " + $"{saldo.ToString("F2", CultureInfo.InvariantCulture)} reais.");
