using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;

namespace Midas.VeiculoZ
{
    public sealed class Ambiente
    {
        private IList resolucoes = new ArrayList();

        private static Ambiente instancia = new Ambiente();
        public static Ambiente Instancia
        {
            get { return Ambiente.instancia; }
            set { Ambiente.instancia = value; }
        }

        private Ambiente()
        {
            resolucoes.Add(new Size(240,320));
            resolucoes.Add(new Size(480,800));
            resolucoes.Add(new Size(480,640));
        }

        public string Versao
        {
            get
            {
                return "1.2";
            }
        }

        public string ObterResolucoesSuportadas()
        {
            string s = "";
            for (int i = 0; i < resolucoes.Count; i++)
            {
                Size res = (Size)resolucoes[i];
                s += res.Width + "x" + res.Height + "\n";
            }
            return s;
        }
        
        public bool ResolucaoSuportada(Size size)
        {
            for (int i = 0; i < resolucoes.Count; i++)
            {
                Size res = (Size)resolucoes[i];
                if (res.Height == size.Height && res.Width == size.Width)
                {
                    return true;
                }
            }
            return false;
        }

        public string ObterResolucao()
        {
            int width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            return width.ToString() + "x" + height.ToString();
        }

        public string ObterDiretorioImagensCompativeis()
        {
            int width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            return "_" + width.ToString() + "x" + height.ToString();
        }

    }

}
