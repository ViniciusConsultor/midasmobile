using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Validador
{
    public class PessoaJuridicaValidador:IValidador
    {
        #region IValidador Members

        public Validacao Validar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            PessoaJuridica pj = (PessoaJuridica)objeto;
            if (pj.NomeFantasia == null || pj.NomeFantasia == "")
            {
                return new Validacao(false, "Informe o Nome.");
            }
            return new Validacao(true, "");
        }

        #endregion
    }
}
