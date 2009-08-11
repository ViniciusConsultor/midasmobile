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
using Midas.Nucleo.Negocio;
using Midas.VeiculoZ.Objetos;
using Midas.VeiculoZ.Dados.SQLServer;
using System.Collections;
using Midas.VeiculoZ.DTO;

namespace Midas.VeiculoZ.Negocio
{

    public class PercursoNegocio:NegocioGenerico, IPercursoNegocio
    {

        public PercursoNegocio()
        {
            this.AcessoDados = new Dados.SQLServer.PercursoDados();
        }

        public override void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Percurso percurso = (Percurso)objeto;
            
            Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.Salvar(percurso.AbastecimentoInicial);
            if (percurso.AbastecimentoFinal != null)
            {
                Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.Salvar(percurso.AbastecimentoFinal);
            }

            if (percurso.Id == 0)
            {
                Percurso ultimoPercurso = this.ObterUltimoPercursoPorVeiculo(percurso.Veiculo.Id);
                if (ultimoPercurso != null)
                {
                    if (percurso.OdometroInicio <= ultimoPercurso.OdometroInicio)
                    {
                        throw new Exception("O Percurso atual deve ter o KM Inicial maior que o KM Inicial do último abastecimento. Valor anterior: " + ultimoPercurso.OdometroInicio.ToString());
                    }
                    ultimoPercurso.AbastecimentoFinal = percurso.AbastecimentoInicial;
                    ultimoPercurso.OdometroFim = percurso.OdometroInicio;
                    base.Salvar(ultimoPercurso);
                }
            }
            else
            {
                PercursoDados dados = (PercursoDados)this.AcessoDados;
                int id = dados.ObterIdAbastecimentoFinal(percurso.Id);
                if (id != 0)
                {
                    Abastecimento abast = new Abastecimento();
                    abast.Id = id;
                    percurso.AbastecimentoFinal = abast;
                }
                IList percursos = this.ObterPercursosPorAbastecimentoFinal(percurso.AbastecimentoInicial.Id);
                if (percursos.Count > 0)
                {
                    Percurso ultimoPercurso = (Percurso)percursos[0];
                    if (ultimoPercurso != null)
                    {
                        if (percurso.OdometroInicio <= ultimoPercurso.OdometroInicio)
                        {
                            throw new Exception("O Percurso atual deve ter o KM Inicial maior que o KM Inicial do último abastecimento. Valor anterior: " + ultimoPercurso.OdometroInicio.ToString());
                        }
                        if (ultimoPercurso.AbastecimentoInicial.Data > percurso.AbastecimentoInicial.Data)
                        {
                            if (ultimoPercurso.OdometroInicio >= percurso.OdometroInicio)
                            {
                                throw new Exception("As informações deste abastecimento gerarão inconsistências. Este abastecimento tem data anterior ao último abastecimento realizado e Quilometragem inicial menor.");
                            }
                        }
                        ultimoPercurso.OdometroFim = percurso.OdometroInicio;
                        base.Salvar(ultimoPercurso);
                    }
                }
            }

            // Salvar o Percurso.
            base.Salvar(percurso);
        }

        public override void Excluir(long id)
        {
            Percurso percurso = (Percurso)this.Obter(id);
            if (percurso.AbastecimentoInicial != null)
            {
                IList percursos = this.ObterPercursosPorAbastecimentoFinal(percurso.AbastecimentoInicial.Id);
                for (int i = 0; i < percursos.Count; i++)
                {
                    Percurso p = (Percurso)percursos[i];
                    p.AbastecimentoFinal = null;
                    p.OdometroFim = 0;
                    base.Salvar(p);
                }
            }
            long idAbast = percurso.AbastecimentoInicial.Id;
            base.Excluir(id);
            if (percurso.AbastecimentoInicial != null)
            {
                Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.Excluir(idAbast);
            }
        }

        public Percurso ObterUltimoPercursoPorVeiculo(long id)
        {
            PercursoDados dados = (PercursoDados) this.AcessoDados;
            return dados.ObterUltimoPercursoPorVeiculo(id);
        }

        public IList ListarVisao()
        {
            PercursoDados dados = (PercursoDados) this.AcessoDados;
            return dados.ListarDadosVisao();
        }


        #region IPercursoNegocio Members

        public float ObterConsumoMedioVeiculo(long id)
        {
            PercursoDados dados = (PercursoDados) this.AcessoDados;
            IList percursos = dados.ListarPorVeiculoVisao(id);
            float consumoMedio = 0;
            int contador = 0;
            for (int i = 0; i < percursos.Count; i++)
            {
                Percurso p = (Percurso)percursos[i];
                if (p.ConsumoMedio > 0)
                {
                    consumoMedio += p.ConsumoMedio;
                    contador++;
                }
            }
            if (consumoMedio == 0)
            {
                return 0;
            }
            return consumoMedio / (contador);
        }

        public IList ListarPercursosPorVeiculo(long id)
        {
            PercursoDados dados = (PercursoDados) this.AcessoDados;
            return dados.ListarPorVeiculoVisao(id);
        }

        public IList ObterPercursosPorAbastecimentoFinal(long id)
        {
            PercursoDados dados = (PercursoDados) this.AcessoDados;
            return dados.ObterPorAbastecimentoFinal(id);
        }

        public IList ListarPercursos(long idVeiculo, long idTipoAbastecimento, long idPosto, DateTime data1, DateTime data2, bool viagem)
        {
            PercursoDados dados = (PercursoDados) this.AcessoDados;
            return dados.ListarPercursos(idVeiculo, idTipoAbastecimento, idPosto, data1, data2, viagem);
        }

        public Midas.VeiculoZ.DTO.RelatorioGeralDTO ObterRelatorioGeral(long id)
        {
            PercursoDados dados = (PercursoDados)this.AcessoDados;
            RelatorioGeralDTO dto = new RelatorioGeralDTO();
            dto.TotalKM = dados.ObterTotalKMPorVeiculo(id).ToString() + " Km rodados";
            dto.TotalLitros = dados.ObterTotalLitrosPorVeiculo(id).ToString("N2") + " Litros";
            dto.GastoTotal = "R$ " + dados.ObterGastoTotalPorVeiculo(id).ToString("N2");
            Percurso melhor = dados.ObterPercursoMaiorConsumoMedio(id);
            Percurso pior = dados.ObterPercursoMenorConsumoMedio(id);
            if (melhor != null)
            {
                dto.MelhorPosto = melhor.AbastecimentoInicial.Posto.Nome + " - " + melhor.ConsumoMedio.ToString("N2") + " Km/L";
            }
            else
            {
                dto.MelhorPosto = "N/D";
            }
            if (pior != null)
            {
                dto.PiorPosto = pior.AbastecimentoInicial.Posto.Nome + " - " + pior.ConsumoMedio.ToString("N2") + " Km/L";
            }
            else
            {
                dto.PiorPosto = "N/D";
            }
            return dto;
        }

        public double ObterGastoTotalPorVeiculoPeriodo(long id, DateTime d1, DateTime d2)
        {
            PercursoDados dados = (PercursoDados)this.AcessoDados;
            return dados.ObterGastoTotalPorVeiculoPeriodo(id, d1, d2);
        }


        #endregion
    }

}