using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Nucleo.Validador
{
    public class Validacao
    {
        public Validacao()
        {
        }

        public Validacao(bool passou, string msg)
        {
            this.passou = passou;
            this.mensagem = msg;
        }

        private bool passou;
        public bool Passou
        {
            get { return passou; }
            set { passou = value; }
        }

        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public void AdicionarMensagem(string msg)
        {
            mensagem = mensagem + msg + "\n";
        }

    }
}
