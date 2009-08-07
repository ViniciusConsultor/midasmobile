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
using System.Data;

namespace Midas.VeiculoZ.Dados.SQLServer
{
    public class PercursoDados:IPercursoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Percurso percurso = (Percurso)objeto;
            if (percurso.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@odometroinicial", percurso.OdometroInicio);
                comando.AdicionarParametro("@odometrofinal", percurso.OdometroFim);
                comando.AdicionarParametro("@viagem", percurso.Viagem);
                comando.AdicionarParametro("@consumomedio", percurso.ConsumoMedio);
                comando.AdicionarParametro("@idabastecimentoinicial", percurso.AbastecimentoInicial.Id);
                if (percurso.AbastecimentoFinal != null)
                {
                    comando.AdicionarParametro("@idabastecimentofinal", percurso.AbastecimentoFinal.Id);
                }
                else
                {
                    comando.AdicionarParametro("@idabastecimentofinal", DBNull.Value);
                }
                comando.AdicionarParametro("@idveiculo", percurso.Veiculo.Id);
                percurso.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@odometroinicial", percurso.OdometroInicio);
                comando.AdicionarParametro("@odometrofinal", percurso.OdometroFim);
                comando.AdicionarParametro("@viagem", percurso.Viagem);
                comando.AdicionarParametro("@idveiculo", percurso.Veiculo.Id);
                comando.AdicionarParametro("@idabastecimentoinicial", percurso.AbastecimentoInicial.Id);
                comando.AdicionarParametro("@consumomedio", percurso.ConsumoMedio);
                if (percurso.AbastecimentoFinal != null)
                {
                    comando.AdicionarParametro("@idabastecimentofinal", percurso.AbastecimentoFinal.Id);
                }
                else
                {
                    comando.AdicionarParametro("@idabastecimentofinal", DBNull.Value);
                }
                comando.AdicionarParametro("@id", percurso.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
            if (lista.Count > 0)
                return (Percurso)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosPercursos, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            return comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
        }

        public IList ListarPercursos(long idVeiculo, long idTipoAbastecimento, long idPosto, DateTime data1, DateTime data2, bool viagem)
        {
            string sql = "select * from percurso where idveiculo=@idveiculo";
            if (!viagem)
            {
                sql += " and viagem = 0 ";
            }
            if (idTipoAbastecimento != -1)
            {
                sql += " and idabastecimentoinicial in (select id from abastecimento where idtipoabastecimento = @idtipoabastecimento)";
            }
            if (idPosto != -1)
            {
                sql += " and idabastecimentoinicial in (select id from abastecimento where idposto = @idposto)";
            }
            sql += " and idabastecimentoinicial in (select id from abastecimento where data >= @data1 and data <= @data2)";
            Comando comando = new Comando(sql, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", idVeiculo);
            comando.AdicionarParametro("@idtipoabastecimento", idTipoAbastecimento);
            comando.AdicionarParametro("@idposto", idPosto);
            comando.AdicionarParametro("@data1", data1);
            comando.AdicionarParametro("@data2", data2);
            return comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoVisaoConversorDataReader());
        }

        #endregion


        #region IPercursoDados Members

        public Percurso ObterUltimoPercursoPorVeiculo(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarUltimoPercursoPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            return (Percurso)comando.ExecutarQueryRetornarPrimeiroResultado(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
        }

        public Percurso ObterPercursoMaiorConsumoMedio(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPercursosPorConsumoMedioDescendente, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            return (Percurso)comando.ExecutarQueryRetornarPrimeiroResultado(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
        }

        public Percurso ObterPercursoMenorConsumoMedio(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPercursosPorConsumoMedioAscendente, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            return (Percurso)comando.ExecutarQueryRetornarPrimeiroResultado(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
        }

        public int ObterIdAbastecimentoFinal(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarIdAbastecimentoFinalPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            object o = comando.ObterValorEscalar();
            if (o != DBNull.Value)
            {
                return (int)comando.ObterValorEscalar();
            }
            else
            {
                return 0;
            }
        }

        public IList ListarDadosVisao()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosPercursos, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            return comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoVisaoConversorDataReader());
        }

        public IList ListarPorVeiculoVisao(long id)
        {
            ComandoDireto comandoDireto = new ComandoDireto(Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ, "percurso");
            IList lista = comandoDireto.ListarTabela("IdxPercursoVeiculo", (int)id, "idveiculo", new Midas.VeiculoZ.Conversores.PercursoVisaoConversorDataReader());
            ArrayList array = (ArrayList)lista;
            array.Sort(new ComparadorDataPercursos());
            return array;
        }

        public IList ListarPorVeiculoCompleto(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPercursosPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
            return lista;
        }

        public IList ObterPorAbastecimentoFinal(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPercursosPorAbastecimentoFinal, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idabastecimentofinal", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
            return lista;
        }

        public decimal ObterTotalKMPorVeiculo(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTotalKMPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            object o = comando.ObterValorEscalar();
            if (o != DBNull.Value)
                return (long)o;
            return 0;
        }

        public decimal ObterGastoTotalPorVeiculo(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarGastoTotalPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            object o = comando.ObterValorEscalar();
            if (o != DBNull.Value)
                return (decimal)o;
            return 0;
        }

        public decimal ObterTotalLitrosPorVeiculo(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTotalLitrosPorVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@idveiculo", id);
            object o = comando.ObterValorEscalar();
            if (o != DBNull.Value)
                return (decimal)o;
            return 0;
        }

        #endregion
    }
}

class ComparadorDataPercursos:IComparer {
    #region IComparer Members

    public int Compare(object x, object y)
    {
        Percurso px = (Percurso)x;
        Percurso py = (Percurso)y;
        return py.AbastecimentoInicial.Data.CompareTo(px.AbastecimentoInicial.Data);
    }

    #endregion
}