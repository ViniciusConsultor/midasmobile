namespace Midas.VeiculoZ.Forms
{
    partial class CadastroMulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMulta));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePercurso = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSituacaoMulta = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vencimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tLocal = new System.Windows.Forms.TextBox();
            this.pAddVeiculo = new System.Windows.Forms.PictureBox();
            this.tIdAbastecimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tabPageAbastecimento = new System.Windows.Forms.TabPage();
            this.tClassificacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tPontos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tInfrator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tArtigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.tInfracao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageObs = new System.Windows.Forms.TabPage();
            this.tObs = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tIdInfracao = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPagePercurso.SuspendLayout();
            this.tabPageAbastecimento.SuspendLayout();
            this.tabPageObs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePercurso);
            this.tabControl.Controls.Add(this.tabPageAbastecimento);
            this.tabControl.Controls.Add(this.tabPageObs);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControl.Location = new System.Drawing.Point(0, 200);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(480, 336);
            this.tabControl.TabIndex = 98;
            // 
            // tabPagePercurso
            // 
            this.tabPagePercurso.Controls.Add(this.label12);
            this.tabPagePercurso.Controls.Add(this.cmbSituacaoMulta);
            this.tabPagePercurso.Controls.Add(this.label11);
            this.tabPagePercurso.Controls.Add(this.vencimento);
            this.tabPagePercurso.Controls.Add(this.label4);
            this.tabPagePercurso.Controls.Add(this.data);
            this.tabPagePercurso.Controls.Add(this.label3);
            this.tabPagePercurso.Controls.Add(this.tLocal);
            this.tabPagePercurso.Controls.Add(this.pAddVeiculo);
            this.tabPagePercurso.Controls.Add(this.tIdAbastecimento);
            this.tabPagePercurso.Controls.Add(this.label10);
            this.tabPagePercurso.Controls.Add(this.cmbVeiculos);
            this.tabPagePercurso.Controls.Add(this.label7);
            this.tabPagePercurso.Controls.Add(this.tId);
            this.tabPagePercurso.Location = new System.Drawing.Point(0, 0);
            this.tabPagePercurso.Name = "tabPagePercurso";
            this.tabPagePercurso.Size = new System.Drawing.Size(480, 292);
            this.tabPagePercurso.Text = "Multa";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(25, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 31);
            this.label12.Text = "Situação:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbSituacaoMulta
            // 
            this.cmbSituacaoMulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSituacaoMulta.DisplayMember = "Modelo";
            this.cmbSituacaoMulta.Location = new System.Drawing.Point(157, 237);
            this.cmbSituacaoMulta.Name = "cmbSituacaoMulta";
            this.cmbSituacaoMulta.Size = new System.Drawing.Size(248, 41);
            this.cmbSituacaoMulta.TabIndex = 146;
            this.cmbSituacaoMulta.ValueMember = "Id";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(45, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 26);
            this.label11.Text = "Venc.:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vencimento
            // 
            this.vencimento.CustomFormat = "dd/MM/yyyy";
            this.vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vencimento.Location = new System.Drawing.Point(157, 195);
            this.vencimento.Name = "vencimento";
            this.vencimento.Size = new System.Drawing.Size(248, 36);
            this.vencimento.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(60, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.Text = "Data:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // data
            // 
            this.data.CustomFormat = "dd/MM/yyyy";
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data.Location = new System.Drawing.Point(157, 153);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(248, 36);
            this.data.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(81, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.Text = "Local:";
            // 
            // tLocal
            // 
            this.tLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tLocal.Location = new System.Drawing.Point(157, 106);
            this.tLocal.Name = "tLocal";
            this.tLocal.Size = new System.Drawing.Size(248, 41);
            this.tLocal.TabIndex = 136;
            // 
            // pAddVeiculo
            // 
            this.pAddVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("pAddVeiculo.Image")));
            this.pAddVeiculo.Location = new System.Drawing.Point(411, 61);
            this.pAddVeiculo.Name = "pAddVeiculo";
            this.pAddVeiculo.Size = new System.Drawing.Size(36, 38);
            this.pAddVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddVeiculo.Click += new System.EventHandler(this.pAddVeiculo_Click_1);
            // 
            // tIdAbastecimento
            // 
            this.tIdAbastecimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tIdAbastecimento.Location = new System.Drawing.Point(293, 12);
            this.tIdAbastecimento.Name = "tIdAbastecimento";
            this.tIdAbastecimento.ReadOnly = true;
            this.tIdAbastecimento.Size = new System.Drawing.Size(124, 41);
            this.tIdAbastecimento.TabIndex = 110;
            this.tIdAbastecimento.Visible = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(42, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 31);
            this.label10.Text = "Veículo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbVeiculos.DisplayMember = "Modelo";
            this.cmbVeiculos.Location = new System.Drawing.Point(157, 59);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(248, 41);
            this.cmbVeiculos.TabIndex = 4;
            this.cmbVeiculos.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(113, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 30);
            this.label7.Text = "Id:";
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tId.Location = new System.Drawing.Point(157, 12);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(124, 41);
            this.tId.TabIndex = 1;
            // 
            // tabPageAbastecimento
            // 
            this.tabPageAbastecimento.Controls.Add(this.tClassificacao);
            this.tabPageAbastecimento.Controls.Add(this.label9);
            this.tabPageAbastecimento.Controls.Add(this.tPontos);
            this.tabPageAbastecimento.Controls.Add(this.label6);
            this.tabPageAbastecimento.Controls.Add(this.tValor);
            this.tabPageAbastecimento.Controls.Add(this.label5);
            this.tabPageAbastecimento.Controls.Add(this.tInfrator);
            this.tabPageAbastecimento.Controls.Add(this.label2);
            this.tabPageAbastecimento.Controls.Add(this.tArtigo);
            this.tabPageAbastecimento.Controls.Add(this.label1);
            this.tabPageAbastecimento.Controls.Add(this.btnSelecionar);
            this.tabPageAbastecimento.Controls.Add(this.tInfracao);
            this.tabPageAbastecimento.Controls.Add(this.label8);
            this.tabPageAbastecimento.Location = new System.Drawing.Point(0, 0);
            this.tabPageAbastecimento.Name = "tabPageAbastecimento";
            this.tabPageAbastecimento.Size = new System.Drawing.Size(480, 292);
            this.tabPageAbastecimento.Text = "Infração";
            // 
            // tClassificacao
            // 
            this.tClassificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tClassificacao.Location = new System.Drawing.Point(126, 52);
            this.tClassificacao.Name = "tClassificacao";
            this.tClassificacao.ReadOnly = true;
            this.tClassificacao.Size = new System.Drawing.Size(337, 41);
            this.tClassificacao.TabIndex = 1018;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 30);
            this.label9.Text = "Classific.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tPontos
            // 
            this.tPontos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tPontos.Location = new System.Drawing.Point(126, 238);
            this.tPontos.Name = "tPontos";
            this.tPontos.ReadOnly = true;
            this.tPontos.Size = new System.Drawing.Size(88, 41);
            this.tPontos.TabIndex = 1015;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 30);
            this.label6.Text = "Pontos:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tValor
            // 
            this.tValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tValor.Location = new System.Drawing.Point(126, 191);
            this.tValor.Name = "tValor";
            this.tValor.ReadOnly = true;
            this.tValor.Size = new System.Drawing.Size(161, 41);
            this.tValor.TabIndex = 1012;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 30);
            this.label5.Text = "Valor:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tInfrator
            // 
            this.tInfrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tInfrator.Location = new System.Drawing.Point(126, 144);
            this.tInfrator.Name = "tInfrator";
            this.tInfrator.ReadOnly = true;
            this.tInfrator.Size = new System.Drawing.Size(252, 41);
            this.tInfrator.TabIndex = 1009;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.Text = "Infrator:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tArtigo
            // 
            this.tArtigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tArtigo.Location = new System.Drawing.Point(126, 98);
            this.tArtigo.Name = "tArtigo";
            this.tArtigo.ReadOnly = true;
            this.tArtigo.Size = new System.Drawing.Size(252, 41);
            this.tArtigo.TabIndex = 1007;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.Text = "Artigo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelecionar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnSelecionar.Location = new System.Drawing.Point(387, 6);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(76, 41);
            this.btnSelecionar.TabIndex = 1004;
            this.btnSelecionar.Text = "Buscar";
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // tInfracao
            // 
            this.tInfracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tInfracao.Location = new System.Drawing.Point(126, 6);
            this.tInfracao.Name = "tInfracao";
            this.tInfracao.ReadOnly = true;
            this.tInfracao.Size = new System.Drawing.Size(252, 41);
            this.tInfracao.TabIndex = 1002;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 30);
            this.label8.Text = "Infração:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPageObs
            // 
            this.tabPageObs.Controls.Add(this.tObs);
            this.tabPageObs.Location = new System.Drawing.Point(0, 0);
            this.tabPageObs.Name = "tabPageObs";
            this.tabPageObs.Size = new System.Drawing.Size(472, 298);
            this.tabPageObs.Text = "Observações";
            // 
            // tObs
            // 
            this.tObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tObs.Location = new System.Drawing.Point(0, 0);
            this.tObs.MaxLength = 500;
            this.tObs.Multiline = true;
            this.tObs.Name = "tObs";
            this.tObs.Size = new System.Drawing.Size(472, 298);
            this.tObs.TabIndex = 0;
            // 
            // lTitulo
            // 
            this.lTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lTitulo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(8, 80);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(446, 28);
            this.lTitulo.Text = "Cadastro de Multa";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // tIdInfracao
            // 
            this.tIdInfracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tIdInfracao.Location = new System.Drawing.Point(367, 134);
            this.tIdInfracao.Name = "tIdInfracao";
            this.tIdInfracao.ReadOnly = true;
            this.tIdInfracao.Size = new System.Drawing.Size(96, 41);
            this.tIdInfracao.TabIndex = 1005;
            this.tIdInfracao.Visible = false;
            // 
            // CadastroMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.tIdInfracao);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "CadastroMulta";
            this.tabControl.ResumeLayout(false);
            this.tabPagePercurso.ResumeLayout(false);
            this.tabPageAbastecimento.ResumeLayout(false);
            this.tabPageObs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePercurso;
        private System.Windows.Forms.PictureBox pAddVeiculo;
        private System.Windows.Forms.TextBox tIdAbastecimento;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TabPage tabPageAbastecimento;
        public System.Windows.Forms.TextBox tInfracao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageObs;
        private System.Windows.Forms.TextBox tObs;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tLocal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker vencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSituacaoMulta;
        private System.Windows.Forms.Button btnSelecionar;
        public System.Windows.Forms.TextBox tIdInfracao;
        public System.Windows.Forms.TextBox tArtigo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tClassificacao;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tPontos;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tValor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tInfrator;
        private System.Windows.Forms.Label label2;

    }
}