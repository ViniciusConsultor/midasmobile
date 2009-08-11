/*
 *  VeículoZ é um aplicativo para gerenciamento de abastecimentos e despesas de veículos.
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
using System.Collections;
using Midas.VeiculoZ.Objetos;
using Midas.VeiculoZ.DTO;

namespace Midas.VeiculoZ.Negocio
{

    public interface IPercursoNegocio
    {
        float ObterConsumoMedioVeiculo(long id);
        IList ListarPercursosPorVeiculo(long id);
        Percurso ObterUltimoPercursoPorVeiculo(long id);
        IList ObterPercursosPorAbastecimentoFinal(long id);
        IList ListarPercursos(long idVeiculo, long idTipoAbastecimento, long idPosto, DateTime data1, DateTime data2, bool viagem);
        RelatorioGeralDTO ObterRelatorioGeral(long id);
        double ObterGastoTotalPorVeiculoPeriodo(long id, DateTime d1, DateTime d2);
    }

}
