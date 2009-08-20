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
    partial class CadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmpresa));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePJ = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tCNPJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tNome = new System.Windows.Forms.TextBox();
            this.tId = new System.Windows.Forms.TextBox();
            this.tabPageEndereco = new System.Windows.Forms.TabPage();
            this.tEnderecoId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tCEP = new System.Windows.Forms.TextBox();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tComplemento = new System.Windows.Forms.TextBox();
            this.pAddCidade = new System.Windows.Forms.PictureBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tRua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBairro = new System.Windows.Forms.TextBox();
            this.tabPageObs = new System.Windows.Forms.TabPage();
            this.tObs = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPagePJ.SuspendLayout();
            this.tabPageEndereco.SuspendLayout();
            this.tabPageObs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePJ);
            this.tabControl.Controls.Add(this.tabPageEndereco);
            this.tabControl.Controls.Add(this.tabPageObs);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControl.Location = new System.Drawing.Point(0, 200);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(480, 336);
            this.tabControl.TabIndex = 105;
            // 
            // tabPagePJ
            // 
            this.tabPagePJ.Controls.Add(this.label4);
            this.tabPagePJ.Controls.Add(this.tCNPJ);
            this.tabPagePJ.Controls.Add(this.label7);
            this.tabPagePJ.Controls.Add(this.label3);
            this.tabPagePJ.Controls.Add(this.tNome);
            this.tabPagePJ.Controls.Add(this.tId);
            this.tabPagePJ.Location = new System.Drawing.Point(0, 0);
            this.tabPagePJ.Name = "tabPagePJ";
            this.tabPagePJ.Size = new System.Drawing.Size(480, 292);
            this.tabPagePJ.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(50, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 40);
            this.label4.Text = "CNPJ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tCNPJ
            // 
            this.tCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tCNPJ.Location = new System.Drawing.Point(128, 120);
            this.tCNPJ.MaxLength = 20;
            this.tCNPJ.Name = "tCNPJ";
            this.tCNPJ.Size = new System.Drawing.Size(328, 41);
            this.tCNPJ.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(84, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 40);
            this.label7.Text = "Id:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 40);
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tNome
            // 
            this.tNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tNome.Location = new System.Drawing.Point(128, 70);
            this.tNome.MaxLength = 255;
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(328, 41);
            this.tNome.TabIndex = 90;
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tId.Location = new System.Drawing.Point(128, 22);
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(124, 41);
            this.tId.TabIndex = 89;
            // 
            // tabPageEndereco
            // 
            this.tabPageEndereco.Controls.Add(this.tEnderecoId);
            this.tabPageEndereco.Controls.Add(this.label9);
            this.tabPageEndereco.Controls.Add(this.tCEP);
            this.tabPageEndereco.Controls.Add(this.tNumero);
            this.tabPageEndereco.Controls.Add(this.label8);
            this.tabPageEndereco.Controls.Add(this.tComplemento);
            this.tabPageEndereco.Controls.Add(this.pAddCidade);
            this.tabPageEndereco.Controls.Add(this.cmbCidade);
            this.tabPageEndereco.Controls.Add(this.label6);
            this.tabPageEndereco.Controls.Add(this.label5);
            this.tabPageEndereco.Controls.Add(this.tRua);
            this.tabPageEndereco.Controls.Add(this.label2);
            this.tabPageEndereco.Controls.Add(this.tBairro);
            this.tabPageEndereco.Location = new System.Drawing.Point(0, 0);
            this.tabPageEndereco.Name = "tabPageEndereco";
            this.tabPageEndereco.Size = new System.Drawing.Size(232, 130);
            this.tabPageEndereco.Text = "Endereço";
            // 
            // tEnderecoId
            // 
            this.tEnderecoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tEnderecoId.Location = new System.Drawing.Point(440, 236);
            this.tEnderecoId.Name = "tEnderecoId";
            this.tEnderecoId.Size = new System.Drawing.Size(34, 41);
            this.tEnderecoId.TabIndex = 114;
            this.tEnderecoId.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 44);
            this.label9.Text = "CEP:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tCEP
            // 
            this.tCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tCEP.Location = new System.Drawing.Point(116, 212);
            this.tCEP.MaxLength = 50;
            this.tCEP.Name = "tCEP";
            this.tCEP.Size = new System.Drawing.Size(328, 41);
            this.tCEP.TabIndex = 108;
            // 
            // tNumero
            // 
            this.tNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tNumero.Location = new System.Drawing.Point(378, 20);
            this.tNumero.MaxLength = 10;
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(70, 41);
            this.tNumero.TabIndex = 106;
            this.tNumero.Text = "S/N";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 44);
            this.label8.Text = "Comp.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tComplemento
            // 
            this.tComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tComplemento.Location = new System.Drawing.Point(116, 164);
            this.tComplemento.MaxLength = 255;
            this.tComplemento.Name = "tComplemento";
            this.tComplemento.Size = new System.Drawing.Size(328, 41);
            this.tComplemento.TabIndex = 104;
            // 
            // pAddCidade
            // 
            this.pAddCidade.Image = ((System.Drawing.Image)(resources.GetObject("pAddCidade.Image")));
            this.pAddCidade.Location = new System.Drawing.Point(382, 72);
            this.pAddCidade.Name = "pAddCidade";
            this.pAddCidade.Size = new System.Drawing.Size(36, 38);
            this.pAddCidade.Click += new System.EventHandler(this.pAddCidade_Click);
            // 
            // cmbCidade
            // 
            this.cmbCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCidade.ForeColor = System.Drawing.Color.Black;
            this.cmbCidade.Location = new System.Drawing.Point(116, 68);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(258, 42);
            this.cmbCidade.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 32);
            this.label6.Text = "Cidade:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 44);
            this.label5.Text = "Rua:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tRua
            // 
            this.tRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tRua.Location = new System.Drawing.Point(116, 20);
            this.tRua.MaxLength = 255;
            this.tRua.Name = "tRua";
            this.tRua.Size = new System.Drawing.Size(258, 41);
            this.tRua.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.Text = "Bairro:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tBairro
            // 
            this.tBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBairro.HideSelection = false;
            this.tBairro.Location = new System.Drawing.Point(116, 116);
            this.tBairro.MaxLength = 255;
            this.tBairro.Name = "tBairro";
            this.tBairro.Size = new System.Drawing.Size(328, 41);
            this.tBairro.TabIndex = 97;
            // 
            // tabPageObs
            // 
            this.tabPageObs.Controls.Add(this.tObs);
            this.tabPageObs.Location = new System.Drawing.Point(0, 0);
            this.tabPageObs.Name = "tabPageObs";
            this.tabPageObs.Size = new System.Drawing.Size(232, 130);
            this.tabPageObs.Text = "Observações";
            // 
            // tObs
            // 
            this.tObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tObs.Location = new System.Drawing.Point(0, 0);
            this.tObs.MaxLength = 255;
            this.tObs.Multiline = true;
            this.tObs.Name = "tObs";
            this.tObs.Size = new System.Drawing.Size(232, 130);
            this.tObs.TabIndex = 0;
            // 
            // lTitulo
            // 
            this.lTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lTitulo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(8, 80);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(396, 34);
            this.lTitulo.Text = "Cadastro de Empresa";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "CadastroEmpresa";
            this.tabControl.ResumeLayout(false);
            this.tabPagePJ.ResumeLayout(false);
            this.tabPageEndereco.ResumeLayout(false);
            this.tabPageObs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNome;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TabPage tabPageEndereco;
        private System.Windows.Forms.TextBox tEnderecoId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tCEP;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tComplemento;
        private System.Windows.Forms.PictureBox pAddCidade;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tRua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBairro;
        private System.Windows.Forms.TabPage tabPageObs;
        private System.Windows.Forms.TextBox tObs;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCNPJ;
    }
}