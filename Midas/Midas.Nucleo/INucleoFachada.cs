using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo
{

    /// <summary>
    /// Fachada para o Módulo Núcleo.
    /// </summary>
    public interface INucleoFachada
    {
        IList ListarEstados();
        IList ListarCidades();
        void ExcluirCidade(long id);
        void SalvarCidade(Midas.Nucleo.Objetos.Cidade cidade);
        IList ListarPessoasJuridicas();
        void ExcluirPessoaJuridica(long id);
        void SalvarPessoaJuridica(PessoaJuridica pj);
    }

}
