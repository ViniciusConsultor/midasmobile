using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Conversor
{

    public class PaisConversorDataReader:IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Pais pais = new Pais();
            pais.Id = dataReader.GetInt32(0);
            pais.Nome = dataReader.GetString(1);
            return pais;

        }

        #endregion
    }

}
