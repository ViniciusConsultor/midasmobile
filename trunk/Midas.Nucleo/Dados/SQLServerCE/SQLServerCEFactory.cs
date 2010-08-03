/*
 *  VeículoZ é um aplicativo para gerenciamento de abastecimentos e despesas de veículos.
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
using System.Collections;

namespace Midas.Nucleo.Dados.SQLServerCE
{
    public sealed class SQLServerCEFactory
    {
        private static System.Collections.Hashtable conexoes = new System.Collections.Hashtable();

        private SQLServerCEFactory instance = new SQLServerCEFactory();
        public SQLServerCEFactory Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public static SQLServerCE CriarInstancia(string nomeBanco)
        {
            if (conexoes[nomeBanco] != null)
            {
                return (SQLServerCE)conexoes[nomeBanco];
            }
            conexoes.Add(nomeBanco, new SQLServerCE(nomeBanco));
            return (SQLServerCE)conexoes[nomeBanco];
        }

        public static void FecharTodasConexoes()
        {
            foreach (DictionaryEntry de in conexoes)
            {
                SQLServerCE con = (SQLServerCE)de.Value;
                con.FecharConexao();
            }                
        }

    }

}
