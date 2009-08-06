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
using Midas.Nucleo.Objetos;
using Midas.VeiculoZ.Validador;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{
    public partial class CadastroDespesa : CRUDFormVeiculoZ
    {
        public CadastroDespesa()
        {
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("Calculadora", pCalcValor);
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddLocal);
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddTipo);
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddVeiculo);
            this.Validador = new DespesaValidador();
            this.CarregarCombos();
        }

        private void CarregarCombos()
        {
            cmbLocais.DataSource = Nucleo.NucleoFachada.Instancia.ListarPessoasJuridicas();
            cmbLocais.DisplayMember = "NomeFantasia";
            cmbLocais.ValueMember = "Id";

            cmbTipos.DisplayMember = "Nome";
            cmbTipos.ValueMember = "Id";
            cmbTipos.DataSource = VeiculozFachada.Instancia.ListarTodosTiposDespesa();

            cmbVeiculos.DataSource = VeiculozFachada.Instancia.ListarVeiculos();
            cmbVeiculos.DisplayMember = "Modelo";
            cmbVeiculos.ValueMember = "Id";
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

        public override void DoSalvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Despesa d = (Despesa)objeto;
            VeiculozFachada.Instancia.SalvarDespesa(d);
            tId.Text = objeto.Id.ToString();
        }

        public override Midas.Nucleo.Objetos.ObjetoNegocio ConstruirObjeto()
        {
            Despesa despesa = new Despesa();
            if (tId.Text != "")
            {
                despesa.Id = Int32.Parse(tId.Text);
            }
            despesa.Descricao = tDescricao.Text;
            despesa.Data = new DateTime(this.data.Value.Year, this.data.Value.Month, this.data.Value.Day, this.hora.Value.Hour, this.hora.Value.Minute, this.hora.Value.Second);
            despesa.Empresa = (PessoaJuridica)cmbLocais.SelectedItem;
            despesa.Tipo = (TipoDespesa)cmbTipos.SelectedItem;
            despesa.Veiculo = (Veiculo)cmbVeiculos.SelectedItem;
            if (tValor.Text != "")
            {
                try
                {
                    despesa.Valor = Decimal.Parse(tValor.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O campo Valor deve conter apenas valores numéricos.");
                }
            }
            return despesa;
        }

        public override void DoExcluir(long id)
        {
            VeiculozFachada.Instancia.ExcluirDespesa(id);
        }

        public override void TratarDados()
        {
            Despesa despesa = (Despesa)GerenciadorDados.Instancia.Get();
            if (despesa != null)
            {
                tId.Text = despesa.Id.ToString();
                tDescricao.Text = despesa.Descricao;
                cmbLocais.SelectedValue = despesa.Empresa.Id;
                cmbVeiculos.SelectedValue = despesa.Veiculo.Id;
                cmbTipos.SelectedValue = despesa.Tipo.Id;
                data.Value = despesa.Data;
                hora.Value = despesa.Data;
                tValor.Text = despesa.Valor.ToString();
            }
        }

        public override void Lembrar()
        {
            this.CarregarCombos();
        }

        public override void Limpar()
        {
            tId.Text = "";
            tDescricao.Text = "";
            tValor.Text = "";
        }

        private void pAddTipo_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroTipoDespesa));
        }

        private void pAddLocal_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroEmpresa));
        }

        private void pAddVeiculo_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroVeiculos));
        }

        private void pCalcPrecoTotal_Click(object sender, EventArgs e)
        {

        }

        private void pCalcValor_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(tValor);
            calc.ShowDialog();
        }

    }

}