using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using SenhaZ.Forms;

namespace SenhaZ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            SenhaZ.Negocio.SenhaZ.Instance.InicializarSistema();

        }
    }
}