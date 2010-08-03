using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{

    /// <summary>
    /// Classe que representa um Estado de um determinado País.
    /// </summary>
    public class Estado:ObjetoNegocio
    {

        /// <summary>
        /// Nome do Estado.
        /// </summary>
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Sigla do Estado.
        /// </summary>
        private string sigla;
        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        /// <summary>
        /// País ao qual pertence o Estado.
        /// </summary>
        private Pais pais;
        public Pais Pais
        {
            get { return pais; }
            set { pais = value; }
        }

    }

}
