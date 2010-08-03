using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{

    /// <summary>
    /// Classe que representa uma Moeda de um país.
    /// </summary>
    public class Moeda:ObjetoNegocio
    {

        /// <summary>
        /// Nome da Moeda.
        /// </summary>
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Símbolo que representa a moeda.
        /// </summary>
        private string simbolo;
        public string Simbolo
        {
            get { return simbolo; }
            set { simbolo = value; }
        }

    }

}
