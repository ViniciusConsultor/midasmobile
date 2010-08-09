using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Financeiro.Objetos
{

    /// <summary>
    /// Classe que representa uma Categoria de Transação.
    /// </summary>
    public class Categoria:ObjetoNegocio
    {
        public enum TipoCategoria { Receita=1, Despesa=2};

        /// <summary>
        /// Descrição da Categoria.
        /// </summary>
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Tipo de Categoria.
        /// </summary>
        private int tipo;
        public int Tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        /// <summary>
        /// Categoria Pai desta, caso exista.
        /// </summary>
        private Categoria categoriaPai;
        public Categoria CategoriaPai
        {
            get { return categoriaPai; }
            set { categoriaPai = value; }
        }

    }

}