using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Financeiro.Objetos;
using Midas.Nucleo.Dados.SQLServerCE;
using Midas.Nucleo.Recursos;
using System.Data.SqlServerCe;

namespace Midas.Financeiro.Dados.SQLServer
{

    /// <summary>
    /// Classe de Acesso a Dados para Categorias.
    /// </summary>
    public class CategoriaDados:ICategoriaDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Categoria categoria = (Categoria)objeto;
            if (categoria.Id != null)
            {
                Comando comando = new Comando(Recursos.ComandosSQL.InserirCategoria, ConstantesGerais.BancoFinanceiro);
                comando.AdicionarParametro("@descricao", categoria.Descricao);
                if (categoria.CategoriaPai != null)
                {
                    comando.AdicionarParametro("@idcategoriapai", categoria.CategoriaPai.Id);
                }
                else
                {
                    comando.AdicionarParametro("@idcategoriapai", DBNull.Value);
                }
                comando.Executar();
            }
            else
            {
                Comando comando = new Comando(Recursos.ComandosSQL.AtualizarCategoria, ConstantesGerais.BancoFinanceiro);
                comando.AdicionarParametro("@id", categoria.Id);
                comando.AdicionarParametro("@descricao", categoria.Descricao);
                if (categoria.CategoriaPai != null)
                {
                    comando.AdicionarParametro("@idcategoriapai", categoria.CategoriaPai.Id);
                }
                else
                {
                    comando.AdicionarParametro("@idcategoriapai", DBNull.Value);
                }
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            throw new NotImplementedException();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IList Localizar()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
