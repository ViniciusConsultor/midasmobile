using System;
using System.Collections;
using System.Linq;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Negocio
{

    /// <summary>
    /// Interface para classes de negócio.
    /// </summary>
    public interface INegocio
    {

        /// <summary>
        /// Obter um objeto de negócio pelo seu identificador.
        /// </summary>
        /// <param name="id">Identificador do objeto de negócio.</param>
        /// <returns>Objeto de negócio encontrado.</returns>
        ObjetoNegocio Obter(long id);

        /// <summary>
        /// Salvar um Objeto de Negócio.
        /// </summary>
        /// <param name="objeto">Objeto a ser Salvo.</param>
        void Salvar(ObjetoNegocio objeto);

        /// <summary>
        /// Excluir um objeto de negócio.
        /// </summary>
        /// <param name="id">Identificador do objeto a ser excluído.</param>
        void Excluir(long id);

        /// <summary>
        /// Listar Categorias.
        /// </summary>
        /// <returns>Lista de Categorias.</returns>
        IList Listar();
    }

}
