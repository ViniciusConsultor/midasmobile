using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Negocio
{

    /// <summary>
    /// Classe de Negócio para Estados.
    /// </summary>
    public class EstadoNegocio:NegocioGenerico
    {

        public EstadoNegocio()
        {
            this.AcessoDados = new Dados.SQLServerCE.EstadoDados();
        }

    }

}
