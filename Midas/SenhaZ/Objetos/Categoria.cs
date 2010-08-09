using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SenhaZ.Objetos
{
    public class Categoria:ObjetoNegocio
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
