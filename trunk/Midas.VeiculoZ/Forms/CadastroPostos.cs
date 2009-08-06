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
using Midas.Nucleo.Validador;
using Midas.VeiculoZ.Validador;
using System.Collections;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{

    public partial class CadastroPostos : CRUDFormVeiculoZ
    {

        public CadastroPostos()
        {
            this.Validador = new PostoValidador();
            InitializeComponent();

            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddCidade);
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddDistrib);

            IList dists = VeiculozFachada.Instancia.ListarDistribuidoras();
            if (dists != null && dists.Count > 0)
            {
                this.cmbDistribuidora.DataSource = dists;
                this.cmbDistribuidora.ValueMember = "Id";
                this.cmbDistribuidora.DisplayMember = "Nome";
            }

            IList cidades = Nucleo.NucleoFachada.Instancia.ListarCidades();
            if (cidades != null && cidades.Count > 0)
            {
                this.cmbCidade.ValueMember = "Id";
                this.cmbCidade.DisplayMember = "Nome";
                this.cmbCidade.DataSource = cidades;
            }
        }

        public override void  Limpar()
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
            this.tPJId.Text = "";
            this.tNome.Text = "";
            this.tObs.Text = "";

        }

        public override void DoExcluir(long id)
        {
            VeiculozFachada.Instancia.ExcluirPosto(id);
        }

        public override void DoSalvar(ObjetoNegocio objeto)
        {
            Posto posto = (Posto)objeto;
            VeiculozFachada.Instancia.SalvarPosto(posto);
            this.tId.Text = posto.Id.ToString();
            this.tPJId.Text = posto.PessoaJuridica.Id.ToString();
            this.tEnderecoId.Text = posto.Endereco.Id.ToString();
        }

        public override ObjetoNegocio ConstruirObjeto()
        {
            Posto posto = new Posto();
            if (this.tId.Text != "")
            {
                posto.Id = Int32.Parse(this.tId.Text);
            }
            PessoaJuridica pj = new PessoaJuridica();
            if (this.tPJId.Text != "")
            {
                pj.Id = Int32.Parse(this.tPJId.Text);
            }
            pj.CNPJ = this.tCNPJ.Text;
            pj.NomeFantasia = tNome.Text;
            posto.PessoaJuridica = pj;
            posto.Observacoes = this.tObs.Text;
            posto.Distribuidora = (Distribuidora)this.cmbDistribuidora.SelectedItem;
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
            posto.Endereco = endereco;

            return posto;
        }

        public override void TratarDados()
        {
            Posto posto = (Posto)GerenciadorDados.Instancia.Get();
            if (posto != null)
            {
                this.tId.Text = posto.Id.ToString();
                // Endereço
                this.tEnderecoId.Text = posto.Endereco.Id.ToString();
                this.tBairro.Text = posto.Endereco.Bairro;
                this.tCEP.Text = posto.Endereco.CodigoPostal;
                this.tRua.Text = posto.Endereco.Logradouro;
                this.tNumero.Text = posto.Endereco.Numero;
                this.tComplemento.Text = posto.Endereco.Complemento;
                if ( posto.Endereco.Cidade != null ) 
                {
                    this.cmbCidade.SelectedValue = posto.Endereco.Cidade.Id;
                }
                this.cmbDistribuidora.SelectedValue = posto.Distribuidora.Id;
                // Empresa.
                this.tCNPJ.Text = posto.PessoaJuridica.CNPJ;
                this.tPJId.Text = posto.PessoaJuridica.Id.ToString();
                // Posto.
                this.tNome.Text = posto.PessoaJuridica.NomeFantasia;
                this.tObs.Text = posto.Observacoes;
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
            IList dists = VeiculozFachada.Instancia.ListarDistribuidoras();
            if (dists != null && dists.Count > 0)
            {
                this.cmbDistribuidora.DataSource = dists;
                this.cmbDistribuidora.ValueMember = "Id";
                this.cmbDistribuidora.DisplayMember = "Nome";
            }

            IList cidades = Nucleo.NucleoFachada.Instancia.ListarCidades();
            if (cidades != null && cidades.Count > 0)
            {
                this.cmbCidade.ValueMember = "Id";
                this.cmbCidade.DisplayMember = "Nome";
                this.cmbCidade.DataSource = cidades;
            }
        }

        private void pAddDistrib_Click_1(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroDistribuidoras));
        }

        private void pAddCidade_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroCidade));
        }

    }

}