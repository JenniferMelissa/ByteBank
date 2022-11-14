using System;
using Concessionaria;

//criando objetos a partir da definição de uma classe usando o operador new
Carros HB20 = new Carros();

HB20.codigo_do_carro = 101110;
HB20.nome_do_carro = "HB20";
HB20.versao = "HB20 Sense 1.0 MT 2022";
HB20.fabricante = "Hyundai";
HB20.ano_fabricacao = 2022;
HB20.preco = 58890;


Console.WriteLine("Código do Carrro: " + HB20.codigo_do_carro);
Console.WriteLine("Nome do Carro: " + HB20.nome_do_carro);
Console.WriteLine("Versão do Carro: " + HB20.versao);
Console.WriteLine("Fabricante: " + HB20.fabricante);
Console.WriteLine("Ano de Fabricação: " + HB20.ano_fabricacao);
Console.WriteLine("O preço do HB20 2022 é " + HB20.preco);
Console.WriteLine();

//Aumento
HB20.AumentoPreco(1);
Console.WriteLine("O Carro aumentou de preço. Passou a custar R$" + HB20.preco + " reais à vista!");
Console.WriteLine();


//Limite
if (HB20.LimitePreco(1000) == true)
{
    Console.WriteLine("O carro sofreu um aumento. Passará a ser " + HB20.preco);
}
else
{
    Console.WriteLine("Devido ao aumento do valor. Não encontra-se no seu orçamento de preço.");
}

//Trocar carro
Carros Gol = new Carros();

Gol.codigo_do_carro = 101111;
Gol.nome_do_carro = "Gol";
Gol.versao = "Gol 1.0 MPI";
Gol.fabricante = "Volkswagem";
Gol.ano_fabricacao = 2023;
Gol.preco = 70000;











