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
using Midas.Nucleo.Dados;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Dados.SQLServerCE;
using System.Collections;

namespace Midas.VeiculoZ.Dados.SQLServer
{
    public class DespesaDados:IDespesaDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Despesa despesa = (Despesa)objeto;
            if (despesa.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirDespesa, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@descricao", despesa.Descricao);
                comando.AdicionarParametro("@data", despesa.Data);
                comando.AdicionarParametro("@idtipo", despesa.Tipo.Id);
                comando.AdicionarParametro("@valor", despesa.Valor);
                comando.AdicionarParametro("@idempresa", despesa.Empresa.Id);
                comando.AdicionarParametro("@idveiculo", despesa.Veiculo.Id);
                despesa.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarDespesa, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@descricao", despesa.Descricao);
                comando.AdicionarParametro("@data", despesa.Data);
                comando.AdicionarParametro("@idtipo", despesa.Tipo.Id);
                comando.AdicionarParametro("@valor", despesa.Valor);
                comando.AdicionarParametro("@idempresa", despesa.Empresa.Id);
                comando.AdicionarParametro("@idveiculo", despesa.Veiculo.Id);
                comando.AdicionarParametro("@id", despesa.Id);
                comando.Executar();
            }

        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirDespesa, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarDespesa, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.DespesaConversorDataReader());
            if (lista.Count > 0)
                return (Despesa)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodasDespesas, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.DespesaConversorDataReader());
            return lista;
        }

        #endregion

        #region IDespesaDados Members

        public IList ListarPorVeiculo(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarDespesasPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.DespesaConversorDataReader());
            return lista;
        }

        public IList ListarPorVeiculoTipoPeriodo(long idveiculo, long idtipo, DateTime data1, DateTime data2)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarDespesasPorVeiculoTipoPeriodo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", idveiculo);
            comando.AdicionarParametro("@idtipo", idtipo);
            comando.AdicionarParametro("@data1", data1);
            comando.AdicionarParametro("@data2", data2);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.DespesaConversorDataReader());
            return lista;
        }

        #endregion
    }
}
