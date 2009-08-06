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
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{
    public partial class CadastroManutencao : CRUDFormVeiculoZ
    {
        public CadastroManutencao()
        {
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddVeiculo);
            this.Validador = new ManutencaoValidador();
            this.CriarCombos();
        }

        public override void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);
        }

        private void CriarCombos()
        {
            cmbVeiculos.DataSource = Negocio.NegocioFactory.Instancia.VeiculoNegocio.Listar();
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";
        }

        public override void Limpar()
        {
            tId.Text = "";
            tDescricao.Text = "";
            tKm.Text = "";
        }

        public override void pSalvar_Click(object sender, EventArgs e)
        {
            base.Salvar();
        }

        public override void pExcluir_Click(object sender, EventArgs e)
        {
            base.Excluir(tId.Text);
        }

        private void pAddVeiculo_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroVeiculos));
        }

        public override void DoSalvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Manutencao m = (Manutencao)objeto;
            VeiculozFachada.Instancia.SalvarManutencao(m);
            tId.Text = m.Id.ToString();
        }

        public override void DoExcluir(long id)
        {
            VeiculozFachada.Instancia.ExcluirManutencao(id);
        }

        public override void TratarDados()
        {
            Manutencao m = (Manutencao)GerenciadorDados.Instancia.Get();
            if (m != null)
            {
                tId.Text = m.Id.ToString();
                tDescricao.Text = m.Descricao;
                data.Value = m.Data;
                cmbVeiculos.SelectedValue = m.Veiculo.Id;
                tKm.Text = m.Km.ToString();
                chkKm.Checked = m.LembrarPorData;
                chkVerificado.Checked = m.Verificado;
            }
        }

        public override Midas.Nucleo.Objetos.ObjetoNegocio ConstruirObjeto()
        {
            Manutencao m = new Manutencao();
            if (tId.Text != "")
            {
                m.Id = Int32.Parse(tId.Text);
            }
            m.Data = new DateTime(this.data.Value.Year, this.data.Value.Month, this.data.Value.Day);
            m.Descricao = tDescricao.Text;
            m.LembrarPorData = chkKm.Checked;
            m.Verificado = chkVerificado.Checked;
            if (tKm.Text != "" )
            {
                try
                {
                    m.Km = Int32.Parse(tKm.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Informe um número válido no campo Km.");
                }
            }
            m.Veiculo = (Veiculo)cmbVeiculos.SelectedItem;
            return m;
        }

        public override void Lembrar()
        {
            this.CriarCombos();
        }

        private void chkKm_CheckStateChanged(object sender, EventArgs e)
        {
        }
    }

}