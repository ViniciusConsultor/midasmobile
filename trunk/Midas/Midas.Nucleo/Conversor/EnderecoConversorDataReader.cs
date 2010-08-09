using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Conversor
{

    /// <summary>
    /// 
    /// </summary>
    public class EnderecoConversorDataReader:IConversor
    {

        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Endereco endereco = new Endereco();
            endereco.Id = dataReader.GetInt32(0);
            endereco.Logradouro = dataReader.GetString(1);
            endereco.Numero = dataReader.GetString(2);
            endereco.Bairro = dataReader.GetString(3);
            endereco.CodigoPostal = dataReader.GetString(4);
            endereco.Complemento = dataReader.GetString(5);
            if (dataReader.GetValue(6) != DBNull.Value)
            {
                endereco.Cidade = (Cidade)Negocio.NegocioFactory.Instancia.CidadeNegocio.Obter(dataReader.GetInt32(6));
            }
            return endereco;
        }

        #endregion

    }

}
