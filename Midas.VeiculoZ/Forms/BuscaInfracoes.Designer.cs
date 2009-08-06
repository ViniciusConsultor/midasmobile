namespace Midas.VeiculoZ.Forms
{
    partial class BuscaInfracoes
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
            this.label10 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.infracoes = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 31);
            this.label10.Text = "Classificação:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbClass.DisplayMember = "Modelo";
            this.cmbClass.Location = new System.Drawing.Point(168, 8);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(217, 41);
            this.cmbClass.TabIndex = 6;
            this.cmbClass.ValueMember = "Id";
            // 
            // infracoes
            // 
            this.infracoes.DisplayMember = "Descricao";
            this.infracoes.Location = new System.Drawing.Point(3, 56);
            this.infracoes.Name = "infracoes";
            this.infracoes.Size = new System.Drawing.Size(476, 408);
            this.infracoes.TabIndex = 7;
            this.infracoes.ValueMember = "Id";
            this.infracoes.SelectedValueChanged += new System.EventHandler(this.infracoes_SelectedValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(391, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 41);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tDescricao
            // 
            this.tDescricao.Location = new System.Drawing.Point(3, 438);
            this.tDescricao.Multiline = true;
            this.tDescricao.Name = "tDescricao";
            this.tDescricao.ReadOnly = true;
            this.tDescricao.Size = new System.Drawing.Size(477, 90);
            this.tDescricao.TabIndex = 10;
            // 
            // BuscaInfracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.tDescricao);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.infracoes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbClass);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "BuscaInfracoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ListBox infracoes;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tDescricao;
    }
}