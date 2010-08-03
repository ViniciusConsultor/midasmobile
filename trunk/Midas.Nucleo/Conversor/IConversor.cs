using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midas.Nucleo.Conversor
{

    /// <summary>
    /// Interface que define o comportamento de um Conversor de um tipo de dado para outro.
    /// </summary>
    public interface IConversor
    {

        /// <summary>
        /// Converter um objeto de entrada para outro, retornando-o.
        /// </summary>
        /// <param name="entrada">Objeto que será convertido.</param>
        /// <returns>Objeto convertido.</returns>
        object Converter(object entrada);

    }

}
