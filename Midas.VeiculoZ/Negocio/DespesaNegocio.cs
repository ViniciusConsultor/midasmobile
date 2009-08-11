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
using Midas.VeiculoZ.DTO;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Negocio
{
    public class DespesaNegocio:NegocioGenerico, IDespesaNegocio
    {
        public DespesaNegocio()
        {
            this.AcessoDados = new DespesaDados();
        }

        #region IDespesaNegocio Members

        public System.Collections.IList ListarPorVeiculo(long id)
        {
            DespesaDados despesaDados = (DespesaDados)this.AcessoDados;
            return despesaDados.ListarPorVeiculo(id);
        }

        public IList ListarRelatorioDespesasPorVeiculoPeriodo(long idveiculo, DateTime data1, DateTime data2)
        {
            IList lista = new ArrayList();
            RelatorioDespesasDTO rd1 = new RelatorioDespesasDTO();
            rd1.Valor = Negocio.NegocioFactory.Instancia.MultaNegocio.ObterGastoTotalPorPeriodoVeiculo(idveiculo, data1, data2);
            rd1.TipoDespesa = "Multas";
            lista.Add(rd1);

            RelatorioDespesasDTO rd2 = new RelatorioDespesasDTO();
            rd2.Valor = NegocioFactory.Instancia.PercursoNegocio.ObterGastoTotalPorVeiculoPeriodo(idveiculo, data1, data2);
            rd2.TipoDespesa = "Abastecimentos";
            lista.Add(rd2);

            DespesaDados despesaDados = (DespesaDados)this.AcessoDados;
            IList tiposDespesa = NegocioFactory.Instancia.TipoDespesaNegocio.Listar();
            for (int i = 0; i < tiposDespesa.Count; i++)
            {
                TipoDespesa tipoDespesa = (TipoDespesa)tiposDespesa[i];
                IList despesas = despesaDados.ListarPorVeiculoTipoPeriodo(idveiculo, tipoDespesa.Id, data1, data2);
                RelatorioDespesasDTO rd = new RelatorioDespesasDTO();
                rd.Valor = 0;
                rd.TipoDespesa = tipoDespesa.Nome;
                for (int j = 0; j < despesas.Count; j++)
                {
                    Despesa despesa = (Despesa)despesas[j];
                    rd.Valor += despesa.Valor;
                }
                lista.Add(rd);
            }
            return lista;
        }

        #endregion
    }
}
