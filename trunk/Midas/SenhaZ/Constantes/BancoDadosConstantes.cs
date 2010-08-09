using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SenhaZ.Constantes
{
    public class BancoDadosConstantes
    {
        public static string NOME_BANCO_DADOS = "SenhaZ";
        public static string SQL_INSERIR_CATEGORIA = "INSERT INTO CATEGORIA (NOME) VALUES (@nome)";
        public static string SQL_ATUALIZAR_CATEGORIA = "UPDATE CATEGORIA SET NOME = @nome WHERE ID = @id";
        public static string SQL_EXCLUIR_CATEGORIA = "DELETE FROM CATEGORIA WHERE ID = @id";
        public static string SQL_SELECIONAR_CATEGORIA_POR_ID = "SELECT ID,NOME FROM CATEGORIA WHERE ID = @id";
        public static string SQL_SELECIONAR_TODAS_CATEGORIAS = "SELECT ID,NOME FROM CATEGORIA ORDER BY NOME";
        public static string SQL_CRIAR_TABELA_CATEGORIAS = "CREATE TABLE CATEGORIA (ID INT IDENTITY(1,1) PRIMARY KEY, NOME NVARCHAR(50))";
        public static string SQL_REMOVER_TABELA_CATEGORIAS = "DROP TABLE CATEGORIA;";
    }
}
