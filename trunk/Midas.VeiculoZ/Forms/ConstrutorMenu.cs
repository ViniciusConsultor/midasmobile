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
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Midas.Nucleo.Form;
using System;
using Microsoft.WindowsCE.Forms;

namespace Midas.VeiculoZ.Forms
{
    public sealed class ConstrutorMenu:IConstrutorMenu
    {

        public ConstrutorMenu()
        {
        }

        private void DoConstruir(MainMenu m)
        {
            System.Windows.Forms.MenuItem miRelatorios = new System.Windows.Forms.MenuItem();
            
            System.Windows.Forms.MenuItem miRelatorios_GraficoConsumoMedio = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miRelatorios_RelatorioConsumoMedio = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miRelatorios_RelatorioGeral = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miRelatorios_GraficoDespesas = new System.Windows.Forms.MenuItem();

            miRelatorios_RelatorioGeral.Text = "Relatório Geral";
            miRelatorios_RelatorioConsumoMedio.Text = "Relatório Consumo Médio";
            miRelatorios_GraficoConsumoMedio.Text = "Gráfico Consumo Médio";
            miRelatorios.MenuItems.Add(miRelatorios_GraficoConsumoMedio);
            miRelatorios.MenuItems.Add(miRelatorios_GraficoDespesas);
            miRelatorios.MenuItems.Add(miRelatorios_RelatorioConsumoMedio);
            miRelatorios.MenuItems.Add(miRelatorios_RelatorioGeral);
            miRelatorios_GraficoConsumoMedio.Click += new System.EventHandler(miRelatorios_GraficoConsumoMedio_Click);
            miRelatorios_RelatorioConsumoMedio.Click += new System.EventHandler(miRelatorios_RelatorioConsumoMedio_Click);
            miRelatorios_RelatorioGeral.Click += new System.EventHandler(miRelatorios_RelatorioConsumoGeral_Click);
            miRelatorios_GraficoDespesas.Click += new System.EventHandler(miRelatorios_GraficoDespesas_Click);

            System.Windows.Forms.MenuItem miOpcoes = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesSobre = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesCadastros_Abastecimento = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesCadastros = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesCadastros_TipoCombustivel = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesCadastros_Veiculos = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesCadastros_Motorista = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesCadastros_Manutencoes = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesCadastros_Distribuidoras = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesCadastros_Postos = new System.Windows.Forms.MenuItem();

            // Despesas
            System.Windows.Forms.MenuItem miOpcoesDespesas = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesDespesas_Empresa = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesDespesas_TiposDespesa = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem miOpcoesDespesas_Despesas = new System.Windows.Forms.MenuItem();
            miOpcoesDespesas_Empresa.Text = "Empresas";
            miOpcoesDespesas.Text = "Despesas";
            miOpcoesDespesas_TiposDespesa.Text = "Tipos de Despesa";
            miOpcoesDespesas_TiposDespesa.Click += new System.EventHandler(miOpcoesTiposDespesa_Click);
            miOpcoesDespesas_Empresa.Click += new System.EventHandler(miOpcoesDespesas_Empresa_Click);
            miOpcoesDespesas_Despesas.Text = "Listar Despesas";
            miOpcoesDespesas_Despesas.Click += new System.EventHandler(miOpcoesDespesa_Click);
            miOpcoesDespesas.MenuItems.Add(miOpcoesDespesas_TiposDespesa);
            miOpcoesDespesas.MenuItems.Add(miOpcoesDespesas_Despesas);
            miOpcoesDespesas.MenuItems.Add(miOpcoesDespesas_Empresa);

            // Multas
            System.Windows.Forms.MenuItem miOpcoesDespesas_Multas = new System.Windows.Forms.MenuItem();
            miOpcoesDespesas_Multas.Text = "Multas";
            miOpcoesDespesas_Multas.Click += new System.EventHandler(miOpcoesDespesas_Multas_Click);
            miOpcoesDespesas.MenuItems.Add(miOpcoesDespesas_Multas);

            // Outros.
            miOpcoesCadastros_Abastecimento.Click += new System.EventHandler(miOpcoesCadastros_Abastecimentos_Click);
            miOpcoesCadastros_Abastecimento.Text = "Abastecimentos";
            miOpcoesSobre.Text = "Sobre";
            miOpcoesSobre.Click += new System.EventHandler(miOpcoesSobre_Click);
            miRelatorios.Text = "Relatórios";
            miOpcoes.Text = "Opções";
            miOpcoes.MenuItems.Add(miOpcoesCadastros);
            miOpcoesCadastros.Text = "Abastecimentos";
            miOpcoesCadastros_Postos.Text = "Postos";
            miOpcoesCadastros_TipoCombustivel.Text = "Tipo de Combustível";
            miOpcoesCadastros_Veiculos.Text = "Veículos";
            miOpcoesCadastros_Motorista.Text = "Motorista";
            miOpcoesCadastros_Distribuidoras.Text = "Distribuidoras";
            miOpcoesCadastros_Manutencoes.Text = "Manutenções";
            miOpcoesCadastros.MenuItems.Add(miOpcoesCadastros_Postos);
            miOpcoesCadastros.MenuItems.Add(miOpcoesCadastros_TipoCombustivel);
            
            miOpcoesCadastros.MenuItems.Add(miOpcoesCadastros_Distribuidoras);
            miOpcoesCadastros.MenuItems.Add(miOpcoesCadastros_Abastecimento);
            miOpcoesCadastros_TipoCombustivel.Click += new System.EventHandler(miOpcoesCadastros_TipoCombustivel_Click);
            miOpcoesCadastros_Veiculos.Click += new System.EventHandler(miOpcoesCadastros_Veiculo_Click);
            miOpcoesCadastros_Distribuidoras.Click += new System.EventHandler(miOpcoesCadastros_Distribuidoras_Click);
            miOpcoesCadastros_Postos.Click += new System.EventHandler(miOpcoesCadastros_Postos_Click);
            miOpcoesCadastros_Manutencoes.Click += new System.EventHandler(miOpcoesCadastros_Manutencoes_Click);
            miOpcoesCadastros_Motorista.Click += new System.EventHandler(miOpcoesCadastros_Motorista_Click);
            miOpcoes.MenuItems.Add(miOpcoesCadastros_Veiculos);
            miOpcoes.MenuItems.Add(miOpcoesCadastros_Manutencoes);
            miOpcoes.MenuItems.Add(miOpcoesDespesas);
            miOpcoes.MenuItems.Add(miOpcoesCadastros_Motorista);
            miOpcoes.MenuItems.Add(miOpcoesSobre);
            m.MenuItems.Add(miOpcoes);
            m.MenuItems.Add(miRelatorios);

            // Sair.
            System.Windows.Forms.MenuItem miSair = new System.Windows.Forms.MenuItem();
            miSair.Text = "Sair";
            miSair.Click += new System.EventHandler(miSair_Click);
            miOpcoes.MenuItems.Add(miSair);
        }

