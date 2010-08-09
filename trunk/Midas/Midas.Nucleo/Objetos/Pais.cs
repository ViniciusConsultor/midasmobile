using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{

    /// <summary>
    /// Classe que representa um País.
    /// </summary>
    public class Pais:ObjetoNegocio
    {

        /// <summary>
        /// Nome do País.
        /// </summary>
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }

}
