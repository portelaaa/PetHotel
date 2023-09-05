﻿string especie, cor, nome, raca;
double idade;

Console.WriteLine("Qual a espécie do seu pet?");
especie = Console.ReadLine()!;
Console.WriteLine("Qual a raça do seu pet?");
raca = Console.ReadLine()!;
Console.WriteLine("Qual o nome do seu pet?");
nome = Console.ReadLine()!;
Console.WriteLine("Qual a cor do seu pet?");
cor = Console.ReadLine()!;
Console.WriteLine("Qual a idade do seu pet?");
idade = Convert.ToDouble(Console.ReadLine()!);

Console.Clear();

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                 Pet Hotel 'Nem um Pio'                  |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Espécie:......{especie.ToUpper()}    |    Raça:......{raca.ToUpper()}         |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Atende pela alcunha de:..................{nome.ToUpper()}         |");
Console.WriteLine($"| Idade:{idade} ano(s)       |    Pelagem/cor:....{cor.ToUpper()}      |");
Console.WriteLine("+=========================================================+");