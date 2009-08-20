using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midas.Nucleo.Dados;
using System.Collections;

namespace Midas.VeiculoZ.Dados
{
    public interface IInfracaoDados:IAcessoDados
    {
        IList ListarInfracoesPorClassificacaoDescricao(long id, string descricao);
        double ObterValorTotalPorIDs(long[] ids);
    }
}
