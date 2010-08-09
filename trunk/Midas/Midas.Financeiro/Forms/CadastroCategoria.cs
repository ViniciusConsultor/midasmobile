using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Midas.Financeiro.Objetos;
using Midas.Financeiro.Negocio;
using Midas.Financeiro;

namespace Midas.Financeiro.Forms
{
    public partial class CadastroCategoria : Form
    {
        public CadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IFinanceiroFachada financeiro = new FinanceiroFachada();
            Categoria categoria = new Categoria();
            categoria.Descricao = this.txtDescricao.Text;
            financeiro.SalvarCategoria(categoria);
        }

    }

}