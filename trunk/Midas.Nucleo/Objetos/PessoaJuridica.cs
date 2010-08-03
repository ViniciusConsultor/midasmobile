using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{

    /// <summary>
    /// Classe representando uma Pessoa Jurídica.
    /// </summary>
    public class PessoaJuridica:Pessoa
    {

        /// <summary>
        /// Cadastro de Pessoa Jurídica.
        /// </summary>
        private string cnpj;
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        /// <summary>
        /// Nome Fantasia da Pessoa Jurídica.
        /// </summary>
        private string nomeFantasia;
        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }

        public override string ToString()
        {
            return NomeFantasia;
        }
    }

}
