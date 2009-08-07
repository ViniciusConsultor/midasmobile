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
    partial class RelatorioGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioGeral));
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tGastoTotal = new System.Windows.Forms.TextBox();
            this.tTotalLitros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tTotalKM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tMelhorPosto = new System.Windows.Forms.TextBox();
            this.tPiorPosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbVeiculos.Location = new System.Drawing.Point(89, 53);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(136, 22);
            this.cmbVeiculos.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.Text = "Veículo:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.Text = "Gasto Total:";
            // 
            // tGastoTotal
            // 
            this.tGastoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tGastoTotal.Location = new System.Drawing.Point(89, 81);
            this.tGastoTotal.Name = "tGastoTotal";
            this.tGastoTotal.ReadOnly = true;
            this.tGastoTotal.Size = new System.Drawing.Size(136, 21);
            this.tGastoTotal.TabIndex = 46;
            // 
            // tTotalLitros
            // 
            this.tTotalLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tTotalLitros.Location = new System.Drawing.Point(89, 108);
            this.tTotalLitros.Name = "tTotalLitros";
            this.tTotalLitros.ReadOnly = true;
            this.tTotalLitros.Size = new System.Drawing.Size(136, 21);
            this.tTotalLitros.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.Text = "Total Litros:";
            // 
            // tTotalKM
            // 
            this.tTotalKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tTotalKM.Location = new System.Drawing.Point(89, 134);
            this.tTotalKM.Name = "tTotalKM";
            this.tTotalKM.ReadOnly = true;
            this.tTotalKM.Size = new System.Drawing.Size(136, 21);
            this.tTotalKM.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.Text = "Total KM:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.Text = "Melhor Posto:";
            // 
            // tMelhorPosto
            // 
            this.tMelhorPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tMelhorPosto.Location = new System.Drawing.Point(89, 160);
            this.tMelhorPosto.Name = "tMelhorPosto";
            this.tMelhorPosto.ReadOnly = true;
            this.tMelhorPosto.Size = new System.Drawing.Size(136, 21);
            this.tMelhorPosto.TabIndex = 62;
            // 
            // tPiorPosto
            // 
            this.tPiorPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tPiorPosto.Location = new System.Drawing.Point(89, 187);
            this.tPiorPosto.Name = "tPiorPosto";
            this.tPiorPosto.ReadOnly = true;
            this.tPiorPosto.Size = new System.Drawing.Size(136, 21);
            this.tPiorPosto.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.Text = "Pior Posto:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(153, 214);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 20);
            this.btnSair.TabIndex = 72;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pLogo
            // 
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(1, 4);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(235, 29);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // RelatorioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tPiorPosto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tMelhorPosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tTotalKM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tTotalLitros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tGastoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVeiculos);
            this.Controls.Add(this.label2);
            this.Name = "RelatorioGeral";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tGastoTotal;
        private System.Windows.Forms.TextBox tTotalLitros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tTotalKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tMelhorPosto;
        private System.Windows.Forms.TextBox tPiorPosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}