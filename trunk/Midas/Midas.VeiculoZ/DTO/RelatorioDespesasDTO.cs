using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.VeiculoZ.DTO
{
    public class RelatorioDespesasDTO
    {
        private string tipoDespesa;
        public string TipoDespesa
        {
            get { return tipoDespesa; }
            set { tipoDespesa = value; }
        }

        private double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

    }

}