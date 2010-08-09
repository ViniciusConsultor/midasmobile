using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Financeiro.Objetos
{

    /// <summary>
    /// Classe representando um Banco.
    /// </summary>
    public class Banco:PessoaJuridica
    {

        /// <summary>
        /// Identificador específico de cada banco. 
        /// Exemplo: Banco do Brasil = 001.
        /// </summary>
        private string identificador;
        public string Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

    }

}
