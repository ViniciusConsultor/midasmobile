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
    public class MultaDados:IMultaDados
    {
        #region IAcessoDados Members
        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Multa multa = (Multa)objeto;
            if (multa.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirMulta, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@idinfracao", multa.Infracao.Id);
                comando.AdicionarParametro("@local", multa.Local);
                comando.AdicionarParametro("@observacoes", multa.Observacoes);
                comando.AdicionarParametro("@idsituacao", multa.Situacao.Id);
                comando.AdicionarParametro("@idveiculo", multa.Veiculo.Id);
                comando.AdicionarParametro("@data", multa.Data);
                comando.AdicionarParametro("@datavencimento", multa.DataVencimento);
                multa.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarMulta, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@idinfracao", multa.Infracao.Id);
                comando.AdicionarParametro("@local", multa.Local);
                comando.AdicionarParametro("@observacoes", multa.Observacoes);
                comando.AdicionarParametro("@idsituacao", multa.Situacao.Id);
                comando.AdicionarParametro("@idveiculo", multa.Veiculo.Id);
                comando.AdicionarParametro("@data", multa.Data);
                comando.AdicionarParametro("@datavencimento", multa.DataVencimento);
                comando.AdicionarParametro("@id", multa.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirMulta, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarMulta, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.MultaConversorDataReader());
            if (lista.Count > 0)
                return (Multa)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            ComandoDireto comando = new ComandoDireto(Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ, "Multa");
            IList lista = comando.ListarTabela(new Midas.VeiculoZ.Conversores.MultaConversorDataReader());
            return lista;
        }
        #endregion

        #region IMultaDados Members

        public IList ListarMultasPorVeiculo(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarMultasPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.MultaConversorDataReader());
            return lista;            
        }

        #endregion
    }
}
