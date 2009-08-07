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
    /// Classe que representa um Posto de Combustível.
    /// </summary>
    public class Posto:ObjetoNegocio
    {

        private string nome;
        public string Nome
        {
            get { return this.PessoaJuridica.NomeFantasia; }
        }

        private string nomeDistribuidora;
        public string NomeDistribuidora
        {
            get { return this.Distribuidora.Nome; }
        }

        /// <summary>
        /// Referência para a PJ. 
        /// </summary>
        private PessoaJuridica pessoaJuridica = new PessoaJuridica();
        public PessoaJuridica PessoaJuridica
        {
            get { return pessoaJuridica; }
            set { pessoaJuridica = value; }
        }

        /// <summary>
        /// Endereço do Posto.
        /// </summary>
        private Endereco endereco;
        public Endereco Endereco
        {
            get { return PessoaJuridica.Endereco; }
            set { PessoaJuridica.Endereco = value; }
        }

        /// <summary>
        /// Distribuidora que fornece combustível para o Posto.
        /// </summary>
        private Distribuidora distribuidora;
        public Distribuidora Distribuidora
        {
            get { return distribuidora; }
            set { distribuidora = value; }
        }

        private string observacoes;
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
    }

}
