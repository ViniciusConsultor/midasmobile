using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.Financeiro.Dados
{
    
    /// <summary>
    /// Classe fábrica de objetos para acesso a dados.
    /// </summary>
    public class DadosFactory
    {

        /// <summary>
        /// Instância Singleton.
        /// </summary>
        private static DadosFactory instancia = new DadosFactory();
        public static DadosFactory Instancia
        {
            get { return DadosFactory.instancia; }
            set { DadosFactory.instancia = value; }
        }

        /// <summary>
        /// Construtor Privado: Singleton.
        /// </summary>
        private DadosFactory() { }

        /// <summary>
        /// Acesso a Dados para Categorias.
        /// </summary>
        private ICategoriaDados categoriaDados = new Dados.SQLServer.CategoriaDados();
        public ICategoriaDados CategoriaDados
        {
            get 
            {
                return this.categoriaDados;
            }
        }

    }

}