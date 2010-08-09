using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Conversor
{
    public class PessoaJuridicaConversorDataReader:IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            PessoaJuridica pj = new PessoaJuridica();
            pj.Id = dataReader.GetInt32(0);
            pj.CNPJ = dataReader.GetString(1);
            pj.Endereco = (Endereco)Midas.Nucleo.Negocio.NegocioFactory.Instancia.EnderecoNegocio.Obter(dataReader.GetInt32(3));
            pj.NomeFantasia = dataReader.GetString(2);
            return pj;
        }

        #endregion

    }
}
