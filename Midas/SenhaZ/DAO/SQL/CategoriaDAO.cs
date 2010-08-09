using System;
using System.Linq;
using System.Collections;
using System.Text;
using SenhaZ.Constantes;
using System.Data.SqlServerCe;
using SenhaZ.Objetos;

namespace SenhaZ.DAO.SQL
{
    public class CategoriaDAO:ICategoriaDAO
    {
        #region IAcessoDados Members

        public void Salvar(SenhaZ.Objetos.ObjetoNegocio objeto)
        {
            Categoria categoria = (Categoria) objeto;
            if (objeto.Id != 0) 
            {
                SqlCeCommand cmd = SQLServerCE.Instance.CriarComando(BancoDadosConstantes.SQL_ATUALIZAR_CATEGORIA);
                cmd.Parameters.Add(new SqlCeParameter("@nome",categoria.Nome));
                cmd.Parameters.Add(new SqlCeParameter("@id", categoria.Id));
                SQLServerCE.Instance.ExecutarComando(cmd);
            } 
            else 
            {
                SqlCeCommand cmd = SQLServerCE.Instance.CriarComando(BancoDadosConstantes.SQL_INSERIR_CATEGORIA);
                cmd.Parameters.Add(new SqlCeParameter("@nome", categoria.Nome));
                SQLServerCE.Instance.ExecutarComando(cmd);
            }
        }

        public void Excluir(long id)
        {
            SqlCeCommand cmd = SQLServerCE.Instance.CriarComando(BancoDadosConstantes.SQL_EXCLUIR_CATEGORIA);
            cmd.Parameters.Add(new SqlCeParameter("@id", id));
            SQLServerCE.Instance.ExecutarComando(cmd);
        }

        public SenhaZ.Objetos.ObjetoNegocio Localizar(long id)
        {
            SqlCeCommand cmd = SQLServerCE.Instance.CriarComando(BancoDadosConstantes.SQL_SELECIONAR_CATEGORIA_POR_ID);
            cmd.Parameters.Add(new SqlCeParameter("@id",id));
            SqlCeDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return this.ObterObjeto(reader);
            }
            return new Categoria();
        }

        public IList Localizar()
        {
            SqlCeCommand cmd = SQLServerCE.Instance.CriarComando(BancoDadosConstantes.SQL_SELECIONAR_TODAS_CATEGORIAS);
            SqlCeDataReader reader = cmd.ExecuteReader();
            IList lista = new ArrayList();
            while (reader.Read())
            {
                lista.Add(this.ObterObjeto(reader));
            }
            return lista;

        }

        private Categoria ObterObjeto(SqlCeDataReader reader)
        {
            Categoria categoria = new Categoria();
            categoria.Id = reader.GetInt32(0);
            categoria.Nome = reader.GetString(1);
            return categoria;
        }
        #endregion
    }
}
