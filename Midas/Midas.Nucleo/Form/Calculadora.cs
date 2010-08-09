using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midas.Nucleo.Form
{
    public partial class Calculadora : System.Windows.Forms.Form
    {
        private TextBox texto;

        public Calculadora(TextBox t)
        {
            InitializeComponent();
            this.texto = t;
            tValor.Text = t.Text; 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            texto.Text = tValor.Text;
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tValor.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "0";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + ".";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + ",";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tValor.Text = tValor.Text + "7";
        }
    }
}