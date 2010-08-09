using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Financeiro.Objetos
{

    /// <summary>
    /// Classe representando uma Transação.
    /// </summary>
    public class Transacao:ObjetoNegocio
    {

        /// <summary>
        /// Conta que paga esta transação.
        /// </summary>
        private Conta conta;
        public Conta Conta
        {
            get { return conta; }
            set { conta = value; }
        }

        /// <summary>
        /// Valor da Transação.
        /// </summary>
        private Decimal valor;
        public Decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }


        /// <summary>
        /// Qualquer tipo de observação sobre a Transação.
        /// </summary>
        private string observacoes;
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        /// <summary>
        /// Categoria da Transação.
        /// </summary>
        private Categoria categoria;
        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

    }

}