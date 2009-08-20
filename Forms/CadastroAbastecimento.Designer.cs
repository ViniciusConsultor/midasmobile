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
namespace Midas.VeiculoZ.Forms
{
    partial class CadastroAbastecimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAbastecimento));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePercurso = new System.Windows.Forms.TabPage();
            this.tKmFinal = new System.Windows.Forms.TextBox();
            this.pCalcKM = new System.Windows.Forms.PictureBox();
            this.tKmInicial = new System.Windows.Forms.TextBox();
            this.pAddVeiculo = new System.Windows.Forms.PictureBox();
            this.tIdAbastecimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.chkViagem = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tabPageAbastecimento = new System.Windows.Forms.TabPage();
            this.pCalcPrecoTotal = new System.Windows.Forms.PictureBox();
            this.pCalcPrecoLitro = new System.Windows.Forms.PictureBox();
            this.tLitros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tValorLitro = new System.Windows.Forms.TextBox();
            this.hora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.chkTanqueCheio = new System.Windows.Forms.CheckBox();
            this.pAddTipo = new System.Windows.Forms.PictureBox();
            this.cmbTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tValor = new System.Windows.Forms.TextBox();
            this.pAddPosto = new System.Windows.Forms.PictureBox();
            this.cmbPosto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageObs = new System.Windows.Forms.TabPage();
            this.tObs = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.tabControl.TabIndex = 95;
            // 
            // tabPagePercurso
            // 
            this.tabPagePercurso.Controls.Add(this.tKmFinal);
            this.tabPagePercurso.Controls.Add(this.pCalcKM);
            this.tabPagePercurso.Controls.Add(this.tKmInicial);
            this.tabPagePercurso.Controls.Add(this.pAddVeiculo);
            this.tabPagePercurso.Controls.Add(this.tIdAbastecimento);
            this.tabPagePercurso.Controls.Add(this.label10);
            this.tabPagePercurso.Controls.Add(this.cmbVeiculos);
            this.tabPagePercurso.Controls.Add(this.chkViagem);
            this.tabPagePercurso.Controls.Add(this.label7);
            this.tabPagePercurso.Controls.Add(this.label4);
            this.tabPagePercurso.Controls.Add(this.label3);
            this.tabPagePercurso.Controls.Add(this.tId);
            this.tabPagePercurso.Location = new System.Drawing.Point(0, 0);
            this.tabPagePercurso.Name = "tabPagePercurso";
            this.tabPagePercurso.Size = new System.Drawing.Size(480, 292);
            this.tabPagePercurso.Text = "Percurso";
            // 
            // tKmFinal
            // 
            this.tKmFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tKmFinal.Location = new System.Drawing.Point(166, 122);
            this.tKmFinal.Name = "tKmFinal";
            this.tKmFinal.ReadOnly = true;
            this.tKmFinal.Size = new System.Drawing.Size(124, 41);
            this.tKmFinal.TabIndex = 130;
            // 
            // pCalcKM
            // 
            this.pCalcKM.Image = ((System.Drawing.Image)(resources.GetObject("pCalcKM.Image")));
            this.pCalcKM.Location = new System.Drawing.Point(296, 79);
            this.pCalcKM.Name = "pCalcKM";
            this.pCalcKM.Size = new System.Drawing.Size(22, 30);
            this.pCalcKM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCalcKM.Click += new System.EventHandler(this.pCalcKM_Click);
            // 
            // tKmInicial
            // 
            this.tKmInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tKmInicial.Location = new System.Drawing.Point(166, 73);
            this.tKmInicial.Name = "tKmInicial";
            this.tKmInicial.Size = new System.Drawing.Size(124, 41);
            this.tKmInicial.TabIndex = 127;
            // 
            // pAddVeiculo
            // 
            this.pAddVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("pAddVeiculo.Image")));
            this.pAddVeiculo.Location = new System.Drawing.Point(420, 174);
            this.pAddVeiculo.Name = "pAddVeiculo";
            this.pAddVeiculo.Size = new System.Drawing.Size(36, 38);
            this.pAddVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddVeiculo.Click += new System.EventHandler(this.pAddVeiculo_Click);
            // 
            // tIdAbastecimento
            // 
            this.tIdAbastecimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tIdAbastecimento.Location = new System.Drawing.Point(302, 24);
            this.tIdAbastecimento.Name = "tIdAbastecimento";
            this.tIdAbastecimento.ReadOnly = true;
            this.tIdAbastecimento.Size = new System.Drawing.Size(124, 41);
            this.tIdAbastecimento.TabIndex = 110;
            this.tIdAbastecimento.Visible = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(50, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 42);
            this.label10.Text = "Veículo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbVeiculos.DisplayMember = "Modelo";
            this.cmbVeiculos.Location = new System.Drawing.Point(166, 172);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(248, 41);
            this.cmbVeiculos.TabIndex = 4;
            this.cmbVeiculos.ValueMember = "Id";
            // 
            // chkViagem
            // 
            this.chkViagem.Location = new System.Drawing.Point(162, 220);
            this.chkViagem.Name = "chkViagem";
            this.chkViagem.Size = new System.Drawing.Size(178, 44);
            this.chkViagem.TabIndex = 5;
            this.chkViagem.Text = "Viagem?";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(122, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 40);
            this.label7.Text = "Id:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(44, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 42);
            this.label4.Text = "KM Final:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 40);
            this.label3.Text = "KM Inicial:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tId.Location = new System.Drawing.Point(166, 24);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(124, 41);
            this.tId.TabIndex = 1;
            // 
            // tabPageAbastecimento
            // 
            this.tabPageAbastecimento.Controls.Add(this.pCalcPrecoTotal);
            this.tabPageAbastecimento.Controls.Add(this.pCalcPrecoLitro);
            this.tabPageAbastecimento.Controls.Add(this.tLitros);
            this.tabPageAbastecimento.Controls.Add(this.label8);
            this.tabPageAbastecimento.Controls.Add(this.tValorLitro);
            this.tabPageAbastecimento.Controls.Add(this.hora);
            this.tabPageAbastecimento.Controls.Add(this.label5);
            this.tabPageAbastecimento.Controls.Add(this.data);
            this.tabPageAbastecimento.Controls.Add(this.chkTanqueCheio);
            this.tabPageAbastecimento.Controls.Add(this.pAddTipo);
            this.tabPageAbastecimento.Controls.Add(this.cmbTipoCombustivel);
            this.tabPageAbastecimento.Controls.Add(this.label1);
            this.tabPageAbastecimento.Controls.Add(this.label9);
            this.tabPageAbastecimento.Controls.Add(this.tValor);
            this.tabPageAbastecimento.Controls.Add(this.pAddPosto);
            this.tabPageAbastecimento.Controls.Add(this.cmbPosto);
            this.tabPageAbastecimento.Controls.Add(this.label6);
            this.tabPageAbastecimento.Controls.Add(this.label2);
            this.tabPageAbastecimento.Location = new System.Drawing.Point(0, 0);
            this.tabPageAbastecimento.Name = "tabPageAbastecimento";
            this.tabPageAbastecimento.Size = new System.Drawing.Size(472, 298);
            this.tabPageAbastecimento.Text = "Abastecimento";
            // 
            // pCalcPrecoTotal
            // 
            this.pCalcPrecoTotal.Image = ((System.Drawing.Image)(resources.GetObject("pCalcPrecoTotal.Image")));
            this.pCalcPrecoTotal.Location = new System.Drawing.Point(410, 178);
            this.pCalcPrecoTotal.Name = "pCalcPrecoTotal";
            this.pCalcPrecoTotal.Size = new System.Drawing.Size(22, 30);
            this.pCalcPrecoTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCalcPrecoTotal.Click += new System.EventHandler(this.pCalcPrecoTotal_Click);
            // 
            // pCalcPrecoLitro
            // 
            this.pCalcPrecoLitro.Image = ((System.Drawing.Image)(resources.GetObject("pCalcPrecoLitro.Image")));
            this.pCalcPrecoLitro.Location = new System.Drawing.Point(206, 178);
            this.pCalcPrecoLitro.Name = "pCalcPrecoLitro";
            this.pCalcPrecoLitro.Size = new System.Drawing.Size(22, 30);
            this.pCalcPrecoLitro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCalcPrecoLitro.Click += new System.EventHandler(this.pCalcPrecoLitro_Click);
            // 
            // tLitros
            // 
            this.tLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tLitros.Location = new System.Drawing.Point(116, 220);
            this.tLitros.Name = "tLitros";
            this.tLitros.ReadOnly = true;
            this.tLitros.Size = new System.Drawing.Size(86, 41);
            this.tLitros.TabIndex = 1002;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 30);
            this.label8.Text = "Litros:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tValorLitro
            // 
            this.tValorLitro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tValorLitro.Location = new System.Drawing.Point(116, 172);
            this.tValorLitro.Name = "tValorLitro";
            this.tValorLitro.Size = new System.Drawing.Size(86, 41);
            this.tValorLitro.TabIndex = 10;
            this.tValorLitro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tValorLitro_KeyUp);
            // 
            // hora
            // 
            this.hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hora.Location = new System.Drawing.Point(282, 20);
            this.hora.Name = "hora";
            this.hora.ShowUpDown = true;
            this.hora.Size = new System.Drawing.Size(162, 36);
            this.hora.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.Text = "Data:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // data
            // 
            this.data.CustomFormat = "dd/MM/yyyy";
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data.Location = new System.Drawing.Point(116, 20);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(162, 36);
            this.data.TabIndex = 6;
            // 
            // chkTanqueCheio
            // 
            this.chkTanqueCheio.Location = new System.Drawing.Point(242, 224);
            this.chkTanqueCheio.Name = "chkTanqueCheio";
            this.chkTanqueCheio.Size = new System.Drawing.Size(218, 38);
            this.chkTanqueCheio.TabIndex = 127;
            this.chkTanqueCheio.Text = "Tanque Cheio?";
            // 
            // pAddTipo
            // 
            this.pAddTipo.Image = ((System.Drawing.Image)(resources.GetObject("pAddTipo.Image")));
            this.pAddTipo.Location = new System.Drawing.Point(410, 124);
            this.pAddTipo.Name = "pAddTipo";
            this.pAddTipo.Size = new System.Drawing.Size(36, 38);
            this.pAddTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddTipo.Click += new System.EventHandler(this.pAddTipo_Click);
            // 
            // cmbTipoCombustivel
            // 
            this.cmbTipoCombustivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbTipoCombustivel.DisplayMember = "Nome";
            this.cmbTipoCombustivel.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoCombustivel.Location = new System.Drawing.Point(116, 122);
            this.cmbTipoCombustivel.Name = "cmbTipoCombustivel";
            this.cmbTipoCombustivel.Size = new System.Drawing.Size(290, 41);
            this.cmbTipoCombustivel.TabIndex = 9;
            this.cmbTipoCombustivel.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.Text = "Tipo C.:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(240, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 30);
            this.label9.Text = "Total:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tValor
            // 
            this.tValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tValor.Location = new System.Drawing.Point(312, 172);
            this.tValor.Name = "tValor";
            this.tValor.Size = new System.Drawing.Size(92, 41);
            this.tValor.TabIndex = 11;
            this.tValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tValor_KeyUp);
            // 
            // pAddPosto
            // 
            this.pAddPosto.Image = ((System.Drawing.Image)(resources.GetObject("pAddPosto.Image")));
            this.pAddPosto.Location = new System.Drawing.Point(410, 74);
            this.pAddPosto.Name = "pAddPosto";
            this.pAddPosto.Size = new System.Drawing.Size(36, 38);
            this.pAddPosto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddPosto.Click += new System.EventHandler(this.pAddPosto_Click);
            // 
            // cmbPosto
            // 
            this.cmbPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbPosto.DisplayMember = "Nome";
            this.cmbPosto.ForeColor = System.Drawing.Color.Black;
            this.cmbPosto.Location = new System.Drawing.Point(116, 72);
            this.cmbPosto.Name = "cmbPosto";
            this.cmbPosto.Size = new System.Drawing.Size(290, 41);
            this.cmbPosto.TabIndex = 8;
            this.cmbPosto.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.Text = "Posto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.Text = "Preço/L:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.lTitulo.Text = "Cadastro de Abastecimento";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // CadastroAbastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "CadastroAbastecimento";
            this.tabControl.ResumeLayout(false);
            this.tabPagePercurso.ResumeLayout(false);
            this.tabPageAbastecimento.ResumeLayout(false);
            this.tabPageObs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePercurso;
        private System.Windows.Forms.TabPage tabPageAbastecimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pAddPosto;
        private System.Windows.Forms.ComboBox cmbPosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tValor;
        private System.Windows.Forms.TabPage tabPageObs;
        private System.Windows.Forms.TextBox tObs;
        private System.Windows.Forms.CheckBox chkViagem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.CheckBox chkTanqueCheio;
        private System.Windows.Forms.PictureBox pAddTipo;
        private System.Windows.Forms.ComboBox cmbTipoCombustivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.DateTimePicker hora;
        private System.Windows.Forms.TextBox tIdAbastecimento;
        private System.Windows.Forms.TextBox tValorLitro;
        private System.Windows.Forms.PictureBox pAddVeiculo;
        private System.Windows.Forms.TextBox tLitros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pCalcPrecoLitro;
        private System.Windows.Forms.PictureBox pCalcPrecoTotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.PictureBox pCalcKM;
        private System.Windows.Forms.TextBox tKmInicial;
        private System.Windows.Forms.TextBox tKmFinal;

    }
}