using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Financeiro.Negocio;
using Midas.Financeiro.Objetos;

namespace Midas.Financeiro
{

    /// <summary>
    /// Fachada do sistema Financeiro.
    /// </summary>
    public class FinanceiroFachada:IFinanceiroFachada
    {
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        #region IFinanceiroFachada Members

        public void SalvarCategoria(Midas.Financeiro.Objetos.Categoria categoria)
        {
            this.categoriaNegocio.Salvar(categoria);
        }

        public void ExcluirCategoria(long id)
        {
            this.categoriaNegocio.Excluir(id);
        }

        public Midas.Financeiro.Objetos.Categoria ObterCategoria(long id)
        {
            return (Categoria)this.categoriaNegocio.Obter(id);
        }

        public System.Collections.IList ListarCategorias()
        {
            return this.categoriaNegocio.Listar();
        }

        #endregion
    }

}
