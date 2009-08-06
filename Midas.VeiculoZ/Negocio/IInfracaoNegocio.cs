using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Midas.VeiculoZ.Negocio
{
    public interface IInfracaoNegocio
    {
        IList ListarInfracoesPorClassificacaoDescricao(long id, string descricao);
    }
}
