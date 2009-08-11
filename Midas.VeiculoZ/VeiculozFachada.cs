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
using Midas.VeiculoZ.Objetos;
using System.Collections;

namespace Midas.VeiculoZ
{

    /// <summary>
    /// Fachada da aplicação.
    /// </summary>
    public class VeiculozFachada
    {

        /// <summary>
        /// Singleton.
        /// </summary>
        private static VeiculozFachada instancia = new VeiculozFachada();
        public static VeiculozFachada Instancia
        {
            get { return VeiculozFachada.instancia; }
            set { VeiculozFachada.instancia = value; }
        }

        private VeiculozFachada() { }

        #region IVeiculozFachada Members

        public System.Collections.IList  ListarTiposCombustivel()
        {
            return Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Listar();
        }

        public void SalvarTipoCombustivel(Midas.VeiculoZ.Objetos.TipoCombustivel tipo)
        {
            Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Salvar(tipo);
        }

        public void ExcluirTipoCombustivel(long id)
        {
            Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Excluir(id);
        }

        public System.Collections.IList ListarVeiculos()
        {
            return Negocio.NegocioFactory.Instancia.VeiculoNegocio.Listar();
        }

        public void SalvarVeiculo(Midas.VeiculoZ.Objetos.Veiculo veiculo)
        {
            Negocio.NegocioFactory.Instancia.VeiculoNegocio.Salvar(veiculo);
        }

        public void ExcluirVeiculo(long id)
        {
            Negocio.NegocioFactory.Instancia.VeiculoNegocio.Excluir(id);
        }

        public System.Collections.IList ListarPostos()
        {
            return Negocio.NegocioFactory.Instancia.PostoNegocio.Listar();
        }

        public void SalvarPosto(Midas.VeiculoZ.Objetos.Posto posto)
        {
            Negocio.NegocioFactory.Instancia.PostoNegocio.Salvar(posto);
        }

        public void ExcluirPosto(long id)
        {
            Negocio.NegocioFactory.Instancia.PostoNegocio.Excluir(id);
        }

        public System.Collections.IList ListarDistribuidoras()
        {
            return Negocio.NegocioFactory.Instancia.DistribuidoraNegocio.Listar();
        }

        public void SalvarDistribuidora(Midas.VeiculoZ.Objetos.Distribuidora distribuidora)
        {
            Negocio.NegocioFactory.Instancia.DistribuidoraNegocio.Salvar(distribuidora);
        }

        public void ExcluirDistribuidora(long id)
        {
            Negocio.NegocioFactory.Instancia.DistribuidoraNegocio.Excluir(id);
        }

        public System.Collections.IList ListarPercursos()
        {
            return Negocio.NegocioFactory.Instancia.PercursoNegocio.ListarVisao();
        }

        public void SalvarPercurso(Midas.VeiculoZ.Objetos.Percurso percurso)
        {
            Negocio.NegocioFactory.Instancia.PercursoNegocio.Salvar(percurso);
        }

        public void ExcluirPercurso(long id)
        {
            Negocio.NegocioFactory.Instancia.PercursoNegocio.Excluir(id);
        }


        public Midas.VeiculoZ.Objetos.Percurso ObterUltimoPercursoPorVeiculo(long id)
        {
            return Negocio.NegocioFactory.Instancia.PercursoNegocio.ObterUltimoPercursoPorVeiculo(id);
        }

        public Midas.VeiculoZ.Objetos.Percurso ObterPercurso(long id)
        {
            return (Percurso)Negocio.NegocioFactory.Instancia.PercursoNegocio.Obter(id);
        }

        public float ObterConsumoMedioVeiculo(long id)
        {
            return Negocio.NegocioFactory.Instancia.PercursoNegocio.ObterConsumoMedioVeiculo(id);
        }

        public System.Collections.IList ListarPercursosPorVeiculo(long id)
        {
            return Negocio.NegocioFactory.Instancia.PercursoNegocio.ListarPercursosPorVeiculo(id);
        }

        public System.Collections.IList ListarPercursos(long idVeiculo, long idTipoAbastecimento, long idPosto, DateTime data1, DateTime data2, bool viagem)
        {
            return Negocio.NegocioFactory.Instancia.PercursoNegocio.ListarPercursos(idVeiculo, idTipoAbastecimento, idPosto, data1, data2, viagem);
        }

