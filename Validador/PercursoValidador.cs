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
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Validador;

namespace Midas.VeiculoZ.Validador
{
    public class PercursoValidador:Midas.Nucleo.Validador.IValidador
    {
        #region IValidador Members

        public Midas.Nucleo.Validador.Validacao Validar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Percurso percurso = (Percurso)objeto;
            if (percurso.Veiculo == null)
            {
                return new Validacao(false, "Informe o Veículo.");
            }
            if (percurso.AbastecimentoInicial == null)
            {
                return new Validacao(false, "Informe os dados do Abastecimento.");
            }
            if (percurso.AbastecimentoInicial.Posto == null || percurso.AbastecimentoInicial.Posto.Id == -1)
            {
                return new Validacao(false, "Informe o Posto do Abastecimento.");
            }
            if (percurso.AbastecimentoInicial.TipoCombustivel == null || percurso.AbastecimentoInicial.TipoCombustivel.Id == 0)
            {
                return new Validacao(false, "Informe o Tipo de Combustível.");
            }
            if (percurso.AbastecimentoInicial.Valor <= 0)
            {
                return new Validacao(false, "Informe o Valor total do abastecimento.");
            }
            if (percurso.AbastecimentoInicial.ValorLitro <= 0)
            {
                return new Validacao(false, "Informe o Valor do Litro.");
            }
            if (percurso.OdometroInicio <= 0)
            {
                return new Validacao(false, "Informe a Quilometragem Inicial.");
            }
            return new Validacao(true, "");
        }

        #endregion
    }
}
