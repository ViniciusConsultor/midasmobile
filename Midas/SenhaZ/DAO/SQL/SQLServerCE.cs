using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;

namespace SenhaZ.DAO.SQL
{
    public class SQLServerCE
    {
        private SqlCeConnection connection;

        private static SQLServerCE instance = new SQLServerCE();
        public static SQLServerCE Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Construtor.
        /// </summary>
        private SQLServerCE()
        {
        }

        /// <summary>
        /// Criar um banco de dados.
        /// </summary>
        /// <param name="nomeBanco">Nome do Banco.</param>
        public void CriarBancoDados(string nomeBanco)
        {
            SqlCeEngine engine = new SqlCeEngine("Data Source=\\Temp\\" + nomeBanco + ".sdf");
            engine.CreateDatabase();
        }

        /// <summary>
        /// Verificar se um determinado banco de dados existe no servidor.
        /// </summary>
        /// <param name="nomeBanco">Nome do banco de dados.</param>
        /// <returns></returns>
        public Boolean BancoExiste(string nomeBanco)
        {
            try
            {
                SqlCeConnection conn = new SqlCeConnection("Data Source=\\Temp\\" + nomeBanco + ".sdf");
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
        /// <param name="nomeBanco">Nome do Banco.</param>
        public void AbrirConexao(string nomeBanco)
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlCeConnection("Data Source=\\Temp\\" + nomeBanco + ".sdf");
                    connection.Open();
                }
                else
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                }
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
            connection.Close();
        }

        /// <summary>
        /// Executar um comando no banco de dados ativo.
        /// </summary>
        /// <param name="cmd">Comando a ser executado.</param>
        public void ExecutarComando(string cmd)
        {
            SqlCeCommand command = new SqlCeCommand(cmd, connection);
            command.ExecuteNonQuery();
        }

        public SqlCeCommand CriarComando(string cmd)
        {
            SqlCeCommand command = new SqlCeCommand(cmd, connection);
            return command;
        }

        public void ExecutarComando(SqlCeCommand comando)
        {
            comando.ExecuteNonQuery();
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

    }
}
