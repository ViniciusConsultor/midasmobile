using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Negocio
{
    public interface IAbastecimentoNegocio
    {
        Abastecimento ObterSimplificado(long id);
    }
}
