using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Midas.Nucleo.Dados;

namespace Midas.VeiculoZ.Dados
{
    public interface IMultaDados:IAcessoDados
    {
        IList ListarMultasPorVeiculo(long id);
    }
}
