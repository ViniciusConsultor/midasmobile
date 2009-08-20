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
using System.Collections;
using System.Linq;
using System.Text;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Dados.SQLServerCE;
using Midas.Nucleo.Dados;

namespace Midas.VeiculoZ.Dados.SQLServer
{

    /// <summary>
    /// Acesso a Dados por SQL Server CE para Postos.
    /// </summary>
    public class PostoDados:IAcessoDados
    {

        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Posto posto = (Posto)objeto;
            if (posto.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirPosto, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@observacoes", posto.Observacoes);
                comando.AdicionarParametro("@iddistribuidora", posto.Distribuidora.Id.ToString());
                comando.AdicionarParametro("@idpessoajuridica", posto.PessoaJuridica.Id.ToString());
                posto.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarPosto, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@observacoes", posto.Observacoes);
                comando.AdicionarParametro("@iddistribuidora", posto.Distribuidora.Id.ToString());
                comando.AdicionarParametro("@idpessoajuridica", posto.PessoaJuridica.Id.ToString());
                comando.AdicionarParametro("@id", posto.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirPosto, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPosto, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PostoConversorDataReader());
            if (lista.Count > 0)
                return (Posto)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            ComandoDireto comando = new ComandoDireto(Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ, "Posto");
            IList lista = comando.ListarTabela(new Midas.VeiculoZ.Conversores.PostoConversorDataReader());
            return lista;
        }

        #endregion

    }

}
