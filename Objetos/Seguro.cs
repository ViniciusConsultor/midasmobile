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
    /// Classe que representa um Seguro de um Veículo.
    /// </summary>
    public class Seguro:ObjetoNegocio
    {

        /// <summary>
        /// Empresa responsável pelo seguro.
        /// </summary>
        private PessoaJuridica seguradora;
        public PessoaJuridica Seguradora
        {
            get { return seguradora; }
            set { seguradora = value; }
        }

        /// <summary>
        /// Data de Vencimento do Seguro.
        /// </summary>
        private DateTime vencimento;
        public DateTime Vencimento
        {
            get { return vencimento; }
            set { vencimento = value; }
        }

    }

}