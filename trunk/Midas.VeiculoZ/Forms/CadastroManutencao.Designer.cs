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
    partial class CadastroManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroManutencao));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tDescricao = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tKm = new System.Windows.Forms.TextBox();
            this.pAddVeiculo = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.chkKm = new System.Windows.Forms.CheckBox();
            this.chkVerificado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 42);
            this.label1.Text = "ID:";
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tId.Location = new System.Drawing.Point(138, 222);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(80, 41);
            this.tId.TabIndex = 17;
            // 
            // tDescricao
            // 
            this.tDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tDescricao.Location = new System.Drawing.Point(138, 320);
            this.tDescricao.MaxLength = 80;
            this.tDescricao.Name = "tDescricao";
            this.tDescricao.Size = new System.Drawing.Size(316, 41);
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
            this.lTitulo.Text = "Cadastro de Manutenção";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.Text = "Lembrar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // data
            // 
            this.data.CustomFormat = "dd/MM/yyyy";
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data.Location = new System.Drawing.Point(138, 368);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(162, 36);
            this.data.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(78, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 30);
            this.label3.Text = "Km:";
            // 
            // tKm
            // 
            this.tKm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tKm.Location = new System.Drawing.Point(138, 412);
            this.tKm.MaxLength = 80;
            this.tKm.Name = "tKm";
            this.tKm.Size = new System.Drawing.Size(162, 41);
            this.tKm.TabIndex = 29;
            // 
            // pAddVeiculo
            // 
            this.pAddVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("pAddVeiculo.Image")));
            this.pAddVeiculo.Location = new System.Drawing.Point(420, 273);
            this.pAddVeiculo.Name = "pAddVeiculo";
            this.pAddVeiculo.Size = new System.Drawing.Size(36, 38);
            this.pAddVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddVeiculo.Click += new System.EventHandler(this.pAddVeiculo_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(22, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 42);
            this.label10.Text = "Veículo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbVeiculos.DisplayMember = "Modelo";
            this.cmbVeiculos.Location = new System.Drawing.Point(138, 270);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(274, 41);
            this.cmbVeiculos.TabIndex = 33;
            this.cmbVeiculos.ValueMember = "Id";
            // 
            // chkKm
            // 
            this.chkKm.Location = new System.Drawing.Point(306, 368);
            this.chkKm.Name = "chkKm";
            this.chkKm.Size = new System.Drawing.Size(152, 44);
            this.chkKm.TabIndex = 47;
            this.chkKm.Text = "Lembrar";
            this.chkKm.CheckStateChanged += new System.EventHandler(this.chkKm_CheckStateChanged);
            // 
            // chkVerificado
            // 
            this.chkVerificado.Location = new System.Drawing.Point(138, 460);
            this.chkVerificado.Name = "chkVerificado";
            this.chkVerificado.Size = new System.Drawing.Size(274, 44);
            this.chkVerificado.TabIndex = 63;
            this.chkVerificado.Text = "Verificado?";
            // 
            // CadastroManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.chkVerificado);
            this.Controls.Add(this.chkKm);
            this.Controls.Add(this.pAddVeiculo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbVeiculos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.tDescricao);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "CadastroManutencao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TextBox tDescricao;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tKm;
        private System.Windows.Forms.PictureBox pAddVeiculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.CheckBox chkKm;
        private System.Windows.Forms.CheckBox chkVerificado;
    }
}