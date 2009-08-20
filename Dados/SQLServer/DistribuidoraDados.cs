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
using Midas.Nucleo.Dados;
using Midas.VeiculoZ.Objetos;
using System.Collections;
using Midas.Nucleo.Dados.SQLServerCE;

namespace Midas.VeiculoZ.Dados.SQLServer
{
    public class DistribuidoraDados:IAcessoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Distribuidora distribuidora = (Distribuidora)objeto;
            if (distribuidora.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirDistribuidora, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@nome", distribuidora.Nome);
                distribuidora.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarDistribuidora, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@nome", distribuidora.Nome);
                comando.AdicionarParametro("@id", distribuidora.Id);
                comando.Executar();
            }

        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirDistribuidora, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarDistribuidora, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.DistribuidoraConversorDataReader());
            if (lista.Count > 0)
                return (Distribuidora)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            ComandoDireto comando = new ComandoDireto(Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ, "Distribuidora");
            IList lista = comando.ListarTabela(new Midas.VeiculoZ.Conversores.DistribuidoraConversorDataReader());
            return lista;
        }

        #endregion

    }
}