        public void SalvarTipoDespesa(TipoDespesa tipoDespesa)
        {
            Negocio.NegocioFactory.Instancia.TipoDespesaNegocio.Salvar(tipoDespesa);
        }

        public void ExcluirTipoDespesa(long id)
        {
            Negocio.NegocioFactory.Instancia.TipoDespesaNegocio.Excluir(id);
        }

        public System.Collections.IList ListarTodosTiposDespesa()
        {
            return Negocio.NegocioFactory.Instancia.TipoDespesaNegocio.Listar();
        }

        public void SalvarDespesa(Despesa despesa)
        {
            Negocio.NegocioFactory.Instancia.DespesaNegocio.Salvar(despesa);
        }

        public void ExcluirDespesa(long id)
        {
            Negocio.NegocioFactory.Instancia.DespesaNegocio.Excluir(id);
        }

        public System.Collections.IList ListarDespesasPorVeiculo(long id)
        {
            return Negocio.NegocioFactory.Instancia.DespesaNegocio.ListarPorVeiculo(id);
        }

        public Midas.VeiculoZ.DTO.RelatorioGeralDTO ObterRelatorioGeral(long id)
        {
           return Negocio.NegocioFactory.Instancia.PercursoNegocio.ObterRelatorioGeral(id);
        }

        public void SalvarManutencao(Manutencao m)
        {
            Negocio.NegocioFactory.Instancia.ManutencaoNegocio.Salvar(m);
        }

        public void ExcluirManutencao(long id)
        {
            Negocio.NegocioFactory.Instancia.ManutencaoNegocio.Excluir(id);
        }

        public System.Collections.IList ListarManutencoesPorVeiculo(long id)
        {
            return Negocio.NegocioFactory.Instancia.ManutencaoNegocio.ListarPorVeiculo(id);
        }

        public System.Collections.IList ListarManutencoesVeiculoPorKM(decimal km, long idveiculo)
        {
            return Negocio.NegocioFactory.Instancia.ManutencaoNegocio.ListarPorKM(km, idveiculo);
        }

        public IList ListarManutencoesVeiculoPorData(DateTime data, long idveiculo)
        {
           return Negocio.NegocioFactory.Instancia.ManutencaoNegocio.ListarPorData(data, idveiculo);
        }

        public void SalvarMotorista(Motorista motorista)
        {
            Negocio.NegocioFactory.Instancia.MotoristaNegocio.Salvar(motorista);
        }

        public Motorista ObterMotorista()
        {
            return (Motorista)Negocio.NegocioFactory.Instancia.MotoristaNegocio.Obter(1);
        }

        public Multa ObterMulta(long id)
        {
            return (Multa)Negocio.NegocioFactory.Instancia.MultaNegocio.Obter(id);
        }

        public void SalvarMulta(Multa multa)
        {
            Negocio.NegocioFactory.Instancia.MultaNegocio.Salvar(multa);
        }

        public void ExcluirMulta(long id)
        {
            Negocio.NegocioFactory.Instancia.MultaNegocio.Excluir(id);
        }

        public IList ListarMultasPorVeiculo(long id)
        {
            return Negocio.NegocioFactory.Instancia.MultaNegocio.ListarMultasPorVeiculo(id);
        }

        public IList ListarSituacoesMulta()
        {
            return Negocio.NegocioFactory.Instancia.SituacaoMultaNegocio.Listar();
        }

        public IList ListarInfracoesPorClassificacaoDescricao(long id, string descricao)
        {
            return Negocio.NegocioFactory.Instancia.InfracaoNegocio.ListarInfracoesPorClassificacaoDescricao(id, descricao);
        }

        public IList ListarClassificacoesInfracao()
        {
            return Negocio.NegocioFactory.Instancia.ClassificacaoInfracaoNegocio.Listar();
        }

        public Infracao ObterInfracao(long id)
        {
            return (Infracao)Negocio.NegocioFactory.Instancia.InfracaoNegocio.Obter(id);
        }

        public IList ListarRelatorioDespesasPorVeiculoPeriodo(long idveiculo, DateTime data1, DateTime data2)
        {
            return Negocio.NegocioFactory.Instancia.DespesaNegocio.ListarRelatorioDespesasPorVeiculoPeriodo(idveiculo, data1, data2);
        }

        #endregion
    }

}
