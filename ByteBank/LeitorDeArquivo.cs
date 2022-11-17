using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitordeArquivo
    {
        public string Arquivo { get; }

        public LeitordeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha ...");

            //IOExeption - classe base para exceções que vao ser geradas quando tentamos acessar uma informação usando um fluxo, um arquivo, diretorios
            throw new IOException();
            return "Linha de arquivo,";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }





















    }
}
