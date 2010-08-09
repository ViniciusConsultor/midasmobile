using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SenhaZ;
using SenhaZ.Negocio;

namespace SenhaZ.Forms
{
    public partial class ListarCategorias : Form
    {

        public ListarCategorias()
        {
            InitializeComponent();
        }

        private void ListarCategorias_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = SenhaZ.Negocio.SenhaZ.Instance.LocalizarCategorias();
            this.dataGridTableStyle.MappingName = dataGrid.DataSource.GetType().Name;

        }

    }

}