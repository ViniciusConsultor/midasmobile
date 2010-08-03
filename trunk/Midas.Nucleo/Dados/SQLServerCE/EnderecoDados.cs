using System;
using System.Linq;
using System.Collections;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Dados.SQLServerCE
{

    /// <summary>
    /// Acesso a Dados para Endereços.
    /// </summary>
    public class EnderecoDados:IAcessoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Endereco endereco = (Endereco)objeto;
            if (endereco.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirEndereco, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@logradouro", endereco.Logradouro);
                comando.AdicionarParametro("@numero", endereco.Numero);
                comando.AdicionarParametro("@bairro", endereco.Bairro);
                comando.AdicionarParametro("@codigopostal", endereco.CodigoPostal);
                if (endereco.Cidade != null)
                {
                    comando.AdicionarParametro("@idcidade", endereco.Cidade.Id);
                }
                else
                {
                    comando.AdicionarParametro("@idcidade", DBNull.Value);
                }
                comando.AdicionarParametro("@complemento", endereco.Complemento);
                endereco.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarEndereco, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@logradouro", endereco.Logradouro);
                comando.AdicionarParametro("@numero", endereco.Numero);
                comando.AdicionarParametro("@bairro", endereco.Bairro);
                comando.AdicionarParametro("@codigopostal", endereco.CodigoPostal);
                if (endereco.Cidade != null)
                {
                    comando.AdicionarParametro("@idcidade", endereco.Cidade.Id);
                }
                else
                {
                    comando.AdicionarParametro("@idcidade", -1);
                }
                comando.AdicionarParametro("@complemento", endereco.Complemento);
                comando.AdicionarParametro("@id", endereco.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirEndereco, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarEndereco, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.Nucleo.Conversor.EnderecoConversorDataReader());
            if (lista.Count > 0)
                return (Endereco)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosEnderecos, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            return comando.ExecutarQuery(new Midas.Nucleo.Conversor.EnderecoConversorDataReader());
        }

        #endregion

    }

}
