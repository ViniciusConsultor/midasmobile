using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Conversor
{

    /// <summary>
    /// Conversor de Estados.
    /// </summary>
    public class EstadoConversorDataReader:IConversor
    {

        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Estado estado = new Estado();
            estado.Id = dataReader.GetInt32(0);
            estado.Nome = dataReader.GetString(1);
            if (dataReader.GetInt32(2) != null)
            {
                estado.Pais = (Pais)Negocio.NegocioFactory.Instancia.PaisNegocio.Obter(dataReader.GetInt32(2));
            }
            return estado;
        }

        #endregion

    }

}