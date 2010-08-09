using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Excecoes
{

    /// <summary>
    /// Exceção específica para quando ocorrem erros de validação.
    /// </summary>
    public class ValidacaoException:NegocioException
    {

        public ValidacaoException()
        {
        }

        public ValidacaoException(string message):base(message)
        {
        }

        public ValidacaoException(string message, Exception inner):base(message,inner)
        {
        }

    }

}
