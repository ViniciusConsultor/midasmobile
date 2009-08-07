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
    public partial class BuscaInfracoes : StackForm
    {
        private System.EventHandler evento;

        private CadastroMulta formCadastroMulta;
        public CadastroMulta FormCadastroMulta
        {
            get { return formCadastroMulta; }
            set { formCadastroMulta = value; }
        }

        public BuscaInfracoes()
        {
            InitializeComponent();
            evento = new System.EventHandler(this.cmbClass_SelectedValueChanged);
            cmbClass.DataSource = VeiculozFachada.Instancia.ListarClassificacoesInfracao();
            cmbClass.ValueMember = "Id";
            cmbClass.DisplayMember = "Descricao";
            this.ListarInfracoes();
            this.cmbClass.SelectedValueChanged += evento;
        }

        private void cmbClass_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ListarInfracoes();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Infracao comb = (Infracao)infracoes.SelectedItem;
            Infracao infracao = VeiculozFachada.Instancia.ObterInfracao(comb.Id);
            formCadastroMulta = (CadastroMulta)GerenciadorDados.Instancia.FormularioAnterior;
            formCadastroMulta.tIdInfracao.Text = infracao.Id.ToString();
            formCadastroMulta.tInfracao.Text = infracao.Descricao;
            formCadastroMulta.tInfrator.Text = infracao.Infrator;
            formCadastroMulta.tClassificacao.Text = infracao.Classificacao.Descricao;
            formCadastroMulta.tPontos.Text = infracao.Classificacao.Pontos.ToString();
            formCadastroMulta.tValor.Text = "R$ " + infracao.Valor.ToString("N2").Replace('.',',');
            formCadastroMulta.tArtigo.Text = infracao.Artigo;
            Program.FormStack.PopNoClear(1);
        }

        private void ListarInfracoes()
        {
            ClassificacaoInfracao ci = (ClassificacaoInfracao)cmbClass.SelectedItem;
            if (ci != null)
            {
                IList lista = VeiculozFachada.Instancia.ListarInfracoesPorClassificacaoDescricao(ci.Id, "");
                if (lista.Count > 0)
                {
                    infracoes.DataSource = lista;
                    infracoes.DisplayMember = "Descricao";
                    infracoes.ValueMember = "Id";
                }
            }
        }

        private void infracoes_SelectedValueChanged(object sender, EventArgs e)
        {
            Infracao infracao = (Infracao)infracoes.SelectedItem;
            tDescricao.Text = infracao.Descricao;
        }

    }

}