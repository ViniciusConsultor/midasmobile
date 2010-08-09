using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Negocio
{

    /// <summary>
    /// Fábrica de Objetos de Negócio.
    /// </summary>
    public class NegocioFactory
    {
        private static NegocioFactory instancia = new NegocioFactory();
        public static NegocioFactory Instancia
        {
            get { return NegocioFactory.instancia; }
        }

        private NegocioFactory() { }

        private PaisNegocio paisNegocio = new PaisNegocio();
        public PaisNegocio PaisNegocio
        {
            get { return paisNegocio; }
            set { paisNegocio = value; }
        }

        private EstadoNegocio estadoNegocio = new EstadoNegocio();
        public EstadoNegocio EstadoNegocio
        {
            get { return estadoNegocio; }
            set { estadoNegocio = value; }
        }

        private CidadeNegocio cidadeNegocio = new CidadeNegocio();
        public CidadeNegocio CidadeNegocio
        {
            get { return cidadeNegocio; }
            set { cidadeNegocio = value; }
        }

        private PessoaJuridicaNegocio pessoaJuridicaNegocio = new PessoaJuridicaNegocio();
        public PessoaJuridicaNegocio PessoaJuridicaNegocio
        {
            get { return pessoaJuridicaNegocio; }
            set { pessoaJuridicaNegocio = value; }
        }

        private EnderecoNegocio enderecoNegocio = new EnderecoNegocio();
        public EnderecoNegocio EnderecoNegocio
        {
            get { return enderecoNegocio; }
            set { enderecoNegocio = value; }
        }

    }

}
