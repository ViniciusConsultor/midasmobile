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
using Midas.Nucleo.Objetos;
using Midas.Nucleo.Dados;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Dados.SQLServerCE;
using System.Collections;

namespace Midas.VeiculoZ.Dados.SQLServer
{
    public class ClassificacaoInfracaoDados:IAcessoDados
    {

        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            ClassificacaoInfracao ci = (ClassificacaoInfracao)objeto;
            if (ci.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirClassificacaoInfracao, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@descricao", ci.Descricao);
                comando.AdicionarParametro("@pontos", ci.Pontos);
                ci.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarClassificacaoInfracao, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@descricao", ci.Descricao);
                comando.AdicionarParametro("@pontos", ci.Pontos);
                comando.AdicionarParametro("@id", ci.Id);
                comando.Executar();
            }

        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirClassificacaoInfracao, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarClassificacaoInfracao, Midas.Nucleo.Recursos.ConstantesGerais.BancoInfracoes);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.ClassificacaoInfracaoConversorDataReader());
            if (lista.Count > 0)
                return (ClassificacaoInfracao)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            ComandoDireto comando = new ComandoDireto(Midas.Nucleo.Recursos.ConstantesGerais.BancoInfracoes, "ClassificacaoInfracao");
            IList lista = comando.ListarTabela(new Midas.VeiculoZ.Conversores.ClassificacaoInfracaoConversorDataReader());
            return lista;
        }

        #endregion
    }
}
