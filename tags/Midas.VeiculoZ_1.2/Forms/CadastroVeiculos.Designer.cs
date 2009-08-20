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
    partial class CadastroVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVeiculos));
            this.label2 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tPlaca = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tRenavam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tCor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(57, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.Text = "Placa:";
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tId.Location = new System.Drawing.Point(133, 213);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(124, 41);
            this.tId.TabIndex = 15;
            // 
            // tPlaca
            // 
            this.tPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tPlaca.HideSelection = false;
            this.tPlaca.Location = new System.Drawing.Point(133, 443);
            this.tPlaca.MaxLength = 10;
            this.tPlaca.Name = "tPlaca";
            this.tPlaca.Size = new System.Drawing.Size(124, 41);
            this.tPlaca.TabIndex = 5;
            // 
            // lTitulo
            // 
            this.lTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lTitulo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(9, 80);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(396, 34);
            this.lTitulo.Text = "Cadastro de Veículo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.Text = "Renavam:";
            // 
            // tRenavam
            // 
            this.tRenavam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tRenavam.Location = new System.Drawing.Point(133, 259);
            this.tRenavam.MaxLength = 20;
            this.tRenavam.Name = "tRenavam";
            this.tRenavam.Size = new System.Drawing.Size(328, 41);
            this.tRenavam.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(78, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.Text = "Cor:";
            // 
            // tCor
            // 
            this.tCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tCor.Location = new System.Drawing.Point(133, 304);
            this.tCor.MaxLength = 20;
            this.tCor.Name = "tCor";
            this.tCor.Size = new System.Drawing.Size(122, 41);
            this.tCor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(36, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.Text = "Modelo:";
            // 
            // tModelo
            // 
            this.tModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tModelo.Location = new System.Drawing.Point(133, 350);
            this.tModelo.MaxLength = 100;
            this.tModelo.Name = "tModelo";
            this.tModelo.Size = new System.Drawing.Size(328, 41);
            this.tModelo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(49, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.Text = "Marca:";
            // 
            // tMarca
            // 
            this.tMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tMarca.Location = new System.Drawing.Point(133, 397);
            this.tMarca.MaxLength = 100;
            this.tMarca.Name = "tMarca";
            this.tMarca.Size = new System.Drawing.Size(328, 41);
            this.tMarca.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(92, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 40);
            this.label7.Text = "Id:";
            // 
            // CadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tCor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tRenavam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.tPlaca);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "CadastroVeiculos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TextBox tPlaca;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tRenavam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tMarca;
        private System.Windows.Forms.Label label7;
    }
}