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
using Midas.VeiculoZ.Objetos;
using Midas.VeiculoZ.DTO;
using Midas.Nucleo.Form;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{
    public partial class RelatorioGeral : ListForm
    {
        private System.EventHandler handler;

        public RelatorioGeral()
        {
            InitializeComponent();
            handler = new System.EventHandler(this.cmbVeiculos_SelectedValueChanged);
            CarregadorImagens.ObterImagemCompativel("Logo", pLogo);
        }

        public override void TratarDados()
        {
            this.cmbVeiculos.SelectedIndexChanged -= handler;
            cmbVeiculos.DataSource = VeiculozFachada.Instancia.ListarVeiculos();
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";
            this.cmbVeiculos.SelectedIndexChanged += handler;
            this.ObterDados();
        }

        private void ObterDados()
        {
            Veiculo veiculo = (Veiculo)cmbVeiculos.SelectedItem;
            if (veiculo != null)
            {
                RelatorioGeralDTO dto = VeiculozFachada.Instancia.ObterRelatorioGeral(veiculo.Id);
                tGastoTotal.Text = dto.GastoTotal;
                tTotalKM.Text = dto.TotalKM;
                tTotalLitros.Text = dto.TotalLitros;
                tMelhorPosto.Text = dto.MelhorPosto;
                tPiorPosto.Text = dto.PiorPosto;
            }
        }

        private void cmbVeiculos_SelectedValueChanged(object sender, EventArgs e)
        {
            ObterDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Program.FormStack.Pop(1);
        }

    }
}