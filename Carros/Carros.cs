using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    public class Carros
    {
        public long codigo_do_carro;
        public string nome_do_carro;
        public string versao;
        public string fabricante;
        public int ano_fabricacao;
        public double preco;

        public void AumentoPreco(double novoPreco)
        {
            this.preco += novoPreco;
        }

        public bool LimitePreco(double novoPreco)
        {
            if(this.preco > 60000)
            {
                this.preco -= novoPreco;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool TrocarCarro(int novo)
        {
            
        }
    }
}
