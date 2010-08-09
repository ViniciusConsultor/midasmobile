using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{

    /// <summary>
    /// Classe que representa uma Pessoa Física.
    /// </summary>
    public class PessoaFisica:Pessoa
    {

        /// <summary>
        /// Nome da Pessoa.
        /// </summary>
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }

}
