namespace Midas.VeiculoZ.Forms
{
    partial class VerificarVersao
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
            this.lblVerificando = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVerificando
            // 
            this.lblVerificando.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblVerificando.Location = new System.Drawing.Point(26, 10);
            this.lblVerificando.Name = "lblVerificando";
            this.lblVerificando.Size = new System.Drawing.Size(185, 30);
            this.lblVerificando.Text = "Verificar Atualizações Online. ";
            this.lblVerificando.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUpdate
            // 
            this.lblUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblUpdate.ForeColor = System.Drawing.Color.Gray;
            this.lblUpdate.Location = new System.Drawing.Point(15, 52);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(209, 43);
            this.lblUpdate.Tag = "";
            this.lblUpdate.Text = "Clique em Buscar";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(123, 115);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 22);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(30, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 22);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // VerificarVersao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblVerificando);
            this.Name = "VerificarVersao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVerificando;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnBuscar;
    }
}