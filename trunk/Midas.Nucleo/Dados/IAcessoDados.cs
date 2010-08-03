using System;
using System.Collections;
using System.Linq;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Dados
{

    /// <summary>
    /// Interface que define o comportamento padrão para objetos de acesso a dados.
    /// </summary>
    public interface IAcessoDados
    {

        /// <summary>
        /// Salvar um objeto de negócio.
        /// </summary>
        /// <param name="objeto">Objeto a ser salvo.</param>
        void Salvar(ObjetoNegocio objeto);

        /// <summary>
        /// Excluir um objeto da base de dados.
        /// </summary>
        /// <param name="id">Identificador do objeto.</param>
        void Excluir(long id);

        /// <summary>
        /// Localizar um objeto na base de dados.
        /// </summary>
        /// <param name="id">Identificador do objeto.</param>
        /// <returns>Objeto localizado.</returns>
        ObjetoNegocio Localizar(long id);

        /// <summary>
        /// Localizar todos os objetos cadastrados na base.
        /// </summary>
        /// <returns>Lista de Objetos.</returns>
        IList Localizar();

    }

}
