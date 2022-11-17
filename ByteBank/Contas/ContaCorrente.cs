using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using ByteBank.Titular;

namespace ByteBank.Contas
{
    //classe representa alguma coisa que existe no mundo real 
    //classe é um principio de responsabilidade
    public class ContaCorrente
    {
        //static - a propriedade passa a ser da classe e nao mais dos objetos criados a partir dela
        //é uma propriedade da classe e nao do objeto
        //set so vai funcionar dentro da propria classe conta corrente
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }

        //PROPRIEDADE - encapsula um campo que é privado (colocas os campos que eramm public para private)
        //Ele encapsula o acesso de manipulacao de um campo e a propriedade é public
        //os campos sendo private, precisa de outro sendo public para acessá-los; faz validação
        private int numero_agencia;
        public int Numero_agencia
        {
            //escopo
            //dentro do set e get faz as validaçoes necessarias(escopo)
            get { return this.numero_agencia; }
            private set 
            {
                //no set, cria-se uma variavel de tempo de execuçao chamada VALUE para ter acesso a variavel
                    if(value > 0)
                    {
                        this.numero_agencia = value;
                    }
            }
        }

        //PROPRIEDADE AUTOIMPLEMENTADA
        //Se tenho uma propriedade que nao é interessante fazer nenhum tipo de validação utiliza essa propriedade autoimplementada,
        //deixando o codigo melhor e menor
        public int Conta { get; set; }

        //campo privado, ele so é visivel dentro do codigo da classe(fora dela nao é mais)
        private double saldo = 100;

        //metodos -> medem o comportamento de uma classe
        //é um bloco de código que contém uma série de instruções
        public void Depositar(double valor)
        {
            //void -> valor nenhum(caixa)
            //this -> representa o próprio objeto
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                
            }
            else
            {
                //criação da nova exceção
                throw new SaldoInsuficienteException("Saldo Insuficiente para saque no valor de " + valor);
            }

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor) //boas praticas(prefixo): "Set" para definir o valor
        {
            if (valor < 0)
            {
                //Por ele ser void, ao colocar o "return", quando chegar aqui
                //vai parar a execução do metodo
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        
        public double GetSaldo() //boas praticas(prefixo): "Get" para pegar o valor, retorna o valor
        {
            return this.saldo;
        }

        //METODO CONSTRUTOR 
        //É util para criar nosso objeto na memoria, podendo colocar parametros para definir um objeto, assim, quando criar o objeto na memoria ele ja ter alguns valores, campos ja definidos
        //Digite "ctor + tab + tab" para contruir o construtor padrao
        public ContaCorrente(int numero_agencia, int numero_conta)
        {
            //this - é uma referencia a instancia do objeto
            this.numero_agencia = numero_agencia;
            this.Conta = numero_conta;

            //TaxaOperacao = 30 / TotalDeContasCriadas;
            if(numero_agencia <= 0)
            {
                //nameof - parametro a ser analisado pelo ArgumentException junto ao ParamName
                throw new ArgumentException("O argumento número da agência devem ser maior que 0", nameof(numero_agencia));
            }

            if(numero_conta <= 0)
            {
                throw new ArgumentException("O argumento número da conta devem ser maior que 0", nameof(numero_conta));
            }

            TotalDeContasCriadas++;
        }
    }
}
