using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Negocio
{
    public class EnderecoNegocio:NegocioGenerico
    {
        public EnderecoNegocio()
        {
            this.AcessoDados = new Dados.SQLServerCE.EnderecoDados();
        }
    }
}
