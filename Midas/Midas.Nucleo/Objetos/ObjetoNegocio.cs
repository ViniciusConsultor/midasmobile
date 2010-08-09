using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Objetos
{

    /// <summary>
    /// Representa um objeto de negócio da aplicação.
    /// </summary>
    public class ObjetoNegocio
    {

        /// <summary>
        /// Identificador do objeto de negócio.
        /// Todo objeto de negócio possui um identificador único.
        /// </summary>
        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
