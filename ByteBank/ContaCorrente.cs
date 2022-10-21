using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    //classe representa alguma coisa que existe no mundo real 
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;

        //metodos -> medem o comportamento de uma classe
        //é um bloco de código que contém uma série de instruções
        public void Depositar(double valor)
        {
            //void -> valor nenhum(caixa)
            //this -> representa o próprio objeto
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
