﻿/*
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
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Midas.Nucleo.Form;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{
    public partial class CRUDFormVeiculoZ : CRUDForm
    {
        public CRUDFormVeiculoZ()
        {
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("IconeSalvar", pSalvar);
            CarregadorImagens.ObterImagemCompativel("IconeVoltar", pVoltar);
            CarregadorImagens.ObterImagemCompativel("IconeExcluir", pExcluir);
            CarregadorImagens.ObterImagemCompativel("Logo", pLogo);
        }

        public virtual void pVoltar_Click(object sender, EventArgs e)
        {

        }

        public virtual void pSalvar_Click(object sender, EventArgs e)
        {

        }

        public virtual void pExcluir_Click(object sender, EventArgs e)
        {

        }

        private void pNovo_Click(object sender, EventArgs e)
        {

        }

    }
}