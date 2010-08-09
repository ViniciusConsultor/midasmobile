using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;
using System.Collections;

namespace Midas.Nucleo.Dados.SQLServerCE
{

    public class PessoaJuridicaDados:IAcessoDados
    {
        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            PessoaJuridica pessoaJuridica = (PessoaJuridica)objeto;
            if (pessoaJuridica.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirPessoaJuridica, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@cnpj", pessoaJuridica.CNPJ);
                comando.AdicionarParametro("@idendereco", pessoaJuridica.Endereco.Id);
                comando.AdicionarParametro("@nomefantasia", pessoaJuridica.NomeFantasia);
                pessoaJuridica.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarPessoaJuridica, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
                comando.AdicionarParametro("@cnpj", pessoaJuridica.CNPJ);
                comando.AdicionarParametro("@idendereco", pessoaJuridica.Endereco.Id);
                comando.AdicionarParametro("@nomefantasia", pessoaJuridica.NomeFantasia);
                comando.AdicionarParametro("@id", pessoaJuridica.Id);
                comando.Executar();
            }

        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirPessoaJuridica, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPessoaJuridica, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.Nucleo.Conversor.PessoaJuridicaConversorDataReader());
            if (lista.Count > 0)
                return (PessoaJuridica)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodasPessoasJuridicas, Midas.Nucleo.Recursos.ConstantesGerais.BancoNucleo);
            IList lista = comando.ExecutarQuery(new Midas.Nucleo.Conversor.PessoaJuridicaConversorDataReader());
            return lista;
        }

    }

}
