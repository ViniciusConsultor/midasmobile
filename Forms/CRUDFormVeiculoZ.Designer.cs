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
    partial class CRUDFormVeiculoZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDFormVeiculoZ));
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.pVoltar = new System.Windows.Forms.PictureBox();
            this.pExcluir = new System.Windows.Forms.PictureBox();
            this.pSalvar = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pLogo
            // 
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(2, 8);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(470, 58);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pVoltar
            // 
            this.pVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pVoltar.Image")));
            this.pVoltar.Location = new System.Drawing.Point(408, 130);
            this.pVoltar.Name = "pVoltar";
            this.pVoltar.Size = new System.Drawing.Size(60, 60);
            this.pVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pVoltar.Click += new System.EventHandler(this.pVoltar_Click);
            // 
            // pExcluir
            // 
            this.pExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pExcluir.Image")));
            this.pExcluir.Location = new System.Drawing.Point(78, 128);
            this.pExcluir.Name = "pExcluir";
            this.pExcluir.Size = new System.Drawing.Size(60, 60);
            this.pExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pExcluir.Click += new System.EventHandler(this.pExcluir_Click);
            // 
            // pSalvar
            // 
            this.pSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pSalvar.Image")));
            this.pSalvar.Location = new System.Drawing.Point(12, 128);
            this.pSalvar.Name = "pSalvar";
            this.pSalvar.Size = new System.Drawing.Size(60, 60);
            this.pSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pSalvar.Click += new System.EventHandler(this.pSalvar_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 118);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(480, 78);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // CRUDFormVeiculoZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.pVoltar);
            this.Controls.Add(this.pExcluir);
            this.Controls.Add(this.pSalvar);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "CRUDFormVeiculoZ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.PictureBox pVoltar;
        private System.Windows.Forms.PictureBox pExcluir;
        private System.Windows.Forms.PictureBox pSalvar;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}