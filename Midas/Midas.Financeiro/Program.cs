using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Midas.Financeiro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            new Negocio.CargaSistema().Iniciar();
            Application.Run(new Forms.CadastroCategoria());
        }
    }
}