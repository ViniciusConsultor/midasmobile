using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Form
{
    public sealed class FormStackFactory
    {
        private static FormStack formStack;
        public static FormStack FormStack
        {
            get { return FormStackFactory.formStack; }
            set { FormStackFactory.formStack = value; }
        }
    }
}
