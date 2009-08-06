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
using Midas.VeiculoZ.Validador;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Form;

namespace Midas.VeiculoZ.Forms
{
    public partial class CadastroMotorista : CRUDFormVeiculoZ
    {
        public CadastroMotorista()
        {
            InitializeComponent();
            this.Validador = new MotoristaValidador();
        }

        public override void DoExcluir(long id)
        {
        }

        public override void TratarDados()
        {
            Motorista motorista = VeiculozFachada.Instancia.ObterMotorista();
            tNome.Text = motorista.Nome;
            tNumero.Text = motorista.NumeroCarteira;
            if (motorista.DataRenovacao != null)
            {
                dataRenovacao.Value = motorista.DataRenovacao;
            }
        }

        public override void DoSalvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Motorista motorista = (Motorista)objeto;
            VeiculozFachada.Instancia.SalvarMotorista(motorista);
        }

        public override Midas.Nucleo.Objetos.ObjetoNegocio ConstruirObjeto()
        {
            Motorista motorista = new Motorista();
            motorista.DataRenovacao = dataRenovacao.Value;
            motorista.Nome = tNome.Text;
            motorista.NumeroCarteira = tNumero.Text;
            return motorista;
        }

        public override void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);
        }

        public override void Limpar()
        {
            this.tNumero.Text = "";
            this.tNome.Text = "";
        }

        public override void pSalvar_Click(object sender, EventArgs e)
        {
            base.Salvar();
        }

        public override void pExcluir_Click(object sender, EventArgs e)
        {
        }

    }
}