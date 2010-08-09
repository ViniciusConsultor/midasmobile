using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SenhaZ.Forms
{
    public class FormFactory
    {
        private Form formulario;
        private Hashtable formularios = new Hashtable();

        private static FormFactory instance = new FormFactory();
        public static FormFactory Instance
        {
            get { return FormFactory.instance; }
            set { FormFactory.instance = value; }
        }

        public Form Navegar(Type type)
        {
            if (formularios.ContainsKey(type))
            {
                return (Form)formularios[type];
            } 
            Object objeto = Activator.CreateInstance(type);
            formularios.Add(type, objeto);
            if (formulario != null)
            {
                formulario.Hide();
            }
            formulario = (Form)objeto;
            return (Form)objeto;
        }

    }

}
