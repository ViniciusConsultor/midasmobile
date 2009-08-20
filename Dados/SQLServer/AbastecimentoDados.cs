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
    public class AbastecimentoDados:IAbastecimentoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Abastecimento abastecimento = (Abastecimento)objeto;
            if (abastecimento.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirAbastecimento, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@data", abastecimento.Data);
                comando.AdicionarParametro("@observacoes", abastecimento.Observacoes);
                comando.AdicionarParametro("@idposto", abastecimento.Posto.Id);
                comando.AdicionarParametro("@tanquecheio", abastecimento.TanqueCheio);
                comando.AdicionarParametro("@idtipoabastecimento", abastecimento.TipoCombustivel.Id);
                comando.AdicionarParametro("@valor", abastecimento.Valor);
                comando.AdicionarParametro("@valorlitro", abastecimento.ValorLitro);
                abastecimento.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarAbastecimento, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@data", abastecimento.Data);
                comando.AdicionarParametro("@observacoes", abastecimento.Observacoes);
                comando.AdicionarParametro("@idposto", abastecimento.Posto.Id);
                comando.AdicionarParametro("@tanquecheio", abastecimento.TanqueCheio);
                comando.AdicionarParametro("@idtipoabastecimento", abastecimento.TipoCombustivel.Id);
                comando.AdicionarParametro("@valor", abastecimento.Valor);
                comando.AdicionarParametro("@valorlitro", abastecimento.ValorLitro);
                comando.AdicionarParametro("@id", abastecimento.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirAbastecimento, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarAbastecimento, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.AbastecimentoConversorDataReader());
            if (lista.Count > 0)
                return (Abastecimento)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosAbastecimentos, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            return comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.AbastecimentoConversorDataReader());
        }

        #endregion


        #region IAbastecimentoDados Members

        public Abastecimento ObterSimplificado(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarAbastecimento, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.AbastecimentoVisaoConversorDataReader());
            if (lista.Count > 0)
                return (Abastecimento)lista[0];
            return null;
        }

        #endregion
    }
}
