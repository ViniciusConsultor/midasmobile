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
using Midas.VeiculoZ.Validador;

namespace Midas.VeiculoZ.Forms
{
    public partial class CadastroVeiculos : CRUDFormVeiculoZ
    {
        public CadastroVeiculos()
        {
            this.Validador = new VeiculoValidador();
            InitializeComponent();
        }

        public override void  Limpar()
        {
            this.tId.Text = "";
            this.tCor.Text = "";
            this.tMarca.Text = "";
            this.tModelo.Text = "";
            this.tPlaca.Text = "";
            this.tRenavam.Text = "";
        }

        public override void TratarDados()
        {
            Veiculo veiculo = (Veiculo)GerenciadorDados.Instancia.Get();

            if (veiculo != null)
            {
                this.tId.Text = veiculo.Id.ToString();
                this.tCor.Text = veiculo.Cor;
                this.tMarca.Text = veiculo.Marca;
                this.tModelo.Text = veiculo.Modelo;
                this.tPlaca.Text = veiculo.Placa;
                this.tRenavam.Text = veiculo.Renavam;
            }
            else
            {
                this.Limpar();
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

        public override void DoExcluir(long id)
        {
            VeiculozFachada.Instancia.ExcluirVeiculo(id);
        }

        public override void DoSalvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Veiculo veiculo = (Veiculo)objeto;
            VeiculozFachada.Instancia.SalvarVeiculo(veiculo);
            this.tId.Text = veiculo.Id.ToString();
        }

        public override Midas.Nucleo.Objetos.ObjetoNegocio ConstruirObjeto()
        {
            Veiculo veiculo = new Veiculo();
            if (this.tId.Text != "")
            {
                veiculo.Id = Int32.Parse(this.tId.Text);
            }
            veiculo.Cor = tCor.Text;
            veiculo.Renavam = tRenavam.Text;
            veiculo.Placa = tPlaca.Text;
            veiculo.Marca = tMarca.Text;
            veiculo.Modelo = tModelo.Text;
            return veiculo;
        }

    }
}