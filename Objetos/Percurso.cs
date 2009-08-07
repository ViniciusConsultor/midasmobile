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

namespace Midas.VeiculoZ.Objetos
{

    /// <summary>
    /// Classe que representa um Percurso realizado por um Veículo.
    /// </summary>
    public class Percurso:ObjetoNegocio
    {

        public long KmRodados
        {
            get
            {
                if (odometroFim <= 0)
                {
                    return 0;
                }
                return odometroFim - odometroInicio;
            }
        }

        public float ConsumoMedio
        {
            get
            {
                if (abastecimentoInicial != null && abastecimentoFinal != null)
                {
                    if (KmRodados <= 0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (LitrosConsumidos <= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return (float)(KmRodados / LitrosConsumidos);
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public double LitrosConsumidos
        {
            get
            {
                if (abastecimentoInicial != null && abastecimentoFinal != null)
                {
                    if (abastecimentoInicial.TanqueCheio && abastecimentoFinal.TanqueCheio)
                    {
                        return abastecimentoFinal.Litros;
                    }
                    else
                    {
                        return abastecimentoInicial.Litros;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Valor marcado no odômetro no início do percurso.
        /// </summary>
        private long odometroInicio;
        public long OdometroInicio
        {
            get { return odometroInicio; }
            set { odometroInicio = value; }
        }

        /// <summary>
        /// Valor marcado no odômetro no final do percurso.
        /// </summary>
        private long odometroFim;
        public long OdometroFim
        {
            get { return odometroFim; }
            set { odometroFim = value; }
        }

        /// <summary>
        /// Identifica se este percurso foi realizado em uma viagem.
        /// </summary>
        private Boolean viagem;
        public Boolean Viagem
        {
            get { return viagem; }
            set { viagem = value; }
        }

        /// <summary>
        /// O abastecimento usado no início do Percurso.
        /// </summary>
        private Abastecimento abastecimentoInicial;
        public Abastecimento AbastecimentoInicial
        {
            get { return abastecimentoInicial; }
            set { abastecimentoInicial = value; }
        }

        /// <summary>
        /// Abastecimento realizado ao final do Percurso.
        /// </summary>
        private Abastecimento abastecimentoFinal;
        public Abastecimento AbastecimentoFinal
        {
            get { return abastecimentoFinal; }
            set { abastecimentoFinal = value; }
        }

        /// <summary>
        /// Veículo usado no Percurso.
        /// </summary>
        private Veiculo veiculo;
        public Veiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        public string DescricaoDetalhada
        {
            get
            {
                return this.AbastecimentoInicial.Data.ToString("dd/MM/yyyy") + " - " + this.KmRodados.ToString() + "Km com " + this.LitrosConsumidos.ToString("N2") + "L = " + this.ConsumoMedio.ToString("N2") + "Km/L";
            }
        }

    }
}