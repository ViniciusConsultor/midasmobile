using System;
using System.Collections;
using System.Linq;
using System.Text;
using Midas.Financeiro.Objetos;

namespace Midas.Financeiro
{

    /// <summary>
    /// Fachada do Sistema Financeiro.
    /// </summary>
    public interface IFinanceiroFachada
    {

        /// <summary>
        /// Salvar o estado de uma categoria.
        /// </summary>
        /// <param name="categoria">Categoria a ser salva.</param>
        void SalvarCategoria(Midas.Financeiro.Objetos.Categoria categoria);

        /// <summary>
        /// Excluir uma Categoria.
        /// </summary>
        /// <param name="id">Identificador da Categoria.</param>
        void ExcluirCategoria(long id);

        /// <summary>
        /// Obter uma Categoria.
        /// </summary>
        /// <param name="id">Identificador da Categoria a ser obtida.</param>
        /// <returns>Categoria obtida.</returns>
        Categoria ObterCategoria(long id);

        /// <summary>
        /// Obter todas as categorias cadastradas.
        /// </summary>
        /// <returns>Lista de Categorias.</returns>
        IList ListarCategorias();
    }

}
