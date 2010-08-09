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
using Midas.VeiculoZ.Validador;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Forms
{
    public partial class CadastroTipoDespesa : CRUDFormVeiculoZ
    {
        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        public CadastroTipoDespesa()
        {
            this.Validador = new TipoDespesaValidador();
            InitializeComponent();
        }

        public override void Limpar()
        {
            this.tId.Text = "";
            this.tNome.Text = "";
        }

        public override void TratarDados()
        {
            TipoDespesa tipoDespesa = (TipoDespesa)GerenciadorDados.Instancia.Get();

            if (tipoDespesa != null)
            {
                this.tId.Text = tipoDespesa.Id.ToString();
                this.tNome.Text = tipoDespesa.Nome;
            }
            else
            {
                this.tId.Text = "";
                this.tNome.Text = "";
            }
        }

        public override void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);
        }

        public override Midas.Nucleo.Objetos.ObjetoNegocio ConstruirObjeto()
        {
            TipoDespesa tipoDespesa = new TipoDespesa();
            if (this.tId.Text != "")
            {
                tipoDespesa.Id = Int32.Parse(this.tId.Text);
            }
            tipoDespesa.Nome = this.tNome.Text;
            return tipoDespesa;
        }

        public override void DoSalvar(ObjetoNegocio objeto)
        {
            TipoDespesa d = (TipoDespesa)objeto;
            Midas.VeiculoZ.VeiculozFachada.Instancia.SalvarTipoDespesa(d);
            this.tId.Text = objeto.Id.ToString();
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
            VeiculozFachada.Instancia.ExcluirTipoDespesa(id);
        }

    }
}