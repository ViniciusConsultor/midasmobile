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
using System.Data.SqlServerCe;
using System.IO;
using System.Collections;
using Midas.Nucleo.Conversor;

namespace Midas.Nucleo.Dados.SQLServerCE
{

    /// <summary>
    /// Classe que realiza a conexão com um banco de dados do SQL Server CE.
    /// É responsável em criar uma conexão única e mantê-la durante o tempo de vida da aplicação.
    /// </summary>
    public class SQLServerCE
    {

        private int quantidadeConexoes = 0;

        /// <summary>
        /// Pool de Conexões.
        /// </summary>
        private SqlCeConnection connection;

        private string nomeBanco;

        /// <summary>
        /// Construtor.
        /// </summary>
        public SQLServerCE(string nomeBanco)
        {
            this.nomeBanco = nomeBanco;
        }

        /// <summary>
        /// Criar um banco de dados.
        /// </summary>
        public void CriarBancoDados()
        {
            SqlCeEngine engine = new SqlCeEngine("Data Source=" + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + nomeBanco + ".sdf"));
            engine.CreateDatabase();
        }

        /// <summary>
        /// Verificar se um determinado banco de dados existe no servidor.
        /// </summary>
        /// <returns>Verdadeiro caso exista.</returns>
        public Boolean BancoExiste()
        {
            try
            {
                SqlCeConnection conn = new SqlCeConnection("Data Source=" + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + nomeBanco + ".sdf"));
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Abrir uma Conexão para um banco de dados.
        /// Caso o banco de dados não exista, este método o criará.
        /// </summary>
        public void AbrirConexao()
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlCeConnection("Data Source=" + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + nomeBanco + ".sdf"));
                    connection.Open();
                }
                else
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                }
                quantidadeConexoes++;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Fechar a Conexão ativa com o banco.
        /// </summary>
        public void FecharConexao()
        {
            if (quantidadeConexoes <= 1)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            if (quantidadeConexoes > 0)
            {
                quantidadeConexoes--;
            }
        }

        /// <summary>
        /// Executar um comando no banco de dados ativo.
        /// </summary>
        /// <param name="cmd">Comando a ser executado.</param>
        public void ExecutarComando(string cmd)
        {
            SqlCeTransaction trans = connection.BeginTransaction();
            SqlCeCommand command = new SqlCeCommand(cmd, connection);
            command.ExecuteNonQuery();
            trans.Commit(CommitMode.Immediate);
        }

        /// <summary>
        /// Criar um Comando e retorná-lo.
        /// </summary>
        /// <param name="cmd">Código SQL que deve ser usado para criar o Comando.</param>
        /// <returns>Comando do SQL Server CE.</returns>
        public SqlCeCommand CriarComando(string cmd)
        {
            SqlCeCommand command = new SqlCeCommand(cmd, connection);
            return command;
        }

        /// <summary>
        /// Executar um Comando no banco de dados.
        /// </summary>
        /// <param name="comando">Comando a ser executado.</param>
        public void ExecutarComando(SqlCeCommand comando)
        {
            SqlCeTransaction trans = connection.BeginTransaction();
            comando.ExecuteNonQuery();
            trans.Commit(CommitMode.Immediate);
        }

        /// <summary>
        /// Obter o último ID gerado automaticamente pelo banco.
        /// </summary>
        /// <returns>Identificador.</returns>
        public Int32 ObterIdentificador()
        {
            SqlCeCommand command = new SqlCeCommand("SELECT @@IDENTITY AS RETORNO", connection);
            return Convert.ToInt32((Decimal)command.ExecuteScalar());
        }

        /// <summary>
        /// Executar uma query no banco de dados.
        /// </summary>
        /// <param name="cmd">Query a ser executada.</param>
        /// <returns>Resultado da Query.</returns>
        public SqlCeDataReader ExecutarQuery(string cmd)
        {
            SqlCeCommand command = new SqlCeCommand(cmd, connection);
            SqlCeDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }

        /// <summary>
        /// Executar uma query no banco de dados.
        /// </summary>
        /// <param name="cmd">Query a ser executada.</param>
        /// <returns>Resultado da Query.</returns>
        public SqlCeDataReader ExecutarQuery(SqlCeCommand cmd)
        {
            SqlCeDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        public SqlCeDataReader ListarTabelaModoDireto(string tabela)
        {
            SqlCeCommand command = new SqlCeCommand(tabela, connection);
            command.CommandType = System.Data.CommandType.TableDirect;
            return command.ExecuteReader();
        }

        public void Compactar()
        {
            string dbAntigo = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + nomeBanco + ".sdf";
            string dbNovo = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Novo_" + nomeBanco + ".sdf";
            SqlCeEngine engine = new SqlCeEngine("Data Source=" + dbAntigo);
            engine.Compact("Data Source=" + dbNovo );
            File.Delete(dbAntigo);
            File.Move(dbNovo,dbAntigo);
        }

        public SqlCeDataReader ListarTabelaModoDireto(string tabela, string indice, object obj)
        {
            SqlCeCommand cmd = new SqlCeCommand(tabela, connection);
            cmd.CommandType = System.Data.CommandType.TableDirect;
            cmd.IndexName = indice;
            SqlCeDataReader reader = cmd.ExecuteReader();
            reader.Seek(DbSeekOptions.FirstEqual, obj);
            return reader;
        }

    }

}
