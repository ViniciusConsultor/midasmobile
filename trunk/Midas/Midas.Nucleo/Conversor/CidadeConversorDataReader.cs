using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Conversor
{

    /// <summary>
    /// Conversor de Cidades.
    /// </summary>
    public class CidadeConversorDataReader:IConversor
    {

        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Cidade cidade = new Cidade();
            cidade.Id = dataReader.GetInt32(0);
            cidade.Nome = dataReader.GetString(1);
            if (dataReader.GetValue(2) != DBNull.Value)
            {
                cidade.Estado = (Estado)Negocio.NegocioFactory.Instancia.EstadoNegocio.Obter(dataReader.GetInt32(2));
            }
            return cidade;
        }

        #endregion

    }

}