        public void Construir(MainMenu m)
        {
            this.DoConstruir(m);
        }

        private void miOpcoesDespesas_Multas_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemMultas));
        }

        private void miOpcoesCadastros_Motorista_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(CadastroMotorista));
        }

        private void miSair_Click(object sender, EventArgs e)
        {
            Program.FormStack.Stop();
        }

        private void miOpcoesTiposDespesa_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemTiposDespesa));
        }

        private void miOpcoesDespesa_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemDespesas));
        }

        private void miOpcoesSobre_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(Sobre));
        }

        private void miOpcoesCadastros_TipoCombustivel_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemTiposCombustivel));
        }
        
        private void miOpcoesCadastros_Veiculo_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemVeiculos));
        }

        private void miOpcoesCadastros_Distribuidoras_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemDistribuidoras));
        }

        private void miOpcoesCadastros_Postos_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemPostos));
        }

        private void miOpcoesCadastros_Abastecimentos_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemAbastecimentos));
        }

        private void miRelatorios_GraficoConsumoMedio_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(FiltrosGraficoConsumoMedio));
        }

        private void miRelatorios_RelatorioConsumoMedio_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(RelatorioConsumoMedio));
        }

        private void miRelatorios_RelatorioConsumoGeral_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(RelatorioGeral));
        }

        private void miRelatorios_GraficoDespesas_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(FiltrosGraficoDespesas));
        }

        private void miOpcoesDespesas_Empresa_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemEmpresas));
        }

        private void miOpcoesCadastros_Manutencoes_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemManutencoes));
        }

    }
}
