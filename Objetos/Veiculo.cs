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
    /// Classe que representa um Carro.
    /// </summary>
    public class Veiculo:ObjetoNegocio
    {

        /// <summary>
        /// Número da Placa do Veículo.
        /// </summary>
        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        /// <summary>
        /// Número do RENAVAM do Veículo.
        /// </summary>
        private string renavam;
        public string Renavam
        {
            get { return renavam; }
            set { renavam = value; }
        }

        /// <summary>
        /// Cor do Veículo.
        /// </summary>
        private string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        /// <summary>
        /// Modelo do Veículo.
        /// </summary>
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        /// <summary>
        /// Marca do Veículo.
        /// </summary>
        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

    }

}
