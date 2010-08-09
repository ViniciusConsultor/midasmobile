using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Dados.SQLServerCE;
using Midas.Nucleo.Recursos;

namespace Midas.Financeiro.Negocio
{
    public class CargaSistema:Midas.Nucleo.Negocio.ICargaSistema
    {

        #region ICargaSistema Members

        public void Iniciar()
        {

            SQLServerCE servidor = new SQLServerCE(ConstantesGerais.BancoFinanceiro);

            // Criar o banco de dados para o Financeiro.
            if (!servidor.BancoExiste())
            {
                servidor.CriarBancoDados();
                this.IniciarTabelas();
            }

        }

        private void IniciarTabelas()
        {
            new Comando(Recursos.ComandosSQL.TabelaCategoria, ConstantesGerais.BancoFinanceiro).Executar();
        }

        #endregion
    }
}
