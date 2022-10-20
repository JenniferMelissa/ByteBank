using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    public class Carros
    {
        public string nome_do_carro;
        public string versao;
        public string fabricante;
        public int ano_fabricacao;
        public double preco;
        public long codigo_do_carro;



        public void AumentoPreco(double novoPreco)
        {
            this.preco += novoPreco;
        }
    }
}
