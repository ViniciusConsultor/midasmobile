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
    partial class RelatorioConsumoMedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioConsumoMedio));
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.data1 = new System.Windows.Forms.DateTimePicker();
            this.chkViagem = new System.Windows.Forms.CheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackColor = System.Drawing.Color.White;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGrid.GridLineColor = System.Drawing.Color.DarkGray;
            this.dataGrid.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 143);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.PreferredRowHeight = 20;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.dataGrid.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.Size = new System.Drawing.Size(240, 125);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Km Rodados";
            this.dataGridTextBoxColumn1.MappingName = "KmRodados";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Litros";
            this.dataGridTextBoxColumn2.MappingName = "LitrosConsumidos";
            this.dataGridTextBoxColumn2.Width = 80;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Km/L";
            this.dataGridTextBoxColumn3.MappingName = "ConsumoMedio";
            this.dataGridTextBoxColumn3.Width = 80;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbVeiculos.Location = new System.Drawing.Point(69, 65);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(159, 22);
            this.cmbVeiculos.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.Text = "Veículo:";
            // 
            // cmbTipoCombustivel
            // 
            this.cmbTipoCombustivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbTipoCombustivel.Location = new System.Drawing.Point(69, 90);
            this.cmbTipoCombustivel.Name = "cmbTipoCombustivel";
            this.cmbTipoCombustivel.Size = new System.Drawing.Size(159, 22);
            this.cmbTipoCombustivel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(2, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.Text = "Tipo Comb.:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.Text = "de";
            // 
            // data2
            // 
            this.data2.CustomFormat = "dd/MM/yyyy";
            this.data2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data2.Location = new System.Drawing.Point(145, 38);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(84, 22);
            this.data2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(122, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.Text = "até";
            // 
            // data1
            // 
            this.data1.CustomFormat = "dd/MM/yyyy";
            this.data1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data1.Location = new System.Drawing.Point(35, 38);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(84, 22);
            this.data1.TabIndex = 21;
            // 
            // chkViagem
            // 
            this.chkViagem.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chkViagem.Location = new System.Drawing.Point(69, 116);
            this.chkViagem.Name = "chkViagem";
            this.chkViagem.Size = new System.Drawing.Size(110, 20);
            this.chkViagem.TabIndex = 25;
            this.chkViagem.Text = "Incluir Viagens?";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(175, 116);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(53, 21);
            this.btnGerar.TabIndex = 26;
            this.btnGerar.Text = "Ver";
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
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
            // RelatorioConsumoMedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.chkViagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.cmbTipoCombustivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVeiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid);
            this.Name = "RelatorioConsumoMedio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoCombustivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker data2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker data1;
        private System.Windows.Forms.CheckBox chkViagem;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}