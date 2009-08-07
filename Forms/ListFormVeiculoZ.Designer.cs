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
    partial class ListFormVeiculoZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListFormVeiculoZ));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pSalvar = new System.Windows.Forms.PictureBox();
            this.pEditar = new System.Windows.Forms.PictureBox();
            this.pExcluir = new System.Windows.Forms.PictureBox();
            this.pVoltar = new System.Windows.Forms.PictureBox();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pSalvar
            // 
            this.pSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pSalvar.Image")));
            this.pSalvar.Location = new System.Drawing.Point(16, 80);
            this.pSalvar.Name = "pSalvar";
            this.pSalvar.Size = new System.Drawing.Size(60, 60);
            this.pSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pSalvar.Click += new System.EventHandler(this.pNovo_Click);
            // 
            // pEditar
            // 
            this.pEditar.Image = ((System.Drawing.Image)(resources.GetObject("pEditar.Image")));
            this.pEditar.Location = new System.Drawing.Point(82, 80);
            this.pEditar.Name = "pEditar";
            this.pEditar.Size = new System.Drawing.Size(60, 60);
            this.pEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pEditar.Click += new System.EventHandler(this.pEditar_Click);
            // 
            // pExcluir
            // 
            this.pExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pExcluir.Image")));
            this.pExcluir.Location = new System.Drawing.Point(148, 80);
            this.pExcluir.Name = "pExcluir";
            this.pExcluir.Size = new System.Drawing.Size(60, 60);
            this.pExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pExcluir.Click += new System.EventHandler(this.pExcluir_Click);
            // 
            // pVoltar
            // 
            this.pVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pVoltar.Image")));
            this.pVoltar.Location = new System.Drawing.Point(412, 82);
            this.pVoltar.Name = "pVoltar";
            this.pVoltar.Size = new System.Drawing.Size(60, 60);
            this.pVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pVoltar.Click += new System.EventHandler(this.pVoltar_Click);
            // 
            // pLogo
            // 
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(2, 8);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(470, 58);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // ListFormVeiculoZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.pVoltar);
            this.Controls.Add(this.pExcluir);
            this.Controls.Add(this.pEditar);
            this.Controls.Add(this.pSalvar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "ListFormVeiculoZ";
            this.Load += new System.EventHandler(this.ListFormVeiculoZ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pSalvar;
        private System.Windows.Forms.PictureBox pEditar;
        private System.Windows.Forms.PictureBox pExcluir;
        private System.Windows.Forms.PictureBox pVoltar;
        private System.Windows.Forms.PictureBox pLogo;

    }
}