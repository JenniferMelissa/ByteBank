﻿
//new -> operador que me permite criar um novo objeto
// . -> acessar os dados da classe
//ctl k + c -> comenta as linhas
//ctl k + u -> descomenta as linhas

using System.Net.Http.Headers;
using ByteBank.Contas;
using ByteBank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;
//Console.WriteLine("Titular: " + contaDoAndre.titular);
//Console.WriteLine("Número da Agência: " + contaDoAndre.numero_agencia);
//Console.WriteLine("Número da Conta: " + contaDoAndre.conta);
//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);
//Console.WriteLine();


//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;
//Console.WriteLine("Titular: " + contaDoAndre2.titular);
//Console.WriteLine("Número da Agência: " + contaDoAndre2.numero_agencia);
//Console.WriteLine("Número da Conta: " + contaDoAndre2.conta);
//Console.WriteLine("Saldo da conta do André = " + contaDoAndre2.saldo);
//Console.WriteLine();


//TIPO VALOR E TIPO REFERENCIA
//O primeiro retorna true, sendo assim, os valores e enderecamento de memoria sao iguais
//O seguindo retorna false, sendo que por mais que sejam iguais,
//o enderecamento de memoria é diferente
//contaDoAndre = contaDoAndre2;
//Console.WriteLine(contaDoAndre == contaDoAndre2);


////Depositar - Método
//contaDoAndre.Depositar(100);
//Console.WriteLine("Saldo da conta do André pós-deposito: R$" + contaDoAndre.saldo);
//Console.WriteLine();

////Método - Sacar
//if (contaDoAndre.Sacar(300) == true)
//{
//    Console.WriteLine("Saldo da conta do André pós-saque: R$" + contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque.");

//}

////Tranferir - Criando a conta da Maria para efetuar a tranferência
//ContaCorrente contaDaMaria = new ContaCorrente();

//contaDaMaria.titular = "Maria Silva";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria: R$" + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);



//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";

//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);


//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2);

//Associando o objeto conta corrente com o objeto cliente.
//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "01234567891";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão  = " + conta.titular.profissao);
//Console.WriteLine("N Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("N Agência = " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
////sem isso dá erro de referencia nula (conta2.titular = new Cliente();) e para não dar erro precisamos criar o objeto na memória e aí sim conseguiremos inserir valores nesse objeto.
////Agora temos um objeto na memória para onde estamos apontando o campo titular da conta2 porque agora nosso objeto existe.

//conta2.titular.nome = "Jose Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "11121212111";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);


//acessando campos privados atraves da metodos ou propriedades publicos
//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.SetSaldo(200);
//conta3.Conta = "1011-H";

//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

//para acessar a classe/metodo/campo STATIC precisa referenciar a classe nao mais o obejeto
ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(285, "2274-Y");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";
sarah.Profissao = "Professora";
sarah.Cpf = "11111111-12";

Cliente ester = new Cliente();
ester.Nome = "Ester Almeida";
ester.Profissao = "Advogada";
ester.Cpf = "868524125-32";

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

ContaCorrente contaAndre = new ContaCorrente(159, "152869-x");
contaAndre.Titular = new Cliente();
contaAndre.Titular.Nome = " André Pereira";
contaAndre.Titular.Profissao = "Auxiliar Administrativo";


Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);








