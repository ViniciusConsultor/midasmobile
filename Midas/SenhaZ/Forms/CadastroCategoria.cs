using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SenhaZ.Objetos;

namespace SenhaZ.Forms
{
    public partial class CadastroCategoria : Form
    {
        public CadastroCategoria()
        {
            InitializeComponent();
        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            if (txtID.Text != "")
            {
                categoria.Id = long.Parse(txtID.Text);
            }
            categoria.Nome = txtNome.Text;
            SenhaZ.Negocio.SenhaZ.Instance.SalvarCategoria(categoria);
        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            FormFactory.Instance.Navegar(typeof(ListarCategorias)).Show();
        }
    }
}