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
using System.Reflection;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{
    public partial class Inicio : ListForm
    {
        public Inicio()
        {
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("MenuIconeAbastecimentos", pIconeAbastecimentos);
            CarregadorImagens.ObterImagemCompativel("MenuIconeManutencoes", pIconeManutencoes);
            CarregadorImagens.ObterImagemCompativel("MenuIconeDespesas", pIconeDespesas);
            CarregadorImagens.ObterImagemCompativel("MenuIconePostos", pIconePostos);
            CarregadorImagens.ObterImagemCompativel("Logo", pLogo);
        }

        public override void TratarDados()
        {
            IList veiculos = VeiculozFachada.Instancia.ListarVeiculos();
            for (int i = 0; i < veiculos.Count; i++)
            {
                Veiculo veiculo = (Veiculo)veiculos[i];
                IList manutencoes = VeiculozFachada.Instancia.ListarManutencoesVeiculoPorData(DateTime.Now, veiculo.Id);
                string mensagem = "Existem manutenções para serem feitas no veículo " + veiculo.Modelo + ": \n";
                bool existe = false;
                for (int j = 0; j < manutencoes.Count; j++)
                {
                    Manutencao manutencao = (Manutencao)manutencoes[j];
                    mensagem += " - " + manutencao.Descricao + "  no dia " + manutencao.Data.ToString("dd/MM/yyyy") + ". \n";
                    existe = true;
                }
                if (existe)
                {
                    MessageBox.Show(mensagem, "Atenção");
                }                
                existe = false;
            }
            Motorista motorista = VeiculozFachada.Instancia.ObterMotorista();
            if (motorista.DataRenovacao != null && motorista.DataRenovacao.Year != 0001 && motorista.DataRenovacao <= DateTime.Now)
            {
                MessageBox.Show("Sua carteira de Motorista está vencida! Data da renovação: " + motorista.DataRenovacao.ToString("dd/MM/yyyy") + ".", "Alerta");
            }
            cmbVeiculos.DataSource = veiculos;
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";
        }

        private void ObterConsumoMedio()
        {
            Veiculo veiculo = (Veiculo)cmbVeiculos.SelectedItem;
            if (veiculo != null)
            {
                this.lbConsumoMedio.Text = VeiculozFachada.Instancia.ObterConsumoMedioVeiculo(veiculo.Id).ToString("N3") + " Km/L";
            }
        }

        private void pPostos_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemPostos));
        }

        private void pAbastecimentos_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemAbastecimentos));
        }

        private void cmbVeiculos_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ObterConsumoMedio();
        }

        private void pDespesas_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemDespesas));
        }

        private void pManutencao_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemManutencoes));

        }

    }

}