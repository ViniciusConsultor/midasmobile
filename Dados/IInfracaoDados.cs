using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midas.Nucleo.Dados;

namespace Midas.VeiculoZ.Dados
{
    public interface IInfracaoDados:IAcessoDados
    {
        System.Collections.IList ListarInfracoesPorClassificacaoDescricao(long id, string descricao);
    }
}
