using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Midas.Nucleo.Form;

namespace Midas.VeiculoZ.Forms
{
    public partial class VerificarVersao : StackForm
    {

        public VerificarVersao()
        {
            InitializeComponent();
        }

        public override void TratarDados()
        {
            this.lblUpdate.Text = "Clique em Buscar";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Program.FormStack.Pop(1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lblUpdate.Text = "Verificando... Por favor, aguarde.";
            System.Threading.Thread.Sleep(1000);
            string msg = new Negocio.VerificadorVersoes().NovaVersao();
            this.lblUpdate.Text = msg;
        }

    }

}