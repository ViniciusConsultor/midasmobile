using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Validador
{
    public class CidadeValidador:IValidador
    {
        #region IValidador Members

        public Validacao Validar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Cidade cidade = (Cidade)objeto;
            if (cidade.Estado == null)
            {
                return new Validacao(false, "Informe o Estado.");
            }
            if (cidade.Nome == null || cidade.Nome == "")
            {
                return new Validacao(false, "Informe o Nome.");
            }
            return new Validacao(true, "");
        }

        #endregion
    }
}
