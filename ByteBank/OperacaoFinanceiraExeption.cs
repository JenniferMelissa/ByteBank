using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class OperacaoFinanceiraExeption:Exception
    {

        public OperacaoFinanceiraExeption()
        {

        }

        public OperacaoFinanceiraExeption(string mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceiraExeption(string mensagem, Exception excecaoInterna):base(mensagem, excecaoInterna)
        {

        }












    }
}
