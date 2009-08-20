/*
 *  VeículoZ é um aplicativo para gerenciamento de abastecimentos e despesas
 *  de veículos.
 *  Copyright (C) 2009  Marlon Silva Carvalho
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Dados;
using System.Data;
using System.IO;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Dados.XML
{
    public class MotoristaDados : IAcessoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            string arquivo = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Motorista.xml";
            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }
            DataSet ds = new DataSet();
            Motorista motorista = (Motorista)objeto;
            DataTable dt = new DataTable();
            dt.Columns.Add("dataRenovacao", typeof(DateTime));
            dt.Columns.Add("nome", typeof(string));
            dt.Columns.Add("numeroCarteira", typeof(string));
            dt.Rows.Add(new object[] { motorista.DataRenovacao, motorista.Nome, motorista.NumeroCarteira });
            ds.Tables.Add(dt);
            ds.AcceptChanges();
            ds.WriteXml(arquivo, XmlWriteMode.IgnoreSchema);
        }

        public void Excluir(long id)
        {
            throw new NotImplementedException();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            string arquivo = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Motorista.xml";
            Motorista motorista = new Motorista();
            if (File.Exists(arquivo))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(arquivo);
                motorista.DataRenovacao = DateTime.Parse((string)ds.Tables[0].Rows[0]["dataRenovacao"]);
                motorista.Nome = (string)ds.Tables[0].Rows[0]["nome"];
                motorista.NumeroCarteira = (string)ds.Tables[0].Rows[0]["numeroCarteira"];
            }
            return motorista;
        }

        public System.Collections.IList Localizar()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}