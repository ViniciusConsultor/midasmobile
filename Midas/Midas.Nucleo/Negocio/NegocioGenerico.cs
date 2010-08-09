using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Dados;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Negocio
{

    /// <summary>
    /// Classe abstrata que define o comportamento padrão para objetos de negócio.
    /// </summary>
    public abstract class NegocioGenerico:INegocio
    {

        /// <summary>
        /// A camada de acesso a dados para essa regra de negócio.
        /// </summary>
        private IAcessoDados acessoDados;
        public IAcessoDados AcessoDados
        {
            get { return acessoDados; }
            set { acessoDados = value; }
        }

        #region INegocio Members

        public virtual Midas.Nucleo.Objetos.ObjetoNegocio Obter(long id)
        {
            return this.acessoDados.Localizar(id);
        }

        public virtual void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            this.acessoDados.Salvar(objeto);
        }

        public virtual void Excluir(long id)
        {
            this.acessoDados.Excluir(id);
        }

        public virtual System.Collections.IList Listar()
        {
            return this.acessoDados.Localizar();
        }

        #endregion
    }

}
