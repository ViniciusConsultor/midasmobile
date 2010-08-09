using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Negocio;
using Midas.Financeiro.Dados;
using Midas.Financeiro.Objetos;

namespace Midas.Financeiro.Negocio
{

    /// <summary>
    /// Classe de Negócio para Categorias.
    /// </summary>
    public class CategoriaNegocio:NegocioGenerico
    {
        
        /// <summary>
        /// Construtor.
        /// </summary>
        public CategoriaNegocio()
        {
            this.AcessoDados = Dados.DadosFactory.Instancia.CategoriaDados;
        }

    }

}
