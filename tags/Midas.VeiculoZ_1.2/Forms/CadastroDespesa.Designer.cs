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
    partial class CadastroDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDespesa));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tDescricao = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pAddVeiculo = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tValor = new System.Windows.Forms.TextBox();
            this.pAddTipo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.hora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.pAddLocal = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLocais = new System.Windows.Forms.ComboBox();
            this.pCalcValor = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 40);
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(86, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 42);
            this.label1.Text = "ID:";
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tId.Location = new System.Drawing.Point(130, 212);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(110, 41);
            this.tId.TabIndex = 17;
            // 
            // tDescricao
            // 
            this.tDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tDescricao.Location = new System.Drawing.Point(130, 310);
            this.tDescricao.MaxLength = 80;
            this.tDescricao.Name = "tDescricao";
            this.tDescricao.Size = new System.Drawing.Size(330, 41);
            this.tDescricao.TabIndex = 15;
            // 
            // lTitulo
            // 
            this.lTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lTitulo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(6, 80);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(406, 34);
            this.lTitulo.Text = "Cadastro de Despesa";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pAddVeiculo
            // 
            this.pAddVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("pAddVeiculo.Image")));
            this.pAddVeiculo.Location = new System.Drawing.Point(421, 360);
            this.pAddVeiculo.Name = "pAddVeiculo";
            this.pAddVeiculo.Size = new System.Drawing.Size(36, 38);
            this.pAddVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddVeiculo.Click += new System.EventHandler(this.pAddVeiculo_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(18, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 42);
            this.label10.Text = "Veículo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbVeiculos.DisplayMember = "Modelo";
            this.cmbVeiculos.Location = new System.Drawing.Point(130, 356);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(284, 42);
            this.cmbVeiculos.TabIndex = 26;
            this.cmbVeiculos.ValueMember = "Id";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(244, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 30);
            this.label9.Text = "Valor:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tValor
            // 
            this.tValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tValor.Location = new System.Drawing.Point(322, 214);
            this.tValor.Name = "tValor";
            this.tValor.Size = new System.Drawing.Size(102, 41);
            this.tValor.TabIndex = 30;
            // 
            // pAddTipo
            // 
            this.pAddTipo.Image = ((System.Drawing.Image)(resources.GetObject("pAddTipo.Image")));
            this.pAddTipo.Location = new System.Drawing.Point(421, 410);
            this.pAddTipo.Name = "pAddTipo";
            this.pAddTipo.Size = new System.Drawing.Size(36, 38);
            this.pAddTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddTipo.Click += new System.EventHandler(this.pAddTipo_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.Text = "Tipo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbTipos
            // 
            this.cmbTipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbTipos.DisplayMember = "Modelo";
            this.cmbTipos.Location = new System.Drawing.Point(130, 406);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(284, 42);
            this.cmbTipos.TabIndex = 34;
            this.cmbTipos.ValueMember = "Id";
            // 
            // hora
            // 
            this.hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hora.Location = new System.Drawing.Point(298, 260);
            this.hora.Name = "hora";
            this.hora.ShowUpDown = true;
            this.hora.Size = new System.Drawing.Size(162, 36);
            this.hora.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(38, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.Text = "Data:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // data
            // 
            this.data.CustomFormat = "dd/MM/yyyy";
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data.Location = new System.Drawing.Point(130, 260);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(162, 36);
            this.data.TabIndex = 38;
            // 
            // pAddLocal
            // 
            this.pAddLocal.Image = ((System.Drawing.Image)(resources.GetObject("pAddLocal.Image")));
            this.pAddLocal.Location = new System.Drawing.Point(421, 458);
            this.pAddLocal.Name = "pAddLocal";
            this.pAddLocal.Size = new System.Drawing.Size(36, 38);
            this.pAddLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddLocal.Click += new System.EventHandler(this.pAddLocal_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.Text = "Local:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbLocais
            // 
            this.cmbLocais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbLocais.DisplayMember = "Modelo";
            this.cmbLocais.Location = new System.Drawing.Point(130, 454);
            this.cmbLocais.Name = "cmbLocais";
            this.cmbLocais.Size = new System.Drawing.Size(284, 42);
            this.cmbLocais.TabIndex = 43;
            this.cmbLocais.ValueMember = "Id";
            // 
            // pCalcValor
            // 
            this.pCalcValor.Image = ((System.Drawing.Image)(resources.GetObject("pCalcValor.Image")));
            this.pCalcValor.Location = new System.Drawing.Point(428, 219);
            this.pCalcValor.Name = "pCalcValor";
            this.pCalcValor.Size = new System.Drawing.Size(22, 30);
            this.pCalcValor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCalcValor.Click += new System.EventHandler(this.pCalcValor_Click);
            // 
            // CadastroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.pCalcValor);
            this.Controls.Add(this.pAddLocal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLocais);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data);
            this.Controls.Add(this.pAddTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tValor);
            this.Controls.Add(this.pAddVeiculo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbVeiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.tDescricao);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "CadastroDespesa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TextBox tDescricao;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pAddVeiculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tValor;
        private System.Windows.Forms.PictureBox pAddTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.DateTimePicker hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.PictureBox pAddLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLocais;
        private System.Windows.Forms.PictureBox pCalcValor;
    }
}