using System;
using SupermercadoMenorPreco;


Produto abacaxi = new Produto();

//objeto abacaxi é uma instanciação da classe Produto

abacaxi.nome_produto = "Abacaxi";
abacaxi.fabricante = "Fazenda do Seu Luíz";
abacaxi.codigo_de_barras = 7898331110153;
abacaxi.valor_unitario = 1.50;
abacaxi.valor_de_compra = 15;
abacaxi.quantidade_estoque = 100;



Console.WriteLine("Nome do Produto: " + abacaxi.nome_produto);
Console.WriteLine("Fabricante: " + abacaxi.fabricante);
Console.WriteLine("Código de Barras do Produto: " + abacaxi.codigo_de_barras);
Console.WriteLine("O valor unitario do produto é "+ abacaxi.valor_unitario);
Console.WriteLine("Estoque: " + abacaxi.quantidade_estoque);
Console.WriteLine();


//Aumento
abacaxi.AumentoProduto(1);
Console.WriteLine("Houve um aumento no produto. Passará a ser " + abacaxi.valor_unitario);
Console.WriteLine();

//Limite
if(abacaxi.LimiteValorProduto(2)  == true )
{
    Console.WriteLine("Houve um aumento no produto. Passará a ser " + abacaxi.valor_unitario);
}
else
{
    Console.WriteLine("Não poderá sofrer esse aumento pois está acima do limite permitido.");
}