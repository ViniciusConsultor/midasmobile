using System;
using System.Linq;
using System.Collections;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Dados.SQLServerCE
{

    /// <summary>
    /// Acesso a Dados para Países.
    /// </summary>
    public class PaisDados:IAcessoDados
    {

        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Pais pais = (Pais)objeto;
            if (pais.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirPais, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@nome", pais.Nome);
                pais.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarPais, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@nome", pais.Nome);
                comando.AdicionarParametro("@id", pais.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirPais, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPais, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.Nucleo.Conversor.PaisConversorDataReader());
            if (lista.Count > 0)
                return (Pais)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosPaises, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            IList lista = comando.ExecutarQuery(new Midas.Nucleo.Conversor.PaisConversorDataReader());
            return lista;
        }

        #endregion
    }

}
