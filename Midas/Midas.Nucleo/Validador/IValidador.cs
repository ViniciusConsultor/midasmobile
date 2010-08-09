using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midas.Nucleo.Validador
{

    public interface IValidador
    {
        Validacao Validar(Objetos.ObjetoNegocio objeto);
    }

}
