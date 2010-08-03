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
using System.Collections;
using System.Text;
using System.Data.SqlServerCe;
using Midas.Nucleo.Conversor;

namespace Midas.Nucleo.Dados.SQLServerCE
{

    /// <summary>
    /// Classe que facilita a comunicação com o servidor de dados SQL Server Compact Edition
    /// </summary>
    public class Comando
    {
        private SQLServerCE server;
        private string comando;
        private string banco;
        private Hashtable parametros = new Hashtable();

        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="comando">Comando SQL.</param>
        /// /// <param name="banco">Banco de Dados.</param>
        public Comando(string comando, string banco) 
        {
            server = new SQLServerCE(banco);
            this.banco = banco;
            this.comando = comando;
        }

        /// <summary>
        /// Adicionar parâmetros ao comando.
        /// </summary>
        /// <param name="chave">Chave</param>
        /// <param name="valor">Valor</param>
        public void AdicionarParametro(string chave, object valor)
        {
            this.parametros.Add(chave, valor);
        }

        /// <summary>
        /// Executar um Comando SQL que não tem retorno.
        /// </summary>
        public void Executar()
        {
            server.AbrirConexao();
            SqlCeCommand command = server.CriarComando(this.comando);
            foreach (string chave in this.parametros.Keys)
            {
                command.Parameters.Add(new SqlCeParameter(chave, this.parametros[chave]));
            }            
            server.ExecutarComando(command);
            command.Dispose();
           server.FecharConexao();
        }

        /// <summary>
        /// Executar um Comando SQL que não tem retorno.
        /// </summary>
        /// <returns>Identificador Gerado.</returns>
        public Int32 ExecutarInsercao()
        {
            server.AbrirConexao();
            SqlCeCommand command = server.CriarComando(this.comando);
            foreach (string chave in this.parametros.Keys)
            {
                command.Parameters.Add(new SqlCeParameter(chave, this.parametros[chave]));
            }
            server.ExecutarComando(command);
            Int32 id = server.ObterIdentificador();
            server.FecharConexao();
            command.Dispose();
            return id;
        }

        public object ObterValorEscalar()
        {
            server.AbrirConexao();
            SqlCeCommand command = server.CriarComando(this.comando);
            foreach (string chave in this.parametros.Keys)
            {
                command.Parameters.Add(new SqlCeParameter(chave, this.parametros[chave]));
            }
            SqlCeDataReader dataReader = server.ExecutarQuery(command);
            object valor = null;
            while (dataReader.Read())
            {
                valor = dataReader.GetValue(0);
            }
            dataReader.Close();
            dataReader.Dispose();
            command.Dispose();
            server.FecharConexao();
            return valor;
        }

        /// <summary>
        /// Executar uma Query que retorna resultados.
        /// </summary>
        /// <returns>Lista contendo resultados do Conversor.</returns>
        public IList ExecutarQuery(Midas.Nucleo.Conversor.IConversor conversor)
        {
            IList lista = new ArrayList();
            server.AbrirConexao();
            SqlCeCommand command = server.CriarComando(this.comando);
            foreach (string chave in this.parametros.Keys)
            {
                command.Parameters.Add(new SqlCeParameter(chave, this.parametros[chave]));
            }
            SqlCeDataReader dataReader = server.ExecutarQuery(command);
            while (dataReader.Read())
            {
                lista.Add(conversor.Converter(dataReader));
            }
            dataReader.Close();
            dataReader.Dispose();
            command.Dispose();
            server.FecharConexao();
            return lista;
        }

        public SqlCeDataReader ExecutarQuery()
        {
            server.AbrirConexao();
            SqlCeCommand command = server.CriarComando(this.comando);
            foreach (string chave in this.parametros.Keys)
            {
                command.Parameters.Add(new SqlCeParameter(chave, this.parametros[chave]));
            }
            return server.ExecutarQuery(command);
        }

        /// <summary>
        /// Executar uma Query que retorna resultados.
        /// </summary>
        /// <returns>Lista contendo resultados do Conversor.</returns>
        public object ExecutarQueryRetornarPrimeiroResultado(Midas.Nucleo.Conversor.IConversor conversor)
        {
            server.AbrirConexao();
            SqlCeCommand command = server.CriarComando(this.comando);
            foreach (string chave in this.parametros.Keys)
            {
                command.Parameters.Add(new SqlCeParameter(chave, this.parametros[chave]));
            }
            SqlCeDataReader dataReader = server.ExecutarQuery(command);
            object o = null;
            while (dataReader.Read())
            {
                o = conversor.Converter(dataReader);
                break;
            }
            dataReader.Close();
            dataReader.Dispose();
            command.Dispose();
            server.FecharConexao();
            return o;
        }

    }

}