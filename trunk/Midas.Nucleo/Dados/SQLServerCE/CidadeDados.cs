using System;
using System.Linq;
using System.Collections;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Dados.SQLServerCE
{

    /// <summary>
    /// Acesso a Dados para Cidades.
    /// </summary>
    public class CidadeDados:IAcessoDados
    {

        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Cidade cidade = (Cidade)objeto;
            if (cidade.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirCidade, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@nome", cidade.Nome);
                comando.AdicionarParametro("@idestado", cidade.Estado.Id);
                cidade.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarCidade, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@nome", cidade.Nome);
                comando.AdicionarParametro("@idestado", cidade.Estado.Id);
                comando.AdicionarParametro("@id", cidade.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirCidade, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarCidade, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.Nucleo.Conversor.CidadeConversorDataReader());
            if (lista.Count > 0)
                return (Cidade)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodasCidades, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            return comando.ExecutarQuery(new Midas.Nucleo.Conversor.CidadeConversorDataReader());
        }

        #endregion

    }

}