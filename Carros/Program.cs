using System;
using Concessionaria;

//criando objetos a partir da definição de uma classe usando o operador new
Carros HB20 = new Carros();

HB20.nome_do_carro = "HB20";
HB20.versao = "HB20 Sense 1.0 MT 2022";
HB20.fabricante = "Hyundai";
HB20.ano_fabricacao = 2022;
HB20.preco = 58890;
HB20.codigo_do_carro = 101110;

Console.WriteLine("O preço do HB20 2022 é " + HB20.preco);




HB20.AumentoPreco(1000);

Console.WriteLine("O carro sofreu um aumento. Passará a ser " + HB20.preco);