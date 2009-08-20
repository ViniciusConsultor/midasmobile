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
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Validador;

namespace Midas.VeiculoZ.Validador
{
    public class PostoValidador:Midas.Nucleo.Validador.IValidador
    {

        #region IValidador Members

        public Midas.Nucleo.Validador.Validacao Validar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Posto posto = (Posto)objeto;
            if (posto.Distribuidora == null)
            {
                return new Validacao(false, "Informe a Distribuidora.");
            }
            if (posto.Nome == null || posto.Nome == "")
            {
                return new Validacao(false, "Informe o Nome.");
            }
            return new Validacao(true, ".");
        }

        #endregion

    }

}
