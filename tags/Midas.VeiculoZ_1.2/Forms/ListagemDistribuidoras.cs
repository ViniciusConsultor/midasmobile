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
using System.Collections;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Form;

namespace Midas.VeiculoZ.Forms
{
    public partial class ListagemDistribuidoras : ListFormVeiculoZ
    {
        private IList lista;

        public ListagemDistribuidoras()
        {
            InitializeComponent();
        }

        public override void TratarDados()
        {
            lista = VeiculozFachada.Instancia.ListarDistribuidoras();
            this.dataGrid.DataSource = lista;
            this.dataGridTableStyle1.MappingName = dataGrid.DataSource.GetType().Name;
        }

        public override void pNovo_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(CadastroDistribuidoras));
        }

        public override void pVoltar_Click(object sender, EventArgs e)
        {
            Program.FormStack.Pop(1);
        }

        public override void pExcluir_Click(object sender, EventArgs e)
        {
            base.Excluir(this.dataGrid, this.lista);
        }

        public override void DoExcluir(long id)
        {
            VeiculozFachada.Instancia.ExcluirDistribuidora(id);
            this.TratarDados();
        }

        public override void pEditar_Click(object sender, EventArgs e)
        {
            Distribuidora distribuidora = (Distribuidora)lista[this.dataGrid.CurrentRowIndex];
            GerenciadorDados.Instancia.Set(distribuidora);
            Program.FormStack.Push(typeof(CadastroDistribuidoras));
        }

    }

}