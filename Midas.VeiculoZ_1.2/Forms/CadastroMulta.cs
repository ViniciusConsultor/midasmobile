using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Midas.VeiculoZ.Validador;
using Midas.VeiculoZ.Resolucao;
using Midas.VeiculoZ.Objetos;
using System.Collections;
using Midas.Nucleo.Objetos;
using Midas.Nucleo.Form;

namespace Midas.VeiculoZ.Forms
{
    public partial class CadastroMulta : CRUDFormVeiculoZ
    {
        public CadastroMulta()
        {
            this.Validador = new MultaValidador();
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("IconeAdicionar", pAddVeiculo);

            cmbVeiculos.DataSource = VeiculozFachada.Instancia.ListarVeiculos();
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";

            cmbSituacaoMulta.DataSource= VeiculozFachada.Instancia.ListarSituacoesMulta();
            cmbSituacaoMulta.DisplayMember = "Nome";
            cmbSituacaoMulta.ValueMember = "Id";
        }

        public override void DoSalvar(ObjetoNegocio objeto)
        {
            Multa multa = (Multa)objeto;
            VeiculozFachada.Instancia.SalvarMulta(multa);
            tId.Text = objeto.Id.ToString();
        }

        public override void DoExcluir(long id)
        {
            VeiculozFachada.Instancia.ExcluirMulta(id);
        }

        public override ObjetoNegocio ConstruirObjeto()
        {
            Multa multa = new Multa();
            Infracao infracao = new Infracao();
            multa.Infracao = infracao;
            multa.Local = tLocal.Text;
            multa.Observacoes = tObs.Text;
            multa.Situacao = (SituacaoMulta)cmbSituacaoMulta.SelectedItem;
            multa.Veiculo = (Veiculo)cmbVeiculos.SelectedItem;
            multa.Data = new DateTime(this.data.Value.Year, this.data.Value.Month, this.data.Value.Day);
            multa.DataVencimento = new DateTime(this.vencimento.Value.Year, this.vencimento.Value.Month, this.vencimento.Value.Day);
            if (tIdInfracao.Text != "")
            {
                multa.Infracao.Id = Int32.Parse(tIdInfracao.Text);
            }
            if (tId.Text != "")
            {
                multa.Id = Int32.Parse(tId.Text);
            }
            return multa;
        }

        public override void  Limpar()
        {
            tId.Text = "";
            tLocal.Text = "";
            tValor.Text = "";
            tInfracao.Text = "";
            tIdInfracao.Text = "";
            tClassificacao.Text = "";
            tPontos.Text = "";
            tArtigo.Text = "";
            tInfrator.Text = "";
        }

        public override void TratarDados()
        {
            Multa multa = (Multa)GerenciadorDados.Instancia.Get();
            if (multa != null)
            {
                tId.Text = multa.Id.ToString();
                tLocal.Text = multa.Local;
                tObs.Text = multa.Observacoes;
                tClassificacao.Text = multa.Infracao.Classificacao.Descricao;
                tPontos.Text = multa.Infracao.Classificacao.Pontos.ToString();
                tInfrator.Text = multa.Infracao.Infrator;
                tInfracao.Text = multa.Infracao.Descricao;
                tArtigo.Text = multa.Infracao.Artigo;
                tValor.Text = multa.Infracao.Valor.ToString();
                data.Value = multa.Data;
                tIdInfracao.Text = multa.Infracao.Id.ToString();
                vencimento.Value = multa.DataVencimento;
                cmbSituacaoMulta.SelectedValue = multa.Situacao.Id;
                cmbVeiculos.SelectedValue = multa.Veiculo.Id;
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

            cmbSituacaoMulta.DataSource = VeiculozFachada.Instancia.ListarSituacoesMulta();
            cmbSituacaoMulta.DisplayMember = "Nome";
            cmbSituacaoMulta.ValueMember = "Id";
        }

        private void pAddVeiculo_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroVeiculos));
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.FormularioAnterior = this;
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(BuscaInfracoes));
        }

        private void pAddVeiculo_Click_1(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroVeiculos));
        }

    }

}