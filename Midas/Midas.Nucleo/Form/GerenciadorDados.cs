using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Midas.Nucleo.Form
{
    
    public sealed class GerenciadorDados
    {
        private StackForm formularioAnterior;
        public StackForm FormularioAnterior
        {
            get { return formularioAnterior; }
            set { formularioAnterior = value; }
        }

        private Objetos.ObjetoNegocio objeto;
        private IList lista;
        public IList Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        private static GerenciadorDados instancia = new GerenciadorDados();
        public static GerenciadorDados Instancia
        {
            get { return GerenciadorDados.instancia; }
            set { GerenciadorDados.instancia = value; }
        }

        private GerenciadorDados() { }

        public void Set(Objetos.ObjetoNegocio obj)
        {
            this.objeto = obj;
        }

        public Objetos.ObjetoNegocio Get()
        {
            return this.objeto;
        }

        public void SetLista(IList lista)
        {
            this.lista = lista;
        }

        public IList GetLista()
        {
            return lista;
        }

        public void Clear()
        {
            objeto = null;
            lista = null;
        }

    }

}
