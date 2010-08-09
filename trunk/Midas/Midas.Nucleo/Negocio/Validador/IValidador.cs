using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Negocio.Validador
{

    /// <summary>
    /// Validação de objetos de Negócio.
    /// </summary>
    public interface IValidador
    {

        /// <summary>
        /// Validar se o objeto pode ser incluído na base de dados.
        /// </summary>
        /// <param name="objeto">Objeto a ser validado.</param>
        /// <returns>Verdadeiro caso possa, falso caso contrário.</returns>
        Boolean ValidarInsercao(ObjetoNegocio objeto);

        /// <summary>
        /// Validar se o objeto pode ser atualizado na base de dados.
        /// </summary>
        /// <param name="objeto">Objeto a ser validado.</param>
        /// <returns>Verdadeiro caso possa, falso caso contrário.</returns>
        Boolean ValidarAtualizacao(ObjetoNegocio objeto);

        /// <summary>
        /// Validar se o objeto pode ser excluído da base de dados.
        /// </summary>
        /// <param name="objeto">Objeto a ser validado.</param>
        /// <returns>Verdadeiro caso possa, falso caso contrário.</returns>
        Boolean ValidarExclusao(ObjetoNegocio objeto);

    }

}
