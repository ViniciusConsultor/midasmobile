using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Negocio
{

    public class PessoaJuridicaNegocio:NegocioGenerico
    {
        public PessoaJuridicaNegocio()
        {
            this.AcessoDados = new Dados.SQLServerCE.PessoaJuridicaDados();
        }

        public override void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            PessoaJuridica pj = (PessoaJuridica)objeto;
            Negocio.NegocioFactory.Instancia.EnderecoNegocio.Salvar(pj.Endereco);
            base.Salvar(pj);
        }

        public override void Excluir(long id)
        {
            PessoaJuridica pj = (PessoaJuridica)Obter(id);
            NegocioFactory.Instancia.EnderecoNegocio.Excluir(pj.Endereco.Id);
        }

    }

}
