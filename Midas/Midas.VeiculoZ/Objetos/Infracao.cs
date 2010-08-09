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
    public class Infracao:ObjetoNegocio
    {
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private string artigo;
        public string Artigo
        {
            get { return artigo; }
            set { artigo = value; }
        }

        private string infrator;
        public string Infrator
        {
            get { return infrator; }
            set { infrator = value; }
        }

        private double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private ClassificacaoInfracao classificacao;
        public ClassificacaoInfracao Classificacao
        {
            get { return classificacao; }
            set { classificacao = value; }
        }

    }

}
