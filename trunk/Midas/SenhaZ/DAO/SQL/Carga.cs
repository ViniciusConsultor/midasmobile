using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SenhaZ.Constantes;

namespace SenhaZ.DAO.SQL
{
    public class Carga:ICarga
    {

        #region ICarga Members

        void ICarga.Carregar()
        {
            if (!SQLServerCE.Instance.BancoExiste(BancoDadosConstantes.NOME_BANCO_DADOS))
            {
                SQLServerCE.Instance.CriarBancoDados(BancoDadosConstantes.NOME_BANCO_DADOS);
                SQLServerCE.Instance.AbrirConexao(BancoDadosConstantes.NOME_BANCO_DADOS);
                SQLServerCE.Instance.ExecutarComando(BancoDadosConstantes.SQL_CRIAR_TABELA_CATEGORIAS);
                SQLServerCE.Instance.FecharConexao();
            }
        }

        #endregion

    }
}
