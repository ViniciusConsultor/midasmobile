using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Negocio
{

    /// <summary>
    /// Classe de Negócio de Cidades.
    /// </summary>
    public class CidadeNegocio:NegocioGenerico
    {

        public CidadeNegocio()
        {
            this.AcessoDados = new Midas.Nucleo.Dados.SQLServerCE.CidadeDados();
        }

    }

}
