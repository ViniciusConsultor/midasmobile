using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{

    /// <summary>
    /// Classe que representa uma Cidade de um Estado.
    /// </summary>
    public class Cidade:ObjetoNegocio
    {

        /// <summary>
        /// Nome da Cidade.
        /// </summary>
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Estado ao qual pertence a Cidade.
        /// </summary>
        private Estado estado;
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }

}
