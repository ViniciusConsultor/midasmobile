using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midas.Nucleo.Negocio
{

    /// <summary>
    /// Carga do Sistema.
    /// </summary>
    public interface ICargaSistema
    {

        /// <summary>
        /// Inicializar o Sistema.
        /// Caso o sistema nunca tenha sido rodado, irá criar todas configurações iniciais
        /// necessárias para o sistema rodar.
        /// </summary>
        void Iniciar();

    }

}
