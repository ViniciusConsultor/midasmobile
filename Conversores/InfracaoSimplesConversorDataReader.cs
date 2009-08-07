using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Conversor;
using System.Data.SqlServerCe;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Conversores
{
    public class InfracaoSimplesConversorDataReader:IConversor
    {

        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Infracao infracao = new Infracao();
            infracao.Descricao = dataReader.GetString(2);
            infracao.Id = dataReader.GetInt32(5);
            return infracao;
        }

        #endregion
    }
}
