namespace SenhaZ
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemCategorias = new System.Windows.Forms.MenuItem();
            this.menuItemNovaCategoria = new System.Windows.Forms.MenuItem();
            this.menuItemListarCategorias = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pbAcessar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuItem1);
            this.mainMenu.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItemCategorias);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.Text = "Opções";
            // 
            // menuItemCategorias
            // 
            this.menuItemCategorias.MenuItems.Add(this.menuItemNovaCategoria);
            this.menuItemCategorias.MenuItems.Add(this.menuItemListarCategorias);
            this.menuItemCategorias.Text = "Categorias";
            // 
            // menuItemNovaCategoria
            // 
            this.menuItemNovaCategoria.Text = "Novo";
            this.menuItemNovaCategoria.Click += new System.EventHandler(this.menuItemNovaCategoria_Click);
            // 
            // menuItemListarCategorias
            // 
            this.menuItemListarCategorias.Text = "Listar";
            this.menuItemListarCategorias.Click += new System.EventHandler(this.menuItemListarCategorias_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Senhas";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 103);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(37, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(85, 133);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(108, 21);
            this.txtSenha.TabIndex = 5;
            // 
            // pbAcessar
            // 
            this.pbAcessar.Image = ((System.Drawing.Image)(resources.GetObject("pbAcessar.Image")));
            this.pbAcessar.Location = new System.Drawing.Point(166, 160);
            this.pbAcessar.Name = "pbAcessar";
            this.pbAcessar.Size = new System.Drawing.Size(30, 36);
            this.pbAcessar.Click += new System.EventHandler(this.pbAcessar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 44);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbAcessar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "SenhaZ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pbAcessar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItemCategorias;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemNovaCategoria;
        private System.Windows.Forms.MenuItem menuItemListarCategorias;
    }
}