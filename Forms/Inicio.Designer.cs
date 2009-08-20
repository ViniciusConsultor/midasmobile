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
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pSemiTopo = new System.Windows.Forms.PictureBox();
            this.pAbastecimentos = new System.Windows.Forms.PictureBox();
            this.pManutencao = new System.Windows.Forms.PictureBox();
            this.pPostos = new System.Windows.Forms.PictureBox();
            this.lbHora = new System.Windows.Forms.Label();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbConsumoMedio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lAbastecimentos = new System.Windows.Forms.Label();
            this.pIconeAbastecimentos = new System.Windows.Forms.PictureBox();
            this.pIconeManutencoes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pIconeDespesas = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pIconePostos = new System.Windows.Forms.PictureBox();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pDespesas = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pSemiTopo
            // 
            this.pSemiTopo.Image = ((System.Drawing.Image)(resources.GetObject("pSemiTopo.Image")));
            this.pSemiTopo.Location = new System.Drawing.Point(0, 68);
            this.pSemiTopo.Name = "pSemiTopo";
            this.pSemiTopo.Size = new System.Drawing.Size(480, 34);
            this.pSemiTopo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pAbastecimentos
            // 
            this.pAbastecimentos.Image = ((System.Drawing.Image)(resources.GetObject("pAbastecimentos.Image")));
            this.pAbastecimentos.Location = new System.Drawing.Point(0, 104);
            this.pAbastecimentos.Name = "pAbastecimentos";
            this.pAbastecimentos.Size = new System.Drawing.Size(480, 84);
            this.pAbastecimentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAbastecimentos.Click += new System.EventHandler(this.pAbastecimentos_Click);
            // 
            // pManutencao
            // 
            this.pManutencao.Image = ((System.Drawing.Image)(resources.GetObject("pManutencao.Image")));
            this.pManutencao.Location = new System.Drawing.Point(0, 186);
            this.pManutencao.Name = "pManutencao";
            this.pManutencao.Size = new System.Drawing.Size(480, 84);
            this.pManutencao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pManutencao.Click += new System.EventHandler(this.pManutencao_Click);
            // 
            // pPostos
            // 
            this.pPostos.Image = ((System.Drawing.Image)(resources.GetObject("pPostos.Image")));
            this.pPostos.Location = new System.Drawing.Point(0, 345);
            this.pPostos.Name = "pPostos";
            this.pPostos.Size = new System.Drawing.Size(480, 84);
            this.pPostos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPostos.Click += new System.EventHandler(this.pPostos_Click);
            // 
            // lbHora
            // 
            this.lbHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lbHora.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(8, 73);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(448, 24);
            this.lbHora.Text = "Selecione uma opção do menu:";
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.DisplayMember = "Modelo";
            this.cmbVeiculos.Location = new System.Drawing.Point(10, 470);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(198, 41);
            this.cmbVeiculos.TabIndex = 7;
            this.cmbVeiculos.ValueMember = "Id";
            this.cmbVeiculos.SelectedValueChanged += new System.EventHandler(this.cmbVeiculos_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(282, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.Text = "Consumo Médio:";
            // 
            // lbConsumoMedio
            // 
            this.lbConsumoMedio.BackColor = System.Drawing.Color.Silver;
            this.lbConsumoMedio.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbConsumoMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbConsumoMedio.Location = new System.Drawing.Point(210, 468);
            this.lbConsumoMedio.Name = "lbConsumoMedio";
            this.lbConsumoMedio.Size = new System.Drawing.Size(262, 42);
            this.lbConsumoMedio.Text = "000.00Km/L";
            this.lbConsumoMedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.Text = "Veículo:";
            // 
            // lAbastecimentos
            // 
            this.lAbastecimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lAbastecimentos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lAbastecimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lAbastecimentos.Location = new System.Drawing.Point(17, 126);
            this.lAbastecimentos.Name = "lAbastecimentos";
            this.lAbastecimentos.Size = new System.Drawing.Size(368, 44);
            this.lAbastecimentos.Text = "Abastecimentos";
            // 
            // pIconeAbastecimentos
            // 
            this.pIconeAbastecimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pIconeAbastecimentos.Image = ((System.Drawing.Image)(resources.GetObject("pIconeAbastecimentos.Image")));
            this.pIconeAbastecimentos.Location = new System.Drawing.Point(394, 113);
            this.pIconeAbastecimentos.Name = "pIconeAbastecimentos";
            this.pIconeAbastecimentos.Size = new System.Drawing.Size(68, 64);
            this.pIconeAbastecimentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pIconeAbastecimentos.Click += new System.EventHandler(this.pAbastecimentos_Click);
            // 
            // pIconeManutencoes
            // 
            this.pIconeManutencoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pIconeManutencoes.Image = ((System.Drawing.Image)(resources.GetObject("pIconeManutencoes.Image")));
            this.pIconeManutencoes.Location = new System.Drawing.Point(388, 189);
            this.pIconeManutencoes.Name = "pIconeManutencoes";
            this.pIconeManutencoes.Size = new System.Drawing.Size(76, 76);
            this.pIconeManutencoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pIconeManutencoes.Click += new System.EventHandler(this.pManutencao_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 44);
            this.label2.Text = "Manutenções";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(17, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 44);
            this.label4.Text = "Despesas";
            // 
            // pIconeDespesas
            // 
            this.pIconeDespesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pIconeDespesas.Image = ((System.Drawing.Image)(resources.GetObject("pIconeDespesas.Image")));
            this.pIconeDespesas.Location = new System.Drawing.Point(388, 270);
            this.pIconeDespesas.Name = "pIconeDespesas";
            this.pIconeDespesas.Size = new System.Drawing.Size(78, 76);
            this.pIconeDespesas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pIconeDespesas.Click += new System.EventHandler(this.pDespesas_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(17, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 44);
            this.label5.Text = "Postos";
            // 
            // pIconePostos
            // 
            this.pIconePostos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pIconePostos.Image = ((System.Drawing.Image)(resources.GetObject("pIconePostos.Image")));
            this.pIconePostos.Location = new System.Drawing.Point(388, 350);
            this.pIconePostos.Name = "pIconePostos";
            this.pIconePostos.Size = new System.Drawing.Size(76, 76);
            this.pIconePostos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pIconePostos.Click += new System.EventHandler(this.pPostos_Click);
            // 
            // pLogo
            // 
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(2, 6);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(470, 58);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, -3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(480, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pDespesas
            // 
            this.pDespesas.Image = ((System.Drawing.Image)(resources.GetObject("pDespesas.Image")));
            this.pDespesas.Location = new System.Drawing.Point(0, 267);
            this.pDespesas.Name = "pDespesas";
            this.pDespesas.Size = new System.Drawing.Size(480, 84);
            this.pDespesas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pDespesas.Click += new System.EventHandler(this.pDespesas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.pIconeAbastecimentos);
            this.Controls.Add(this.lAbastecimentos);
            this.Controls.Add(this.pAbastecimentos);
            this.Controls.Add(this.pIconeManutencoes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pIconeDespesas);
            this.Controls.Add(this.pDespesas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pIconePostos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbConsumoMedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVeiculos);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.pPostos);
            this.Controls.Add(this.pManutencao);
            this.Controls.Add(this.pSemiTopo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pSemiTopo;
        private System.Windows.Forms.PictureBox pAbastecimentos;
        private System.Windows.Forms.PictureBox pManutencao;
        private System.Windows.Forms.PictureBox pPostos;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbConsumoMedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lAbastecimentos;
        private System.Windows.Forms.PictureBox pIconeAbastecimentos;
        private System.Windows.Forms.PictureBox pIconeManutencoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pIconeDespesas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pIconePostos;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pDespesas;
    }
}