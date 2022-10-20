using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoMenorPreco
{
    public class Produto
    {
        public string nome_produto;
        public string fabricante;
        public long codigo_de_barras;
        public double valor_unitario;
        public double valor_de_compra;
        public int quantidade_estoque;

        public void AumentoProduto(int aumento)
        {
            this.valor_unitario += aumento;
        }
    }
}
