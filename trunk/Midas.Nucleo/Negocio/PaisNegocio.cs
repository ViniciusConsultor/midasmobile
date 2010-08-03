using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Dados;
using Midas.Nucleo.Dados.SQLServerCE;

namespace Midas.Nucleo.Negocio
{

    /// <summary>
    /// Classe de Negócios para Países.
    /// </summary>
    public class PaisNegocio:NegocioGenerico
    {

        public PaisNegocio()
        {
            this.AcessoDados = new PaisDados();
        }

    }

}
