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
    public class ManutencaoConversorDataReader:IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Manutencao m = new Manutencao();
            m.Id = dataReader.GetInt32(0);
            m.Data = dataReader.GetDateTime(1);
            m.Descricao = dataReader.GetString(2);
            m.Km = dataReader.GetDecimal(3);
            m.Veiculo = (Veiculo)Negocio.NegocioFactory.Instancia.VeiculoNegocio.Obter(dataReader.GetInt32(4));
            m.LembrarPorData = dataReader.GetBoolean(5);
            m.Verificado = dataReader.GetBoolean(6);
            return m;
        }

        #endregion
    }
}
