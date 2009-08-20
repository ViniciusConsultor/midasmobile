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
using Midas.Nucleo.Validador;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Validador
{
    public class DistribuidoraValidador:IValidador
    {
        #region IValidador Members

        public Validacao Validar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Distribuidora distribuidora = (Distribuidora)objeto;
            if (distribuidora.Nome == null || distribuidora.Nome == "")
            {
                return new Validacao(false, "Informe o Nome da Distribuidora.");
            }
            return new Validacao(true, "");
        }

        #endregion
    }
}
