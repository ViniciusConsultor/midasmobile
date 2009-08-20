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
    public partial class FiltrosGraficoConsumoMedio : StackForm
    {
        public FiltrosGraficoConsumoMedio()
        {
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("Logo", pLogo);
        }

        public override void TratarDados()
        {
            cmbPosto.DisplayMember = "Nome";
            cmbPosto.ValueMember = "Id";
            IList postos = VeiculozFachada.Instancia.ListarPostos();
            Posto posto = new Posto();
            posto.Id = -1;
            posto.PessoaJuridica = new Midas.Nucleo.Objetos.PessoaJuridica();
            posto.PessoaJuridica.NomeFantasia = "Selecione um Posto";
            postos.Add(posto);
            cmbPosto.DataSource = postos;
            cmbPosto.SelectedIndex = cmbPosto.Items.Count-1;

            cmbTipoCombustivel.DisplayMember = "Nome";
            cmbTipoCombustivel.ValueMember = "Id";
            IList tipos = VeiculozFachada.Instancia.ListarTiposCombustivel();
            TipoCombustivel tipo = new TipoCombustivel();
            tipo.Id = -1;
            tipo.Nome = "Selecione um Tipo de Combustível";
            tipos.Add(tipo);
            cmbTipoCombustivel.DataSource = tipos;
            cmbTipoCombustivel.SelectedIndex = cmbTipoCombustivel.Items.Count-1;

            cmbVeiculo.DisplayMember = "Modelo";
            cmbVeiculo.ValueMember = "Id";
            cmbVeiculo.DataSource = VeiculozFachada.Instancia.ListarVeiculos();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = (Veiculo)cmbVeiculo.SelectedItem;
            TipoCombustivel tipo = (TipoCombustivel)cmbTipoCombustivel.SelectedItem;
            Posto posto = (Posto)cmbPosto.SelectedItem;
            DateTime d1= this.data1.Value;
            DateTime d2 = this.data2.Value;
            GerenciadorDados.Instancia.Clear();
            IList lista = VeiculozFachada.Instancia.ListarPercursos(veiculo.Id, tipo.Id, posto.Id, d1, d2, chkViagem.Checked);
            if (lista.Count > 0)
            {
                GerenciadorDados.Instancia.SetLista(lista);
                Program.FormStack.Push(typeof(GraficoConsumoMedio));
            }
            else
            {
                MessageBox.Show("Não há dados a serem exibidos.","Informação");
            }
        }

    }

}