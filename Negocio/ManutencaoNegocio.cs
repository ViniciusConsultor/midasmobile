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
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Negocio;
using Midas.VeiculoZ.Dados.SQLServer;
using System.Collections;

namespace Midas.VeiculoZ.Negocio
{
    public class ManutencaoNegocio:NegocioGenerico,IManutencaoNegocio
    {
        public ManutencaoNegocio()
        {
            this.AcessoDados = new ManutencaoDados();
        }

        public IList ListarPorVeiculo(long id)
        {
            ManutencaoDados dados = (ManutencaoDados)this.AcessoDados;
            return dados.LocalizarPorVeiculo(id);
        }

        #region IManutencaoNegocio Members

        public IList ListarPorKM(decimal km, long idveiculo)
        {
            ManutencaoDados dados = (ManutencaoDados)this.AcessoDados;
            return dados.ListarPorKM(km, idveiculo);
        }

        public IList ListarPorData(DateTime data, long idveiculo)
        {
            ManutencaoDados dados = (ManutencaoDados)this.AcessoDados;
            return dados.ListarPorData(data, idveiculo);
        }

        #endregion
    }

}
