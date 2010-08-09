using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo
{
    public class NucleoFachada:INucleoFachada
    {
        private static INucleoFachada instancia = new NucleoFachada();
        public static INucleoFachada Instancia
        {
            get { return NucleoFachada.instancia; }
            set { NucleoFachada.instancia = value; }
        }

        private NucleoFachada() { }

        #region INucleoFachada Members

        public System.Collections.IList ListarEstados()
        {
            return Negocio.NegocioFactory.Instancia.EstadoNegocio.Listar();
        }

        public System.Collections.IList ListarCidades()
        {
            return Negocio.NegocioFactory.Instancia.CidadeNegocio.Listar();
        }

        public void ExcluirCidade(long id)
        {
            Negocio.NegocioFactory.Instancia.CidadeNegocio.Excluir(id);
        }

        public void SalvarCidade(Midas.Nucleo.Objetos.Cidade cidade)
        {
            Negocio.NegocioFactory.Instancia.CidadeNegocio.Salvar(cidade);
        }

        public System.Collections.IList ListarPessoasJuridicas()
        {
            return Negocio.NegocioFactory.Instancia.PessoaJuridicaNegocio.Listar();
        }

        public void ExcluirPessoaJuridica(long id)
        {
            Negocio.NegocioFactory.Instancia.PessoaJuridicaNegocio.Excluir(id);
        }

        public void SalvarPessoaJuridica(Midas.Nucleo.Objetos.PessoaJuridica pj)
        {
            Negocio.NegocioFactory.Instancia.PessoaJuridicaNegocio.Salvar(pj);
        }

        #endregion
    }
}
