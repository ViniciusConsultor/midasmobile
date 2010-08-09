using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Excecoes
{

    /// <summary>
    /// Exceção de Negócio.
    /// </summary>
    public class NegocioException:Exception
    {

        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public NegocioException()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        public NegocioException(string mensagem):base(mensagem)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        /// <param name="parent"></param>
        public NegocioException(string mensagem, Exception parent):base(mensagem,parent)
        {
        }

    }

}
