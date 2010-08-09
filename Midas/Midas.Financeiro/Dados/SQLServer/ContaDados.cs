using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Financeiro.Objetos;

namespace Midas.Financeiro.Dados.SQLServer
{

    /// <summary>
    /// Acesso a dados para objetos de negócio Conta.
    /// </summary>
    public class ContaDados:IContaDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
        }

        public void Excluir(long id)
        {
            throw new NotImplementedException();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IList Localizar()
        {
            throw new NotImplementedException();
        }


        #endregion
    }

}
