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
using Midas.Nucleo.Form;
using Midas.Nucleo.Objetos;
using Midas.VeiculoZ.Validador;
using Midas.Nucleo.Validador;
using System.Collections;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{

    public partial class CadastroAbastecimento : CRUDFormVeiculoZ
    {

        public CadastroAbastecimento()
        {
            this.Validador = new PercursoValidador();
            InitializeComponent();

            CarregadorImagens.ObterImagemCompativel("Calculadora", pCalcKM);
            CarregadorImagens.ObterImagemCompativel("Calculadora", pCalcPrecoLitro);
            CarregadorImagens.ObterImagemCompativel("Calculadora", pCalcPrecoTotal);
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddPosto);
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddTipo);
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddVeiculo);

            cmbVeiculos.DataSource = VeiculozFachada.Instancia.ListarVeiculos();
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";

            cmbTipoCombustivel.DataSource = VeiculozFachada.Instancia.ListarTiposCombustivel();
            cmbTipoCombustivel.ValueMember = "Id";
            cmbTipoCombustivel.DisplayMember = "Nome";

            cmbPosto.DataSource = VeiculozFachada.Instancia.ListarPostos();
            cmbPosto.ValueMember = "Id";
            cmbPosto.DisplayMember = "Nome";

        }

        public override void DoSalvar(ObjetoNegocio objeto)
        {
            Percurso p = (Percurso)objeto;
            VeiculozFachada.Instancia.SalvarPercurso(p);
            tId.Text = objeto.Id.ToString();
            IList ms = VeiculozFachada.Instancia.ListarManutencoesVeiculoPorKM(p.OdometroInicio, p.Veiculo.Id);
            if (ms.Count > 0)
            {
                string str = "";
                for (int i = 0; i < ms.Count; i++)
                {
                    Manutencao m = (Manutencao)ms[i];
                    str += " - " + m.Descricao + "  aos  " + m.Km + " Km rodados. \n";
                }
                MessageBox.Show("Existem Manutenções a serem feitas neste veículo!\n\n" + str, "Manutenções");
            }
        }

        public override void DoExcluir(long id)
        {
            VeiculozFachada.Instancia.ExcluirPercurso(id);
        }

        public override ObjetoNegocio ConstruirObjeto()
        {
            Percurso percurso = new Percurso();
            Abastecimento abastecimento = new Abastecimento();
            if (tIdAbastecimento.Text != "")
            {
                abastecimento.Id = Int32.Parse(tIdAbastecimento.Text);
            }
            abastecimento.Data = new DateTime(this.data.Value.Year, this.data.Value.Month, this.data.Value.Day, this.hora.Value.Hour, this.hora.Value.Minute, this.hora.Value.Second);
            abastecimento.Observacoes = tObs.Text;
            abastecimento.Posto = (Posto)cmbPosto.SelectedItem;
            abastecimento.TanqueCheio = chkTanqueCheio.Checked;
            abastecimento.TipoCombustivel = (TipoCombustivel)cmbTipoCombustivel.SelectedItem;
            if (tValor.Text != "")
            {
                try
                {
                    abastecimento.Valor = double.Parse(tValor.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Informe um Valor válido.", "Erro");
                }
            }
            if (tValorLitro.Text != "")
            {
                try
                {
                    abastecimento.ValorLitro = double.Parse(tValorLitro.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Informe um Valor do Litro válido.", "Erro");
                }
            }
            percurso.AbastecimentoInicial = abastecimento;
            if (tId.Text != "")
            {
                percurso.Id = Int32.Parse(tId.Text);
            }
            if (tKmFinal.Text != "")
            {
                percurso.OdometroFim = long.Parse(tKmFinal.Text);
            }
            if (tKmInicial.Text != "")
            {
                percurso.OdometroInicio = long.Parse(tKmInicial.Text);
            }
            percurso.Veiculo = (Veiculo)cmbVeiculos.SelectedItem;
            percurso.Viagem = chkViagem.Checked;
            return percurso;
        }

        public override void  Limpar()
        {
            tId.Text = "";
            tIdAbastecimento.Text = "";
            tKmFinal.Text = "";
            tKmInicial.Text = "";
            tLitros.Text = "";
            tObs.Text = "";
            tValor.Text = "";
            tValorLitro.Text = "";
            chkTanqueCheio.Checked = false;
            chkViagem.Checked = false;
            cmbPosto.SelectedItem = new Posto();
            cmbTipoCombustivel.SelectedItem = new TipoCombustivel();
            cmbVeiculos.SelectedItem = new Veiculo();
        }

        public override void TratarDados()
        {
            Percurso percurso = (Percurso)GerenciadorDados.Instancia.Get();
            if (percurso != null)
            {
                tId.Text = percurso.Id.ToString();
                tIdAbastecimento.Text = percurso.AbastecimentoInicial.Id.ToString();
                tKmInicial.Text = percurso.OdometroInicio.ToString();
                tKmFinal.Text = percurso.OdometroFim.ToString();
                chkViagem.Checked = percurso.Viagem;
                cmbVeiculos.SelectedValue = percurso.Veiculo.Id;
                data.Value = percurso.AbastecimentoInicial.Data;
                hora.Value = percurso.AbastecimentoInicial.Data;
                cmbPosto.SelectedValue = percurso.AbastecimentoInicial.Posto.Id;
                cmbTipoCombustivel.SelectedValue = percurso.AbastecimentoInicial.TipoCombustivel.Id;
                chkTanqueCheio.Checked = percurso.AbastecimentoInicial.TanqueCheio;
                tValor.Text = percurso.AbastecimentoInicial.Valor.ToString();
                tValorLitro.Text = percurso.AbastecimentoInicial.ValorLitro.ToString();
                tObs.Text = percurso.AbastecimentoInicial.Observacoes;
                tLitros.Text = percurso.AbastecimentoInicial.Litros.ToString();
            }
        }

        public override void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);
        }

        public override void pSalvar_Click(object sender, EventArgs e)
        {
            base.Salvar();
        }

        public override void pExcluir_Click(object sender, EventArgs e)
        {
            base.Excluir(this.tId.Text);
        }

        public override void Lembrar()
        {
            cmbVeiculos.DataSource = VeiculozFachada.Instancia.ListarVeiculos();
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";

            cmbTipoCombustivel.DataSource = VeiculozFachada.Instancia.ListarTiposCombustivel();
            cmbTipoCombustivel.ValueMember = "Id";
            cmbTipoCombustivel.DisplayMember = "Nome";

            cmbPosto.DataSource = VeiculozFachada.Instancia.ListarPostos();
            cmbPosto.ValueMember = "Id";
            cmbPosto.DisplayMember = "Nome";
        }

        private void pAddPosto_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroPostos));
        }

        private void pAddTipo_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroTiposCombustivel));
        }

        private void pAddVeiculo_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroVeiculos));
        }

        private void CalcularLitros()
        {
            if (tValor.Text != "" && tValorLitro.Text != "")
            {
                try
                {
                    decimal valor = Decimal.Parse(tValor.Text);
                    decimal valorLitro = Decimal.Parse(tValorLitro.Text);
                    tLitros.Text = (valor/valorLitro).ToString("N3");
                }
                catch (Exception e)
                {
                    tLitros.Text = "";
                }
            }
        }

        private void pCalcPrecoLitro_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(tValorLitro);
            calc.ShowDialog();
            this.CalcularLitros();
        }

        private void pCalcPrecoTotal_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(tValor);
            calc.ShowDialog();
            this.CalcularLitros();
        }

        private void tValorLitro_KeyUp(object sender, KeyEventArgs e)
        {
            this.CalcularLitros();
        }

        private void tValor_KeyUp(object sender, KeyEventArgs e)
        {
            this.CalcularLitros();
        }

        private void pCalcKM_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(tKmInicial);
            calc.ShowDialog();
        }

    }

}