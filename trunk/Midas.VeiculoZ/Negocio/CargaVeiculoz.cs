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
using Midas.VeiculoZ.Recursos;
using Midas.Nucleo.Recursos;
using Midas.Nucleo.Dados.SQLServerCE;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Negocio
{

    /// <summary>
    /// Carga do Sistema VeículoZ.
    /// </summary>
    public class CargaVeiculoz:Midas.Nucleo.Negocio.ICargaSistema
    {

        #region ICargaSistema Members

        public void Iniciar()
        {
            SQLServerCE servidor = new SQLServerCE(Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);

            // Criar o banco de dados para o Financeiro.
            if (!servidor.BancoExiste())
            {
                servidor.CriarBancoDados();
                this.IniciarTabelas();
                this.CriarDadosIniciais();
            }
            else
            {
                this.IniciarTabelas();
            }
            
        }

        private void CriarDadosIniciais()
        {
            SituacaoMulta situacaoEmTramitacao = new SituacaoMulta();
            situacaoEmTramitacao.Nome = "Em Tramitação";
            Negocio.NegocioFactory.Instancia.SituacaoMultaNegocio.Salvar(situacaoEmTramitacao);

            SituacaoMulta situacaoContestada = new SituacaoMulta();
            situacaoContestada.Nome = "Contestada";
            Negocio.NegocioFactory.Instancia.SituacaoMultaNegocio.Salvar(situacaoContestada);

            SituacaoMulta situacaoPago = new SituacaoMulta();
            situacaoPago.Nome = "Pago";
            Negocio.NegocioFactory.Instancia.SituacaoMultaNegocio.Salvar(situacaoPago);

            Distribuidora shell = new Distribuidora();
            shell.Nome = "Shell";
            VeiculozFachada.Instancia.SalvarDistribuidora(shell);

            Distribuidora br = new Distribuidora();
            br.Nome = "BR Distribuidora";
            VeiculozFachada.Instancia.SalvarDistribuidora(br);

            Distribuidora esso = new Distribuidora();
            esso.Nome = "Esso";
            VeiculozFachada.Instancia.SalvarDistribuidora(esso);

            Distribuidora ipiranga = new Distribuidora();
            ipiranga.Nome = "Ipiranga";
            VeiculozFachada.Instancia.SalvarDistribuidora(ipiranga);

            Distribuidora texaco = new Distribuidora();
            texaco.Nome = "Texaco";
            VeiculozFachada.Instancia.SalvarDistribuidora(texaco);

            TipoCombustivel alcool = new TipoCombustivel();
            alcool.Nome = "Álcool";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(alcool);

            TipoCombustivel gasolina = new TipoCombustivel();
            gasolina.Nome = "Gasolina Aditivada";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(gasolina);

            TipoCombustivel gasolina2 = new TipoCombustivel();
            gasolina2.Nome = "Gasolina Comum";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(gasolina2);

            TipoCombustivel gnv = new TipoCombustivel();
            gnv.Nome = "GNV";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(gnv);

            TipoCombustivel diesel = new TipoCombustivel();
            diesel.Nome = "Diesel";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(diesel);
        }

        private void IniciarTabelas()
        {
            try { new Comando(ConstantesDados.TabelaTipoCombustivel, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaVeiculo, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaDistribuidora, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaPosto, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaAbastecimento, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaPercurso, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaTipoDespesa, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaDespesa, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaManutencao, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaSituacaoMulta, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.TabelaMulta, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
            try { new Comando(ConstantesDados.IndicePercursoVeiculo, ConstantesGerais.BancoVeiculoZ).Executar(); } catch (Exception e) { }
        }

        #endregion

    }

}
