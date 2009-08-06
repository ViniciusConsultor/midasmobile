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
    /// Classe que representa um abastecimento.
    /// </summary>
    public class Abastecimento:ObjetoNegocio
    {

        public decimal Litros
        {
            get
            {
                if (this.valorLitro <= 0)
                {
                    return 0;
                }
                else
                {
                    return this.Valor / this.ValorLitro;
                }
            }
        }

        /// <summary>
        /// Data em que foi realizado o abastecimento.
        /// </summary>
        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Posto em que foi realizado o abastecimento.
        /// </summary>
        private Posto posto;
        public Posto Posto
        {
            get { return posto; }
            set { posto = value; }
        }

        /// <summary>
        /// Identifica se no abastecimento o tanque foi completado ou não.
        /// </summary>
        private Boolean tanqueCheio;
        public Boolean TanqueCheio
        {
            get { return tanqueCheio; }
            set { tanqueCheio = value; }
        }

        /// <summary>
        /// Valor total pago pelo abastecimento.
        /// </summary>
        private Decimal valor;
        public Decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Valor que foi pago pelo litro do combustível.
        /// </summary>
        private Decimal valorLitro;
        public Decimal ValorLitro
        {
            get { return valorLitro; }
            set { valorLitro = value; }
        }

        /// <summary>
        /// Tipo de Combustível usado no abastecimento.
        /// </summary>
        private TipoCombustivel tipoCombustivel;
        public TipoCombustivel TipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }

        /// <summary>
        /// Observações sobre o abastecimento.
        /// </summary>
        private string observacoes;
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

    }

}
