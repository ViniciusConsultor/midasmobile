using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.Financeiro.Objetos
{

    /// <summary>
    /// Classe representando uma Conta.
    /// Não é necessariamente uma conta de Banco, mas uma conta para entrada e saída de dinheiro.
    /// </summary>
    public class Conta:ObjetoNegocio
    {

        /// <summary>
        /// Valor Inicial da Conta.
        /// O valor que será usado para abrir a conta.
        /// </summary>
        private Decimal valorInicial;
        public Decimal ValorInicial
        {
            get { return valorInicial; }
            set { valorInicial = value; }
        }

        /// <summary>
        /// Simples descrição da Conta.
        /// </summary>
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }

}
