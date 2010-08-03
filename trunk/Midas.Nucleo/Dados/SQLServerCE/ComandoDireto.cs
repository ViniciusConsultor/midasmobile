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
using System.Data.SqlServerCe;
using Midas.Nucleo.Conversor;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Dados.SQLServerCE
{
    public class ComandoDireto
    {
        private string nomeBanco;
        private string tabela;
        private SQLServerCE server;

        public ComandoDireto(string banco, string tabela)
        {
            this.nomeBanco = banco;
            this.tabela = tabela;
            server = new SQLServerCE(banco);
        }

        public IList ListarTabela(IConversor conversor)
        {
            IList lista = new ArrayList();
            server.AbrirConexao();
            SqlCeDataReader dataReader = server.ListarTabelaModoDireto(tabela);
            while (dataReader.Read())
            {
                lista.Add(conversor.Converter(dataReader));
            }
            dataReader.Close();
            dataReader.Dispose();
            server.FecharConexao();
            return lista;
        }

        public IList ListarTabela(string indice, object valor, string campo, IConversor conversor)
        {
            IList s = new ArrayList();
            server.AbrirConexao();
            SqlCeDataReader dataReader = server.ListarTabelaModoDireto(tabela, indice, valor);
            while (dataReader.Read())
            {
                if (dataReader[campo].Equals(valor))
                {
                    ObjetoNegocio o = (ObjetoNegocio)conversor.Converter(dataReader);
                    s.Add(o);
                }
            }
            return s;
        }

    }

}
