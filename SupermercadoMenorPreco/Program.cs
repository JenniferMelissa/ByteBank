using System;
using SupermercadoMenorPreco;


Produto abacaxi = new Produto();

//objeto banana é uma instanciação da classe Produto

abacaxi.nome_produto = "Banana";
abacaxi.fabricante = "Fazenda do Seu Luíz";
abacaxi.codigo_de_barras = 7898331110153;
abacaxi.valor_unitario = 1.50;
abacaxi.valor_de_compra = 15;
abacaxi.quantidade_estoque = 100;

Console.WriteLine("O valor unitario do produto é "+ abacaxi);


abacaxi.AumentoProduto(1);

Console.WriteLine("Houve um aumento no produto. Passará a ser " + abacaxi.valor_unitario);
