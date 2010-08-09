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
    public class ManutencaoDados:IManutencaoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Manutencao m = (Manutencao)objeto;
            if (m.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirManutencao, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@descricao", m.Descricao);
                comando.AdicionarParametro("@lembrarpordata", m.LembrarPorData);
                comando.AdicionarParametro("@data", m.Data);
                comando.AdicionarParametro("@km", m.Km);
                comando.AdicionarParametro("@idveiculo", m.Veiculo.Id);
                comando.AdicionarParametro("@verificado", m.Verificado);
                m.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarManutencao, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@descricao", m.Descricao);
                comando.AdicionarParametro("@lembrarpordata", m.LembrarPorData);
                comando.AdicionarParametro("@data", m.Data);
                comando.AdicionarParametro("@km", m.Km);
                comando.AdicionarParametro("@idveiculo", m.Veiculo.Id);
                comando.AdicionarParametro("@verificado", m.Verificado);
                comando.AdicionarParametro("@id", m.Id);
                comando.Executar();
            }

        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirManutencao, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarManutencao, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.ManutencaoConversorDataReader());
            if (lista.Count > 0)
                return (Manutencao)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodasManutencoesPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.ManutencaoConversorDataReader());
            return lista;
        }

        public System.Collections.IList LocalizarPorVeiculo(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodasManutencoesPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.ManutencaoConversorDataReader());
            return lista;
        }

        #endregion

        #region IManutencaoDados Members

        public IList ListarPorKM(decimal km, long idveiculo)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarManutencoesPorKMVeiculoNaoVerificados, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", idveiculo);
            comando.AdicionarParametro("@km", km);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.ManutencaoConversorDataReader());
            return lista;
        }

        public IList ListarPorData(DateTime data, long idveiculo)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarManutencoesPorDataVeiculoNaoVerificados, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", idveiculo);
            comando.AdicionarParametro("@data", data);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.ManutencaoConversorDataReader());
            return lista;
        }

        #endregion
    }
}

