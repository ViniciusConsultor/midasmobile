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
    public class SituacaoMultaDados:IAcessoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            SituacaoMulta situacao = (SituacaoMulta)objeto;
            if (situacao.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirSituacaoMulta, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@nome", situacao.Nome);
                situacao.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarSituacaoMulta, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@nome", situacao.Nome);
                comando.AdicionarParametro("@id", situacao.Id);
                comando.Executar();
            }

        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirSituacaoMulta, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarSituacaoMulta, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.SituacaoMultaConversorDataReader());
            if (lista.Count > 0)
                return (SituacaoMulta)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            ComandoDireto comando = new ComandoDireto(Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ, "SituacaoMulta");
            IList lista = comando.ListarTabela(new Midas.VeiculoZ.Conversores.SituacaoMultaConversorDataReader());
            return lista;
        }

        #endregion
    }
}
