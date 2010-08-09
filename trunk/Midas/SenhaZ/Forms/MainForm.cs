using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SenhaZ.Forms;

namespace SenhaZ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pbAcessar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boooosta");
        }

        private void menuItemNovaCategoria_Click(object sender, EventArgs e)
        {
            FormFactory.Instance.Navegar(typeof(CadastroCategoria)).Show();
        }

        private void menuItemListarCategorias_Click(object sender, EventArgs e)
        {
            FormFactory.Instance.Navegar(typeof(ListarCategorias)).Show();
        }

       
    }
}