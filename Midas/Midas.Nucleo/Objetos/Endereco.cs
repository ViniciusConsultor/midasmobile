using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{

    /// <summary>
    /// Classe representando um Endereço em uma Cidade.
    /// </summary>
    public class Endereco:ObjetoNegocio
    {
        
        /// <summary>
        /// Logradouro do Endereço.
        /// </summary>
        private string logradouro;
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        /// <summary>
        /// Número.
        /// </summary>
        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        /// <summary>
        /// Código de Endereçamento Postal (CEP).
        /// </summary>
        private string codigoPostal;
        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        /// <summary>
        /// Bairro.
        /// </summary>
        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        /// <summary>
        /// Complemento do Endereço.
        /// </summary>
        private string complemento;
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        /// <summary>
        /// Cidade a que pertence o Endereço.
        /// </summary>
        private Cidade cidade;
        public Cidade Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

    }

}
