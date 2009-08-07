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
    /// Classe que representa uma multa.
    /// </summary>
    public class Multa:ObjetoNegocio
    {

        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private DateTime dataVencimento;
        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        private Veiculo veiculo;
        public Veiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        private string local;
        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        private SituacaoMulta situacao;
        public SituacaoMulta Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        private Infracao infracao;
        public Infracao Infracao
        {
            get { return infracao; }
            set { infracao = value; }
        }

        private string observacoes;
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public string DescricaoDetalhada
        {
            get
            {
                return "(" + this.Data.ToString("dd/MM/yyyy") + ") - " + this.infracao.Classificacao.Descricao + " - " + this.infracao.Classificacao.Pontos + " Pontos.";
            }
        }
}

}
