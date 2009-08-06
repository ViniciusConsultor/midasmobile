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
using Midas.Nucleo.Conversor;
using System.Data.SqlServerCe;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Conversores
{

    /// <summary>
    /// Conversor de SqlCeDataReader para um objeto Abastecimento.
    /// </summary>
    public class AbastecimentoConversorDataReader:IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Abastecimento abastecimento = new Abastecimento();
            abastecimento.Id = dataReader.GetInt32(0);
            abastecimento.Posto = (Posto)Negocio.NegocioFactory.Instancia.PostoNegocio.Obter(dataReader.GetInt32(1));
            abastecimento.Data = dataReader.GetDateTime(2);
            abastecimento.Observacoes = dataReader.GetString(3);
            abastecimento.TanqueCheio = dataReader.GetBoolean(4);
            abastecimento.TipoCombustivel = (TipoCombustivel)Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Obter(dataReader.GetInt32(5));
            abastecimento.Valor = dataReader.GetDecimal(6);
            abastecimento.ValorLitro = dataReader.GetDecimal(7);
            return abastecimento;
        }

        #endregion
    }
}
