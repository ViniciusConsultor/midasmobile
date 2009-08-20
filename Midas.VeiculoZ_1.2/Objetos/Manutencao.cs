﻿/*
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
    public class Manutencao:ObjetoNegocio
    {
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private decimal km;
        public decimal Km
        {
            get { return km; }
            set { km = value; }
        }

        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private Veiculo veiculo;
        public Veiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        private bool lembrarPorData;
        public bool LembrarPorData
        {
            get { return lembrarPorData; }
            set { lembrarPorData = value; }
        }

        private bool verificado;
        public bool Verificado
        {
            get { return verificado; }
            set { verificado = value; }
        }
    }

}
