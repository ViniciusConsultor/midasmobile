using System;
using System.Linq;
using System.Collections;
using System.Text;
using System.Security.Cryptography;
using SenhaZ.DAO;
using SenhaZ.DAO.SQL;
using SenhaZ.Objetos;
using SenhaZ.Constantes;

namespace SenhaZ.Negocio
{

    /// <summary>
    /// Acesso ao Sistema.
    /// </summary>
    public class SenhaZ:ISenhaZ
    {
        private static ISenhaZ instance = new SenhaZ();
        public static ISenhaZ Instance
        {
            get { return SenhaZ.instance; }
            set { SenhaZ.instance = value; }
        }

        ~SenhaZ()
        {
            SQLServerCE.Instance.FecharConexao();
        }

        private SenhaZ()
        {
        }

        #region ISenhaZ Members

        public void SalvarCategoria(global::SenhaZ.Objetos.Categoria categoria)
        {
            DAOFactory.Instance.CriarCategoriaDAO().Salvar(categoria);
        }

        public void ExcluirCategoria(long id)
        {
            DAOFactory.Instance.CriarCategoriaDAO().Excluir(id);
        }

        public global::SenhaZ.Objetos.Categoria LocalizarCategoria(long id)
        {
            return (Categoria)DAOFactory.Instance.CriarCategoriaDAO().Localizar(id);
        }

        public IList LocalizarCategorias()
        {
            return DAOFactory.Instance.CriarCategoriaDAO().Localizar();
        }

        public bool Logar(string senha)
        {
            throw new NotImplementedException();
        }

        public void InicializarSistema()
        {
            ICarga carga = new Carga();
            carga.Carregar();
            SQLServerCE.Instance.AbrirConexao(BancoDadosConstantes.NOME_BANCO_DADOS);
        }

        #endregion
    }
}
