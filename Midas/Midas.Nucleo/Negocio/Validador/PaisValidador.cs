using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Negocio.Validador
{

    /// <summary>
    /// Validador de Países.
    /// </summary>
    public class PaisValidador:IValidador
    {

        #region IValidador Members

        public bool ValidarInsercao(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Pais pais = (Pais)objeto;
            if (pais.Nome == null || pais.Nome == "")
            {
                return false;
            }
            return true;
        }

        public bool ValidarAtualizacao(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            return this.ValidarInsercao(objeto);
        }

        public bool ValidarExclusao(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Pais pais = (Pais)objeto;
            if (pais.Id == null)
            {
                return false;
            }
            return true;
        }

        #endregion
    }

}
