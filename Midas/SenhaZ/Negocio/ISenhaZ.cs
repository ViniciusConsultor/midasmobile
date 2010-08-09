using System;
using System.Collections;
using System.Linq;
using System.Text;
using SenhaZ.Objetos;

namespace SenhaZ.Negocio
{

    /// <summary>
    /// Interface que define o comportamento do sistema.
    /// </summary>
    public interface ISenhaZ
    {

        /// <summary>
        /// Salvar uma Categoria.
        /// </summary>
        /// <param name="categoria">Categoria a ser salva.</param>
        void SalvarCategoria(Categoria categoria);

        /// <summary>
        /// Excluir uma Categoria.
        /// </summary>
        /// <param name="id">Identificador da Categoria a ser excluída.</param>
        void ExcluirCategoria(long id);

        /// <summary>
        /// Localizar uma Categoria pelo seu identificador.
        /// </summary>
        /// <param name="id">Identificador da categoria a ser encontrada.</param>
        /// <returns></returns>
        Categoria LocalizarCategoria(long id);

        /// <summary>
        /// Localizar todas as categorias.
        /// </summary>
        /// <returns>Lista de categorias.</returns>
        IList LocalizarCategorias();

        /// <summary>
        /// Verificar o usuário e senha para utilização do sistema.
        /// </summary>
        /// <param name="senha">Senha de acesso ao sistema.</param>
        /// <returns>Verdadeiro caso a senha esteja correta. Falso caso contrário.</returns>
        Boolean Logar(string senha);

        /// <summary>
        /// Inicializar o Sistema, carregando o banco de dados.
        /// </summary>
        void InicializarSistema();
    }

}
