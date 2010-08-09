using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Form
{
    
    public sealed class MenuFabrica
    {

        private static IConstrutorMenu construtor;
        public static IConstrutorMenu Construtor
        {
            get { return MenuFabrica.construtor; }
            set { MenuFabrica.construtor = value; }
        }

    }

}
