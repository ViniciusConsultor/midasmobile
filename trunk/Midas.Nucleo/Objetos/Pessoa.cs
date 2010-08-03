using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{
    /// <summary>
    /// Classe abstrata que representa uma Pessoa.
    /// </summary>
    public abstract class Pessoa:ObjetoNegocio
    {
        private Endereco endereco;
        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }

}
