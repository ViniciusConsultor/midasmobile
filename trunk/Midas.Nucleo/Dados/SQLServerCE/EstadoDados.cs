using System;
using System.Linq;
using System.Collections;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Dados.SQLServerCE
{

    /// <summary>
    /// Acesso a Dados para Estados.
    /// </summary>
    public class EstadoDados:IAcessoDados
    {

        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Estado estado = (Estado)objeto;
            if (estado.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirEstado, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@nome", estado.Nome);
                comando.AdicionarParametro("@idpais", estado.Pais.Id);
                comando.Executar();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarEstado, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@nome", estado.Nome);
                comando.AdicionarParametro("@idpais", estado.Pais.Id);
                comando.AdicionarParametro("@id", estado.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirEstado, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarEstado, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.Nucleo.Conversor.EstadoConversorDataReader());
            if (lista.Count > 0)
                return (Estado)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosEstados, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            return comando.ExecutarQuery(new Midas.Nucleo.Conversor.EstadoConversorDataReader());
        }

        #endregion

    }

}