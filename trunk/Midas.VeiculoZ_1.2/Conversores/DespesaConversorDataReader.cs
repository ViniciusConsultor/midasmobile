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
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Conversores
{
    public class DespesaConversorDataReader:IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Despesa despesa = new Despesa();
            despesa.Id = dataReader.GetInt32(0);
            despesa.Descricao = dataReader.GetString(1);
            despesa.Data = dataReader.GetDateTime(2);
            despesa.Empresa = (PessoaJuridica) Nucleo.Negocio.NegocioFactory.Instancia.PessoaJuridicaNegocio.Obter(dataReader.GetInt32(3));
            despesa.Valor = (double)dataReader.GetDecimal(4);
            despesa.Tipo = (TipoDespesa)Negocio.NegocioFactory.Instancia.TipoDespesaNegocio.Obter(dataReader.GetInt32(5));
            despesa.Veiculo = (Veiculo)Negocio.NegocioFactory.Instancia.VeiculoNegocio.Obter(dataReader.GetInt32(6));
            return despesa;
        }

        #endregion
    }
}
