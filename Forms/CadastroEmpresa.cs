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
using Midas.Nucleo.Objetos;
using Midas.Nucleo.Validador;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{
    public partial class CadastroEmpresa : CRUDFormVeiculoZ
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddCidade);
            this.Validador = new PessoaJuridicaValidador();
            this.CriarCombos();
        }

        private void pAddCidade_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroCidade));
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
            this.CriarCombos();
        }

        private void CriarCombos()
        {
            this.cmbCidade.ValueMember = "Id";
            this.cmbCidade.DisplayMember = "Nome";
            this.cmbCidade.DataSource = Nucleo.NucleoFachada.Instancia.ListarCidades();
        }

        public override void TratarDados()
        {
            PessoaJuridica pj = (PessoaJuridica)GerenciadorDados.Instancia.Get();
            if (pj != null)
            {
                tId.Text = pj.Id.ToString();
                tNome.Text = pj.NomeFantasia;
                this.tCNPJ.Text = pj.CNPJ;
                // Endereço
                this.tEnderecoId.Text = pj.Endereco.Id.ToString();
                this.tBairro.Text = pj.Endereco.Bairro;
                this.tCEP.Text = pj.Endereco.CodigoPostal;
                this.tRua.Text = pj.Endereco.Logradouro;
                this.tNumero.Text = pj.Endereco.Numero;
                this.tComplemento.Text = pj.Endereco.Complemento;
                if (pj.Endereco.Cidade != null)
                {
                    this.cmbCidade.SelectedValue = pj.Endereco.Cidade.Id;
                }
            }
        }

        public override void Limpar()
        {
            this.tId.Text = "";
            this.tEnderecoId.Text = "";
            this.tBairro.Text = "";
            this.tCEP.Text = "";
            this.tRua.Text = "";
            this.tNumero.Text = "";
            this.tComplemento.Text = "";
            this.cmbCidade.SelectedItem = new Cidade();
            this.tCNPJ.Text = "";
            this.tNome.Text = "";
            this.tObs.Text = "";
        }

        public override void DoExcluir(long id)
        {
            Nucleo.NucleoFachada.Instancia.ExcluirPessoaJuridica(id);
        }

        public override void DoSalvar(ObjetoNegocio objeto)
        {
            PessoaJuridica pj = (PessoaJuridica)objeto;
            Nucleo.NucleoFachada.Instancia.SalvarPessoaJuridica(pj);
            this.tId.Text = pj.Id.ToString();
            this.tEnderecoId.Text = pj.Endereco.Id.ToString();
        }

        public override ObjetoNegocio ConstruirObjeto()
        {
            PessoaJuridica pj = new PessoaJuridica();
            if (this.tId.Text != "")
            {
                pj.Id = Int32.Parse(this.tId.Text);
            }
            pj.CNPJ = this.tCNPJ.Text;
            pj.NomeFantasia = tNome.Text;
            Endereco endereco = new Endereco();
            if (this.tEnderecoId.Text != "")
            {
                endereco.Id = Int32.Parse(this.tEnderecoId.Text);
            }
            endereco.Bairro = this.tBairro.Text;
            endereco.Logradouro = this.tRua.Text;
            endereco.Complemento = this.tComplemento.Text;
            endereco.CodigoPostal = this.tCEP.Text;
            endereco.Numero = this.tNumero.Text;
            if (cmbCidade.SelectedItem != null)
            {
                endereco.Cidade = (Cidade)cmbCidade.SelectedItem;
            }
            else
            {
                endereco.Cidade = null;
            }
            endereco.CodigoPostal = tCEP.Text;
            pj.Endereco = endereco;

            return pj;
        }

    }

}