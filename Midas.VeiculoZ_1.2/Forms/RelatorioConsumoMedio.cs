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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Midas.Nucleo.Form;
using Midas.VeiculoZ.Objetos;
using System.Collections;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{
    public partial class RelatorioConsumoMedio : StackForm
    {
        public RelatorioConsumoMedio()
        {
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("Logo", pLogo);
        }

        public override void TratarDados()
        {
            cmbTipoCombustivel.DisplayMember = "Nome";
            cmbTipoCombustivel.ValueMember = "Id";
            IList tipos = VeiculozFachada.Instancia.ListarTiposCombustivel();
            TipoCombustivel tipo = new TipoCombustivel();
            tipo.Id = -1;
            tipo.Nome = "Selecione um Tipo de Combustível";
            tipos.Add(tipo);
            cmbTipoCombustivel.DataSource = tipos;
            cmbTipoCombustivel.SelectedIndex = cmbTipoCombustivel.Items.Count - 1;

            cmbVeiculos.DisplayMember = "Modelo";
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DataSource = VeiculozFachada.Instancia.ListarVeiculos();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = (Veiculo)cmbVeiculos.SelectedItem;
            TipoCombustivel tipo = (TipoCombustivel)cmbTipoCombustivel.SelectedItem;
            DateTime d1 = this.data1.Value;
            DateTime d2 = this.data2.Value;
            GerenciadorDados.Instancia.Clear();
            IList lista = VeiculozFachada.Instancia.ListarPercursos(veiculo.Id, tipo.Id, -1, d1, d2, chkViagem.Checked);
            if (lista.Count > 0)
            {
                this.dataGrid.DataSource = lista;
                this.dataGridTableStyle1.MappingName = dataGrid.DataSource.GetType().Name;
            }
            else
            {
                this.dataGrid.DataSource = new ArrayList();
                MessageBox.Show("Não há dados a serem exibidos.", "Informação");
            }
 
        }

    }

}