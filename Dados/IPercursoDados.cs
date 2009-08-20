/*
 *  VeículoZ é um aplicativo para gerenciamento de abastecimentos e despesas
 *  de veículos.
 *  Copyright (C) 2009  Marlon Silva Carvalho
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midas.Nucleo.Dados;
using Midas.VeiculoZ.Objetos;
using System.Collections;

namespace Midas.VeiculoZ.Dados
{
    public interface IPercursoDados:IAcessoDados
    {
        Percurso ObterUltimoPercursoPorVeiculo(long id);
        int ObterIdAbastecimentoFinal(long id);
        IList ListarDadosVisao();
        IList ListarPorVeiculoVisao(long id);
        IList ObterPorAbastecimentoFinal(long id);
        IList ListarPercursos(long idVeiculo, long idTipoAbastecimento, long idPosto, DateTime data1, DateTime data2, bool viagem);
        decimal ObterTotalKMPorVeiculo(long id);
        decimal ObterGastoTotalPorVeiculo(long id);
        decimal ObterTotalLitrosPorVeiculo(long id);
        double ObterGastoTotalPorVeiculoPeriodo(long id, DateTime data1, DateTime data2);
    }
}
