
//new -> operador que me permite criar um novo objeto
// . -> acessar os dados da classe
using ByteBank;

ContaCorrente contaDoAndre = new ContaCorrente();

contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);
Console.WriteLine();

contaDoAndre.Depositar(100);


Console.WriteLine("Titular: " + contaDoAndre.titular);
Console.WriteLine("Número da Agência: " + contaDoAndre.numero_agencia);
Console.WriteLine("Número da Conta: " + contaDoAndre.conta);
Console.WriteLine("Saldo da conta do André: R$" + contaDoAndre.saldo);