using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Midas.VeiculoZ.Negocio
{
    public class VerificadorVersoes
    {

        public string NovaVersao()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://veiculoz.net/versao.php");
                request.AllowWriteStreamBuffering = true;
                request.KeepAlive = true;
                request.Method = "POST";
                request.Timeout = System.Threading.Timeout.Infinite;
                Stream req = request.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(req);
                string s = sr.ReadLine();
                req.Close();
                if (s != null && s == Ambiente.Instancia.Versao)
                {
                    return ("Sua versão é a mais atual.");
                }
                else
                {
                    return ("Está disponível em http://veiculoz.net/ uma versão mais atual que a versão instalada neste dispositivo.");
                }
            }
            catch (Exception ex)
            {
                return ("Não foi possível verificar novas versões.");
            }
        }

    }

}
